using DAM_CRUDTerritoris.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM_CRUDTerritoris.FORMULARIS
{
    public partial class FrmMunicipis: Form
    {
        ClBd bd { get; set; }
        DataTable dTable { get; set; } = new DataTable(); 
        DataTable dtMunicipis { get; set; } = new DataTable();

        FrmABMMunicipis fABMMunicipis = null;

        public FrmMunicipis(ClBd xbd)
        {
            InitializeComponent();
            bd = xbd;
        }

        private void getDades() {
            String xsql = "";

            xsql = "SELECT * FROM Municipis";
            
            dTable.Clear();
            if (bd.getDades(xsql, dTable)) {
                dgDades.DataSource = dTable;
            } else {
                MessageBox.Show("No s'han pogut obtenir les dades dels territoris", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMunicipis_Load(object sender, EventArgs e) {
            getDades();
        }

        private void dgDades_DoubleClick(object sender, EventArgs e) {
            fABMMunicipis = new FrmABMMunicipis('M', bd);

            // posem les dades de la fila a les propietats de fABMTerritoris
            fABMMunicipis._id = dgDades.SelectedRows[0].Cells["_id"].Value.ToString().Trim();
            fABMMunicipis.CodiINE = dgDades.SelectedRows[0].Cells["CodiINE"].Value.ToString().Trim();
            fABMMunicipis.Nom = dgDades.SelectedRows[0].Cells["Nom"].Value.ToString().Trim();

            fABMMunicipis.Web = dgDades.SelectedRows[0].Cells["Web"].Value.ToString().Trim();
            fABMMunicipis.Escut = dgDades.SelectedRows[0].Cells["Escut"].Value.ToString().Trim();
            fABMMunicipis.Altitud = int.Parse(dgDades.SelectedRows[0].Cells["Altura"].Value.ToString().Trim());
            fABMMunicipis.Habitants = int.Parse(dgDades.SelectedRows[0].Cells["Habitants"].Value.ToString().Trim());

            fABMMunicipis.CentreLongitud = float.Parse(dgDades.SelectedRows[0].Cells["CentreLongitud"].Value.ToString().Trim());
            fABMMunicipis.CentreLatitud = float.Parse(dgDades.SelectedRows[0].Cells["CentreLatitud"].Value.ToString().Trim());

            fABMMunicipis.CodiComarca = dgDades.SelectedRows[0].Cells["CodiComarca"].Value.ToString().Trim();

            fABMMunicipis.ShowDialog();

            getDades();         // refresquem el datagridview
            if (fABMMunicipis._id != "") {
                seleccionarFila(fABMMunicipis._id);
            }

            fABMMunicipis = null;
        }

        private void seleccionarFila(string id) {
            DataTable taula = (DataTable)dgDades.DataSource;
            DataRow[] vFiles = taula.Select($"_id = '{id}'");   // retorna un vector amb les files que compleixen la comparació
                                                                        // com que busquem per id, com a màxim se'n trobarà una    

            dgDades.ClearSelection();               // deseleccionem les que puguin estar seleccionades
            if (vFiles.Length > 0) {
                int x = taula.Rows.IndexOf(vFiles[0]);      // ens marca la posició de la fila trobada
                dgDades.Rows[x].Selected = true;
            } else {
                // si no es troba la fila seleccionem la primera si és que n'hi ha alguna
                if (dgDades.Rows.Count > 0) {
                    dgDades.Rows[0].Selected = true;
                }
            }
        }

        private void pbAdd_Click(object sender, EventArgs e) {
            fABMMunicipis = new FrmABMMunicipis('A', bd);
            fABMMunicipis.ShowDialog();

            getDades();         // refresquem el datagridview
            if (fABMMunicipis._id != "") {
                seleccionarFila(fABMMunicipis._id);         // ens hem d'assegurar que, al fer l'alta, posem tbId.Text a la propietat pública id
            }
            fABMMunicipis = null;
        }

        private void pbDel_Click(object sender, EventArgs e) {
            if (dgDades.Rows.Count > 0) {
                fABMMunicipis = new FrmABMMunicipis('B', bd);

                // posem les dades de la fila a les propietats de fABMTerritoris
                fABMMunicipis._id = dgDades.SelectedRows[0].Cells["_id"].Value.ToString().Trim();
                fABMMunicipis.CodiINE = dgDades.SelectedRows[0].Cells["CodiINE"].Value.ToString().Trim();
                fABMMunicipis.Nom = dgDades.SelectedRows[0].Cells["Nom"].Value.ToString().Trim();

                fABMMunicipis.Web = dgDades.SelectedRows[0].Cells["Web"].Value.ToString().Trim();
                fABMMunicipis.Escut = dgDades.SelectedRows[0].Cells["Escut"].Value.ToString().Trim();
                fABMMunicipis.Altitud = int.Parse(dgDades.SelectedRows[0].Cells["Altura"].Value.ToString().Trim());
                fABMMunicipis.Habitants = int.Parse(dgDades.SelectedRows[0].Cells["Habitants"].Value.ToString().Trim());

                fABMMunicipis.CentreLongitud = float.Parse(dgDades.SelectedRows[0].Cells["CentreLongitud"].Value.ToString().Trim());
                fABMMunicipis.CentreLatitud = float.Parse(dgDades.SelectedRows[0].Cells["CentreLatitud"].Value.ToString().Trim());

                fABMMunicipis.CodiComarca = dgDades.SelectedRows[0].Cells["CodiComarca"].Value.ToString().Trim();

                fABMMunicipis.ShowDialog();

                getDades();     // refresquem el datagridview

                fABMMunicipis = null;
            } else {
                MessageBox.Show("No has seleccionat cap fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
