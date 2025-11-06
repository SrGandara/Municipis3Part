using DAM_CRUDTerritoris.CLASSES;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace DAM_CRUDTerritoris.FORMULARIS {
    public partial class FrmABMComarcas : Form {
        // Propietats corresponents als camps de la taula de la base de dades.
        public string CodiComarca { get; set; } = "";
        public string NomComarca { get; set; } = "";
        public int Habitants { get; set; } = 0;
        public float Extensio { get; set; } = 0;

        // Altres propietats
        Char op { get; set; } = '\0';   // A, B, M
        ClBd bd { get; set; }
        DataTable dtCodiComarcas { get; set; } = new DataTable();


        public FrmABMComarcas(Char xop, ClBd xbd) {
            InitializeComponent();
            op = xop;
            bd = xbd;
        }

        // Asegúrate en el diseñador de enlazar este handler al Load del form:
        private void FrmABMComarcas_Load(object sender, EventArgs e) {

            switch (op) {
                case 'A': this.Text = "Alta d'un nou municipi"; break;
                case 'B': this.Text = "Eliminar el municipi"; break;
                case 'M': this.Text = "Modificar el municipi"; break;
            }

            tbCodiComarca.Text = CodiComarca; // assumeixes que tens textbox per al codi
            tbNom.Text = NomComarca;
            nudExtensio.Value = (decimal)Extensio;
            nudHabitants.Value = Habitants;

            // activar/desactivar controls segons operació
            tbCodiComarca.Enabled = (op == 'A');
            tbNom.Enabled = (op != 'B');
            nudExtensio.Enabled = (op != 'B');
            nudHabitants.Enabled = (op != 'B');
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

        // verifiquem les dades introduïdes
        private Boolean vDades() {
            Boolean xb = true;

            if ((tbNom.Text.Trim().Length == 0) || (tbCodiComarca.Text.Trim().Length == 0)) {
                MessageBox.Show("No es poden deixar dades en blanc", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }

            return xb;
        }

        // 4) addTerritori (INSERT) - corregit
        private void addTerritori() {
            // agafem valors del formulari
            string codigo = tbCodiComarca.Text.Trim();
            string nom = tbNom.Text.Trim();
            int habitants = (int)nudHabitants.Value;
            float extensio = (float)nudExtensio.Value;

            if (string.IsNullOrEmpty(codigo)) {
                MessageBox.Show("El codi de la comarca no pot ser buit.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string s_codigo = EscaparSQL(codigo);
            string s_nom = EscaparSQL(nom);

            // INSERT: no posem cometes en numèrics i usem invariant culture per float
            string xsql = $@"
INSERT INTO Comarques (codiComarca, nomComarca, habitants, extensio)
VALUES (N'{s_codigo}', N'{s_nom}', {habitants}, {extensio.ToString(CultureInfo.InvariantCulture)});
";

            if (!bd.ferOperacio(xsql)) {
                MessageBox.Show("No s'ha pogut donar d'alta la comarca", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 5) delTerritori (DELETE) - corregit
        private void delTerritori() {
            string codigo = tbCodiComarca.Text.Trim();
            if (string.IsNullOrEmpty(codigo)) {
                MessageBox.Show("Selecciona una comarca per eliminar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string s_codigo = EscaparSQL(codigo);
            string xsql = $"DELETE FROM Comarques WHERE codiComarca = N'{s_codigo}';";

            if (!bd.ferOperacio(xsql)) {
                MessageBox.Show("No s'ha pogut eliminar la comarca", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 6) updTerritori (UPDATE) - corregit
        private void updTerritori() {
            string codigoOriginal = CodiComarca; // si tens la clau antiga emmagatzemada a la propietat
            if (string.IsNullOrEmpty(codigoOriginal)) {
                MessageBox.Show("Codi original no disponible per a la modificació.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newNom = tbNom.Text.Trim();
            int newHab = (int)nudHabitants.Value;
            float newExt = (float)nudExtensio.Value;

            string s_newNom = EscaparSQL(newNom);
            string s_codigoOriginal = EscaparSQL(codigoOriginal);

            string xsql = $@"
UPDATE Comarques
SET nomComarca = N'{s_newNom}',
    habitants = {newHab},
    extensio = {newExt.ToString(CultureInfo.InvariantCulture)}
WHERE codiComarca = N'{s_codigoOriginal}';
";

            if (!bd.ferOperacio(xsql)) {
                MessageBox.Show("No s'ha pogut modificar la comarca", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
