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
    public partial class FrmComarca: Form
    {
        ClBd bd { get; set; }
        DataTable dTable { get; set; } = new DataTable(); 
        DataTable dtMunicipis { get; set; } = new DataTable();

        FrmABMComarcas fABMComarcas = null;

        public FrmComarca(ClBd xbd)
        {
            InitializeComponent();
            bd = xbd;
        }

        private void getDades() {
            String xsql = "";

            xsql = "SELECT * FROM Comarques";
            
            dTable.Clear();
            if (bd.getDades(xsql, dTable)) {
                dgDades.DataSource = dTable;
            } else {
                MessageBox.Show("No s'han pogut obtenir les dades dels territoris", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmComarca_Load(object sender, EventArgs e) {
            getDades();
        }

        private void dgDades_DoubleClick(object sender, EventArgs e) {
            fABMComarcas = new FrmABMComarcas('M', bd);

            // posem les dades de la fila a les propietats de fABMTerritoris
            fABMComarcas.NomComarca = dgDades.SelectedRows[0].Cells["NomComarca"].Value.ToString().Trim();
            fABMComarcas.Habitants = int.Parse(dgDades.SelectedRows[0].Cells["Habitants"].Value.ToString().Trim());
            fABMComarcas.Extensio = float.Parse(dgDades.SelectedRows[0].Cells["extensio"].Value.ToString().Trim());
            fABMComarcas.CodiComarca = dgDades.SelectedRows[0].Cells["CodiComarca"].Value.ToString().Trim();

            fABMComarcas.ShowDialog();

            getDades();         // refresquem el datagridview
            if (fABMComarcas.CodiComarca != "") {
                seleccionarFila(fABMComarcas.CodiComarca);
            }

            fABMComarcas = null;
        }

        private void seleccionarFila(string codiComarca) {
            DataTable taula = (DataTable)dgDades.DataSource;
            DataRow[] vFiles = taula.Select($"CodiComarca = '{codiComarca}'");   // retorna un vector amb les files que compleixen la comparació
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
            fABMComarcas = new FrmABMComarcas('A', bd);
            fABMComarcas.ShowDialog();

            getDades();         // refresquem el datagridview
            if (fABMComarcas.CodiComarca != "") {
                seleccionarFila(fABMComarcas.CodiComarca);         // ens hem d'assegurar que, al fer l'alta, posem tbId.Text a la propietat pública id
            }
            fABMComarcas = null;
        }

        private void pbDel_Click(object sender, EventArgs e) {
            if (dgDades.Rows.Count > 0) {
                fABMComarcas = new FrmABMComarcas('B', bd);

                // posem les dades de la fila a les propietats de fABMTerritoris
                fABMComarcas.NomComarca = dgDades.SelectedRows[0].Cells["NomComarca"].Value.ToString().Trim();
                fABMComarcas.Habitants = int.Parse(dgDades.SelectedRows[0].Cells["Habitants"].Value.ToString().Trim());
                fABMComarcas.Extensio = float.Parse(dgDades.SelectedRows[0].Cells["Extensio"].Value.ToString().Trim());
                fABMComarcas.CodiComarca = dgDades.SelectedRows[0].Cells["CodiComarca"].Value.ToString().Trim();

                fABMComarcas.ShowDialog();

                getDades();     // refresquem el datagridview

                fABMComarcas = null;
            } else {
                MessageBox.Show("No has seleccionat cap fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
