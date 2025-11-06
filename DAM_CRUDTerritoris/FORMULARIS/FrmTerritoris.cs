using DAM_CRUDTerritoris.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM_CRUDTerritoris.FORMULARIS
{
    public partial class FrmTerritoris : Form
    {
        // Propietats
        ClBd bd { get; set; }        // rebrem la classe ClBd que gestiona la base de dades des del FrmMain a través del constructor
        DataTable dTable { get; set; } = new DataTable();    // En el DataTable és on es deixarem les dades que s'han obtingut al fer la consulta a la base de dades  
        DataTable dtRegions { get; set; } = new DataTable(); // En aquest DataTable deixarem les dades de les regions per a omplir el combobox

        // Utilitzarem aquest formulari per a fer les operacions d'alta, baixa i modificació
        FrmABMTerritoris fABMTerritoris = null; 

        public FrmTerritoris(ClBd xbd)
        {
            InitializeComponent();
            bd=xbd;
        }

        #region ------------------------- EVENTS DEL FORM I OBJECTES ---------------------------
        private void FrmTerritoris_Load(object sender, EventArgs e)
        {
            if (bd.testConnexio())
            {
                getDades();
                iniDgrid();
                omplirComboRegions();
            }
        }

        // arribem aquí quan canvia el combobox
        private void cbRegions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //getDadesSenseFiltre();
            getDades();
        }

        // activem o desactivem el combobox depenent del checkbox
        private void chkTotes_CheckedChanged(object sender, EventArgs e)
        {
            cbRegions.Enabled = !chkTotes.Checked;
            getDades();
        }

        // obrim el form per a fer una alta
        private void pbAdd_Click(object sender, EventArgs e)
        {
            fABMTerritoris = new FrmABMTerritoris('A',bd);
            fABMTerritoris.ShowDialog();

            getDades();         // refresquem el datagridview
            if (fABMTerritoris.id != "")
            {
                seleccionarFila(fABMTerritoris.id);         // ens hem d'assegurar que, al fer l'alta, posem tbId.Text a la propietat pública id
            }
            fABMTerritoris = null;
        }

        // obrim el form per a fer una baixa
        private void pbDel_Click(object sender, EventArgs e)
        {
            if (dgDades.Rows.Count > 0) {
                fABMTerritoris = new FrmABMTerritoris('B', bd);

                // posem les dades de la fila a les propietats de fABMTerritoris
                fABMTerritoris.id = dgDades.SelectedRows[0].Cells["TerritoryID"].Value.ToString().Trim();
                fABMTerritoris.descripcio = dgDades.SelectedRows[0].Cells["TerritoryDescription"].Value.ToString().Trim();
                fABMTerritoris.idRegio = (int) dgDades.SelectedRows[0].Cells["RegionID"].Value;

                fABMTerritoris.ShowDialog();

                getDades();     // refresquem el datagridview

                fABMTerritoris = null;
            } else
            {
                MessageBox.Show("No has seleccionat cap fila","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void dgDades_DoubleClick(object sender, EventArgs e)
        {
            fABMTerritoris = new FrmABMTerritoris('M', bd);

            // posem les dades de la fila a les propietats de fABMTerritoris
            fABMTerritoris.id = dgDades.SelectedRows[0].Cells["TerritoryID"].Value.ToString().Trim();
            fABMTerritoris.descripcio = dgDades.SelectedRows[0].Cells["TerritoryDescription"].Value.ToString().Trim();
            fABMTerritoris.idRegio = (int)dgDades.SelectedRows[0].Cells["RegionID"].Value;

            fABMTerritoris.ShowDialog();

            getDades();         // refresquem el datagridview
            if (fABMTerritoris.id != "")
            {
                seleccionarFila(fABMTerritoris.id);
            }

            fABMTerritoris = null;
        }
        #endregion

        #region ------------------------- ALTRES MÈTODES (FUNCIONS I PROCEDIMENTS) ---------------------------
        // obtenim les dades dels territoris
        private void getDades()
        {
            String xsql = "";

            if ((cbRegions.SelectedValue != null) && (cbRegions.Enabled))
            {
                String idRegio = ((DataRowView)cbRegions.SelectedItem)["RegionID"].ToString();
                xsql = "SELECT * FROM Territories T JOIN Region R ON (T.RegionID=R.RegionID) WHERE (T.RegionID='" + idRegio + "') ORDER BY TerritoryDescription";
            }
            else
            {
                xsql = "SELECT * FROM Territories T JOIN Region R ON (T.RegionID=R.RegionID) ORDER BY TerritoryDescription";
            }

            dTable.Clear();
            if (bd.getDades(xsql,dTable))
            {
                dgDades.DataSource = dTable;
            }
            else
            {
                MessageBox.Show("No s'han pogut obtenir les dades dels territoris", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // personalitzem el DataGridView
        private void iniDgrid()
        {
            dgDades.Columns["TerritoryID"].HeaderText = "Id";
            dgDades.Columns["TerritoryDescription"].HeaderText = "Descripció";
            dgDades.Columns[2].Visible = false;
            dgDades.Columns[3].Visible = false;
            dgDades.Columns["RegionDescription"].HeaderText = "Regió";
        }

        // posem les regions al combobox
        private void omplirComboRegions()
        {
            String xsql = "SELECT * FROM Region ORDER BY RegionDescription";

            if (bd.getDades(xsql, dtRegions))
            {
                if (dtRegions.Rows.Count > 0)
                {
                    cbRegions.DataSource = dtRegions;
                    cbRegions.DisplayMember = "RegionDescription";
                    cbRegions.ValueMember = "RegionID";
                }
                else
                {
                    cbRegions.DataSource = null;
                    cbRegions.DisplayMember = "";
                    cbRegions.ValueMember = "";
                }
            }
            else
            { 
                    MessageBox.Show("No s'han pogut obtenir les dades de les regions", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // busquem una fila en el datagridview i la seleccionem
        private void seleccionarFila(string id)
        {
            DataTable taula = (DataTable) dgDades.DataSource;
            DataRow[] vFiles = taula.Select($"TerritoryID = '{id}'");   // retorna un vector amb les files que compleixen la comparació
                                                                        // com que busquem per id, com a màxim se'n trobarà una    

            dgDades.ClearSelection();               // deseleccionem les que puguin estar seleccionades
            if (vFiles.Length > 0)
            {
                int x = taula.Rows.IndexOf(vFiles[0]);      // ens marca la posició de la fila trobada
                dgDades.Rows[x].Selected = true;
            }
            else
            {
                // si no es troba la fila seleccionem la primera si és que n'hi ha alguna
                if (dgDades.Rows.Count > 0)
                {
                    dgDades.Rows[0].Selected = true;
                }
            }
        }
        #endregion

        private void dgDades_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}

