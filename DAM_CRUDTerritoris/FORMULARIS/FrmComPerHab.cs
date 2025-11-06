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

namespace DAM_CRUDTerritoris.FORMULARIS {
    public partial class FrmComPerHab : Form {
        ClBd bd { get; set; }
        DataTable dTable { get; set; } = new DataTable();

        public FrmComPerHab(ClBd xbd) {
            InitializeComponent();
            bd = xbd;
        }

        private void FrmComPerHab_Load(object sender, EventArgs e) {
            getDades();
        }

        private void getDades() {
            String xsql = "";
            int habitants = (int)nudHabitants.Value;

            xsql = $"SELECT * FROM Comarques WHERE Habitants >= {habitants}";

            dTable.Clear();
            if (bd.getDades(xsql, dTable)) {
                dgDades.DataSource = dTable;
            } else {
                MessageBox.Show("No s'han pogut obtenir les dades dels territoris", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nudHabitants_ValueChanged(object sender, EventArgs e) {
            getDades();
        }
    }
}
