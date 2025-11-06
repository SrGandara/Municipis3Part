using DAM_CRUDTerritoris.CLASSES;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace DAM_CRUDTerritoris.FORMULARIS {
    public partial class FrmABMMunicipis : Form {
        // Propietats corresponents als camps de la taula de la base de dades.
        public string _id { get; set; } = "";
        public string CodiINE { get; set; } = "";
        public string Nom { get; set; } = "";
        public float CentreLatitud { get; set; } = 0;
        public float CentreLongitud { get; set; } = 0;
        public string Web { get; set; } = "";
        public string Escut { get; set; } = "";
        public string Bandera { get; set; } = "";
        public int Altitud { get; set; } = 0;
        public int Habitants { get; set; } = 0;
        public string CodiComarca { get; set; } = "";

        // Altres propietats
        Char op { get; set; } = '\0';   // A, B, M
        ClBd bd { get; set; }
        DataTable dtCodiComarcas { get; set; } = new DataTable();

        public FrmABMMunicipis(Char xop, ClBd xbd) {
            InitializeComponent();
            op = xop;
            bd = xbd;
        }

        // Asegúrate en el diseñador de enlazar este handler al Load del form:
        private void FrmABMMunicipis_Load(object sender, EventArgs e) {
            omplirComboRegions();

            switch (op) {
                case 'A': this.Text = "Alta d'un nou municipi"; break;
                case 'B': this.Text = "Eliminar el municipi"; break;
                case 'M': this.Text = "Modificar el municipi"; break;
            }

            // omplim les dades en el form
            tbId.Text = _id;
            tbCodiIne.Text = CodiINE;
            tbNom.Text = Nom;
            tbCentreLong.Text = CentreLongitud.ToString(CultureInfo.InvariantCulture);
            tbCentreLat.Text = CentreLatitud.ToString(CultureInfo.InvariantCulture);
            tbWeb.Text = Web;
            tbEscut.Text = Escut;
            tbBandera.Text = Bandera;
            nudAltura.Value = Altitud;
            nudHabitants.Value = Habitants;

            // Seleccionar el valor correcte si el DataSource ja està carregat
            if (!string.IsNullOrEmpty(CodiComarca)) {
                SeleccionarComboPorValor(cbCodiComarcas, CodiComarca);
            }

            // activar/desactivar controls segons operació
            tbId.Enabled = (op == 'A');
            tbCodiIne.Enabled = (op != 'B');
            tbNom.Enabled = (op != 'B');
            tbCentreLat.Enabled = (op != 'B');
            tbCentreLong.Enabled = (op != 'B');
            tbWeb.Enabled = (op != 'B');
            tbEscut.Enabled = (op != 'B');
            tbBandera.Enabled = (op != 'B');
            nudAltura.Enabled = (op != 'B');
            nudHabitants.Enabled = (op != 'B');
            cbCodiComarcas.Enabled = (op != 'B');
        }

        private void btNo_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e) {
            if (vDades()) {
                switch (op) {
                    case 'A': addTerritori(); break;
                    case 'B': delTerritori(); break;
                    case 'M': updTerritori(); break;
                }
                this.Close();
            }
        }

        // --------- Helpers ----------
        private string EscaparSQL(string valor) {
            if (valor == null) return "";
            return valor.Replace("'", "''");
        }

        // posem les regions al combobox (fixats noms de taula i columnes)
        // omplirComboRegions: assigna DisplayMember/ValueMember abans de DataSource
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

        // Mètode robust per seleccionar un valor al combobox
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


        // verifiquem les dades introduïdes
        private Boolean vDades() {
            Boolean xb = true;

            if ((tbId.Text.Trim().Length == 0) || (tbCodiIne.Text.Trim().Length == 0) || (cbCodiComarcas.SelectedItem == null)) {
                MessageBox.Show("No es poden deixar dades en blanc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }

            // validar formats numérics
            float lat, lon;
            if (!float.TryParse(tbCentreLat.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out lat)) {
                MessageBox.Show("CentreLatitud té format incorrecte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!float.TryParse(tbCentreLong.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out lon)) {
                MessageBox.Show("CentreLongitud té format incorrecte", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return xb;
        }

        // inserim un municipi
        private void addTerritori() {
            _id = tbId.Text.Trim();
            CodiINE = tbCodiIne.Text.Trim();
            Nom = tbNom.Text.Trim();

            // parse floats amb invariant culture
            CentreLatitud = float.Parse(tbCentreLat.Text.Trim(), CultureInfo.InvariantCulture);
            CentreLongitud = float.Parse(tbCentreLong.Text.Trim(), CultureInfo.InvariantCulture);

            Web = tbWeb.Text.Trim();
            Escut = tbEscut.Text.Trim();
            Bandera = tbBandera.Text.Trim();
            Altitud = (int)nudAltura.Value;
            Habitants = (int)nudHabitants.Value;
            CodiComarca = cbCodiComarcas.SelectedValue?.ToString().Trim() ?? "";

            // Escapar textos
            string s_id = EscaparSQL(_id);
            string s_codiINE = EscaparSQL(CodiINE);
            string s_nom = EscaparSQL(Nom);
            string s_web = string.IsNullOrWhiteSpace(Web) ? "NULL" : "N'" + EscaparSQL(Web) + "'";
            string s_escut = string.IsNullOrWhiteSpace(Escut) ? "NULL" : "N'" + EscaparSQL(Escut) + "'";
            string s_bandera = string.IsNullOrWhiteSpace(Bandera) ? "NULL" : "N'" + EscaparSQL(Bandera) + "'";
            string s_codiComarca = string.IsNullOrWhiteSpace(CodiComarca) ? "NULL" : "N'" + EscaparSQL(CodiComarca) + "'";

            string xsql = $@"
INSERT INTO Municipis (
    _id, codiINE, nom, centreLongitud, centreLatitud, web, escut, bandera, altura, habitants, codiComarca
) VALUES (
    N'{s_id}', N'{s_codiINE}', N'{s_nom}',
    {CentreLongitud.ToString(CultureInfo.InvariantCulture)}, {CentreLatitud.ToString(CultureInfo.InvariantCulture)},
    {s_web}, {s_escut}, {s_bandera},
    {Altitud}, {Habitants}, {s_codiComarca}
);";

            if (!bd.ferOperacio(xsql)) {
                MessageBox.Show("No s'ha pogut donar d'alta el municipi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // eliminem un municipi
        private void delTerritori() {
            string id = tbId.Text.Trim();
            string s_id = EscaparSQL(id);
            String xsql = $"DELETE FROM Municipis WHERE _id = N'{s_id}';";

            if (!bd.ferOperacio(xsql)) {
                MessageBox.Show("No s'ha pogut eliminar el municipi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // modifiquem un municipi
        private void updTerritori() {
            string id = tbId.Text.Trim();
            string s_id = EscaparSQL(id);

            string descripcio = tbCodiIne.Text.Trim();
            string s_descripcio = EscaparSQL(descripcio);

            // valor de la comarca seleccionada
            string novaCodiComarca = cbCodiComarcas.SelectedValue?.ToString() ?? "";
            string s_codiComarca = string.IsNullOrWhiteSpace(novaCodiComarca) ? "NULL" : "N'" + EscaparSQL(novaCodiComarca) + "'";

            // leer floats
            float newLat = float.Parse(tbCentreLat.Text.Trim(), CultureInfo.InvariantCulture);
            float newLon = float.Parse(tbCentreLong.Text.Trim(), CultureInfo.InvariantCulture);

            int newAlt = (int)nudAltura.Value;
            int newHab = (int)nudHabitants.Value;

            string xsql = $@"
                            UPDATE Municipis
                            SET codiINE = N'{s_descripcio}',
                                nom = N'{EscaparSQL(tbNom.Text.Trim())}',
                                centreLongitud = {newLon.ToString(CultureInfo.InvariantCulture)},
                                centreLatitud  = {newLat.ToString(CultureInfo.InvariantCulture)},
                                web = {(string.IsNullOrWhiteSpace(tbWeb.Text) ? "NULL" : "N'" + EscaparSQL(tbWeb.Text) + "'")},
                                escut = {(string.IsNullOrWhiteSpace(tbEscut.Text) ? "NULL" : "N'" + EscaparSQL(tbEscut.Text) + "'")},
                                bandera = {(string.IsNullOrWhiteSpace(tbBandera.Text) ? "NULL" : "N'" + EscaparSQL(tbBandera.Text) + "'")},
                                altura = {newAlt},
                                habitants = {newHab},
                                codiComarca = {s_codiComarca}
                            WHERE _id = N'{s_id}';";

            if (!bd.ferOperacio(xsql)) {
                MessageBox.Show("No s'ha pogut modificar el municipi", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
