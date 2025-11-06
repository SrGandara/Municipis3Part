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
    public partial class FrmMunPerCom : Form {
        ClBd bd { get; set; }
        DataTable dTable { get; set; } = new DataTable();
        DataTable dtCodiComarcas { get; set; } = new DataTable();
        public string CodiComarca { get; set; } = "3";

        public FrmMunPerCom(ClBd xbd) {
            InitializeComponent();
            bd = xbd;
        }

        private void FrmMunPerCom_Load(object sender, EventArgs e) {
            omplirComboRegions();
            
            if (!string.IsNullOrEmpty(CodiComarca)) {
                SeleccionarComboPorValor(cbCodiComarcas, CodiComarca);
            }
            getDades();
        }

        private void omplirComboRegions() {
            String xsql = "SELECT codiComarca, nomComarca, extensio FROM Comarques ORDER BY nomComarca";

            if (bd.getDades(xsql, dtCodiComarcas)) {
                if (dtCodiComarcas.Rows.Count > 0) {
                    // Important: primer DisplayMember/ValueMember, després DataSource per evitar reinicis inesperats
                    cbCodiComarcas.DisplayMember = "nomComarca";
                    cbCodiComarcas.ValueMember = "codiComarca";
                    cbCodiComarcas.DataSource = dtCodiComarcas;
                } else {
                    cbCodiComarcas.DataSource = null;
                    cbCodiComarcas.DisplayMember = "";
                    cbCodiComarcas.ValueMember = "";
                }
            } else {
                MessageBox.Show("No s'han pogut obtenir les dades de les comarques", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SeleccionarComboPorValor(ComboBox cb, string valorBuscado) {
            if (cb == null || string.IsNullOrEmpty(valorBuscado) || cb.DataSource == null) return;

            // 1) Intent directe (el més ràpid)
            try {
                cb.SelectedValue = valorBuscado;
                if (cb.SelectedIndex >= 0) return; // ja seleccionat correctament
            }
            catch {
                // ignorar i provar el bucle
            }

            // 2) Si no funciona, cercar manualment comparant strings (trim i ignorecase)
            for (int i = 0; i < cb.Items.Count; i++) {
                var drv = cb.Items[i] as DataRowView;
                if (drv != null) {
                    var val = drv[cb.ValueMember]?.ToString();
                    if (string.Equals(val?.Trim(), valorBuscado.Trim(), StringComparison.OrdinalIgnoreCase)) {
                        cb.SelectedIndex = i;
                        return;
                    }
                } else {
                    // Si no és DataRowView (poc probable si fas DataSource a DataTable), fer fallback a ToString
                    var itemText = cb.Items[i]?.ToString();
                    if (string.Equals(itemText?.Trim(), valorBuscado.Trim(), StringComparison.OrdinalIgnoreCase)) {
                        cb.SelectedIndex = i;
                        return;
                    }
                }
            }

            // 3) Opcional: si encara no es troba, deixar SelectedIndex = -1 o fer alguna acció
            cb.SelectedIndex = -1;
        }
        private string EscaparSQL(string valor) {
            if (valor == null) return "";
            return valor.Replace("'", "''");
        }

        private void getDades() {
            String xsql = "";
            CodiComarca = cbCodiComarcas.SelectedValue?.ToString().Trim() ?? "";
            string codiComarca = string.IsNullOrWhiteSpace(CodiComarca) ? "NULL" : "N'" + EscaparSQL(CodiComarca) + "'";

            xsql = $"SELECT * FROM Municipis WHERE CodiComarca = {codiComarca}";

            dTable.Clear();
            if (bd.getDades(xsql, dTable)) {
                dgDades.DataSource = dTable;
            } else {
                MessageBox.Show("No s'han pogut obtenir les dades dels territoris", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCodiComarcas_SelectedValueChanged(object sender, EventArgs e) {
            getDades();
        }

        private void dgDades_DoubleClick(object sender, EventArgs e) {
            var CentreLongitud = float.Parse(dgDades.SelectedRows[0].Cells["CentreLongitud"].Value.ToString().Trim());
            var CentreLatitud = float.Parse(dgDades.SelectedRows[0].Cells["CentreLatitud"].Value.ToString().Trim());

            string url = $"https://www.google.com/maps?q={CentreLatitud.ToString(System.Globalization.CultureInfo.InvariantCulture)},{CentreLongitud.ToString(System.Globalization.CultureInfo.InvariantCulture)}";

            // Open it in the default browser
            try {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex) {
                MessageBox.Show($"Error opening Google Maps: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
