using DAM_ARTICLES;
using DAM_CRUDTerritoris.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM_CRUDTerritoris.FORMULARIS {
    public partial class FrmImportar : Form {
        List<ClComarca.Comarca> llComarcas = new List<ClComarca.Comarca>();
        List<ClMunicipi.Municipi> llMunicipis = new List<ClMunicipi.Municipi>();
        ClBd bd { get; set; }

        bool finishImportC = false;
        bool finishImportM = false;

        private bool showImportButton() 
        { 
            return finishImportC && finishImportM; 
        }

        public FrmImportar(ClBd xbd) {
            InitializeComponent();
            bd = xbd;
        }

        private void btImportarC_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "DAT files (*.dat)|*.dat|All files (*.*)|*.*",
                Title = "Selecciona un fitxer DAT",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Contains("comarcas.dat")) {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("Has seleccionat el fitxer: " + filePath, "Fitxer Seleccionat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pbMissingC.Hide();
                pbOkayC.Show();

                llComarcas.Clear();
                try {
                    FileInfo fi = new FileInfo(filePath);
                    if (fi.Length == 0) {
                        MessageBox.Show("El fitxer comarcas.dat està buit.", "Fitxer buit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open))) {
                        while (reader.BaseStream.Position != reader.BaseStream.Length) {
                            // Llegir pot llençar excepció si el format està malament
                            ClComarca.Comarca comarca = new ClComarca.Comarca().Llegir(reader);
                            llComarcas.Add(comarca);
                        }
                    }

                    if (llComarcas.Count == 0) {
                        MessageBox.Show("No s'ha llegit cap registre del fitxer comarcas.dat.", "Registres 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else {
                        MessageBox.Show($"S'han llegit {llComarcas.Count} comarques.", "Lectura OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        finishImportC = true;

                        if (showImportButton()) {
                            btImportar.Show();
                        }
                    }
                }
                catch (EndOfStreamException ex) {
                    MessageBox.Show("Format del fitxer comarcas.dat invàlid (EOF inesperat): " + ex.Message, "Error lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) {
                    MessageBox.Show("Error llegint comarcas.dat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btImportarM_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog {
                Filter = "DAT files (*.dat)|*.dat|All files (*.*)|*.*",
                Title = "Selecciona un fitxer DAT",
                CheckFileExists = true,
                CheckPathExists = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Contains("municipis.dat")) {
                string filePath = openFileDialog.FileName;
                MessageBox.Show("Has seleccionat el fitxer: " + filePath, "Fitxer Seleccionat", MessageBoxButtons.OK, MessageBoxIcon.Information);

                pbMissingM.Hide();
                pbOkay2.Show();

                llMunicipis.Clear();
                try {
                    FileInfo fi = new FileInfo(filePath);
                    if (fi.Length == 0) {
                        MessageBox.Show("El fitxer municipis.dat està buit.", "Fitxer buit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open))) {
                        while (reader.BaseStream.Position != reader.BaseStream.Length) {
                            ClMunicipi.Municipi municipi = new ClMunicipi.Municipi().Llegir(reader);
                            llMunicipis.Add(municipi);
                        }
                    }

                    if (llMunicipis.Count == 0) {
                        MessageBox.Show("No s'ha llegit cap registre del fitxer municipis.dat.", "Registres 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else {
                        MessageBox.Show($"S'han llegit {llMunicipis.Count} municipis.", "Lectura OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        finishImportM = true;

                        if (showImportButton()) {
                            btImportar.Show();
                        }
                    }
                }
                catch (EndOfStreamException ex) {
                    MessageBox.Show("Format del fitxer municipis.dat invàlid (EOF inesperat): " + ex.Message, "Error lectura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex) {
                    MessageBox.Show("Error llegint municipis.dat: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string EscaparSQL(string valor) {
            if (string.IsNullOrEmpty(valor))
                return "";
            return valor.Replace("'", "''"); // duplica comillas simples
        }

        /// <summary>
        /// Valida que les comarques llegides tinguin el mínim format requerit.
        /// </summary>
        private (bool ok, string mensaje) ValidarComarcas(List<ClComarca.Comarca> comarcas) {
            if (comarcas == null || comarcas.Count == 0)
                return (false, "No hi ha cap comarca per importar.");

            int idx = 0;
            foreach (var c in comarcas) {
                idx++;
                if (string.IsNullOrWhiteSpace(c.CodiComarca))
                    return (false, $"Comarca #{idx} té CodiComarca buit o null.");
                if (string.IsNullOrWhiteSpace(c.NomComarca))
                    return (false, $"Comarca #{idx} té NomComarca buit o null.");
                if (c.Habitants < 0)
                    return (false, $"Comarca #{idx} té Habitants negatiu.");
                if (c.Extensio < 0.0f)
                    return (false, $"Comarca #{idx} té Extensio negativa.");
            }
            return (true, "OK");
        }

        /// <summary>
        /// Valida que els municipis llegits tinguin el mínim format.
        /// </summary>
        private (bool ok, string mensaje) ValidarMunicipis(List<ClMunicipi.Municipi> municipis) {
            if (municipis == null || municipis.Count == 0)
                return (false, "No hi ha cap municipi per importar.");

            int idx = 0;
            foreach (var m in municipis) {
                idx++;
                if (string.IsNullOrWhiteSpace(m._id))
                    return (false, $"Municipi #{idx} té _id buit o null.");
                if (string.IsNullOrWhiteSpace(m.Nom))
                    return (false, $"Municipi #{idx} té Nom buit o null.");
                // lat/lon: comprovar valors plausibles
                if (m.CentreLatitud < -90f || m.CentreLatitud > 90f)
                    return (false, $"Municipi #{idx} té CentreLatitud fora de rang (-90..90).");
                if (m.CentreLongitud < -180f || m.CentreLongitud > 180f)
                    return (false, $"Municipi #{idx} té CentreLongitud fora de rang (-180..180).");
                if (m.Habitants < 0)
                    return (false, $"Municipi #{idx} té Habitants negatiu.");
                // Altitud: definir límits raonables (p.ex. -500..9000)
                if (m.Altitud < -500 || m.Altitud > 9000)
                    return (false, $"Municipi #{idx} té Altitud fora de rang raonable (-500..9000).");
            }
            return (true, "OK");
        }

        private void btImportar_Click(object sender, EventArgs e) {
            try {
                // 1) Validacions prèvies
                var validC = ValidarComarcas(llComarcas);
                if (!validC.ok) {
                    MessageBox.Show("Validació Comarques fallida: " + validC.mensaje, "Validació", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var validM = ValidarMunicipis(llMunicipis);
                if (!validM.ok) {
                    MessageBox.Show("Validació Municipis fallida: " + validM.mensaje, "Validació", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2) Confirmació a l'usuari (opcional)
                var dr = MessageBox.Show("S'esborrarà el contingut actual de les taules i s'importarà el nou fitxer. Continuar?", "Confirmació", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr != DialogResult.Yes) return;

                // 3) Eliminar contingut previ (només si validacions passades)
                string xsql = @"
DELETE FROM Municipis;
DELETE FROM Comarques;";
                if (!bd.ferOperacio(xsql)) {
                    MessageBox.Show("No s'ha pogut esborrar les taules prèvies.", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar progress visuals
                pbImportingC.Show();

                // 4) Inserció Comarques
                foreach (var c in llComarcas) {
                    string codi = EscaparSQL(c.CodiComarca);
                    string nom = EscaparSQL(c.NomComarca);

                    xsql = $@"
INSERT INTO Comarques (codiComarca, nomComarca, habitants, extensio)
VALUES (N'{codi}', N'{nom}', {c.Habitants}, {c.Extensio.ToString(System.Globalization.CultureInfo.InvariantCulture)});";

                    if (!bd.ferOperacio(xsql)) {
                        MessageBox.Show($"Error inserint comarca {codi}. Operació aturada.", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbImportingC.Hide();
                        return;
                    }
                }

                pbImportingC.Hide();
                pbImporticM.Show();

                // 5) Inserció Municipis
                foreach (var m in llMunicipis) {
                    string id = EscaparSQL(m._id);
                    string codiINE = EscaparSQL(m.CodiINE);
                    string nom = EscaparSQL(m.Nom);
                    string web = EscaparSQL(m.Web);
                    string escut = EscaparSQL(m.Escut);
                    string bandera = EscaparSQL(m.Bandera);
                    string codiComarca = EscaparSQL(m.CodiComarca);

                    int altura = Math.Max(short.MinValue, Math.Min(short.MaxValue, m.Altitud));

                    xsql = $@"
INSERT INTO Municipis (
    _id, codiINE, nom, centreLongitud, centreLatitud, 
    web, escut, bandera, altura, habitants, codiComarca
)
VALUES (
    N'{id}', N'{codiINE}', N'{nom}',
    {m.CentreLongitud.ToString(System.Globalization.CultureInfo.InvariantCulture)},
    {m.CentreLatitud.ToString(System.Globalization.CultureInfo.InvariantCulture)},
    {(string.IsNullOrWhiteSpace(web) ? "NULL" : $"N'{web}'")},
    {(string.IsNullOrWhiteSpace(escut) ? "NULL" : $"N'{escut}'")},
    {(string.IsNullOrWhiteSpace(bandera) ? "NULL" : $"N'{bandera}'")},
    {altura}, {m.Habitants},
    {(string.IsNullOrWhiteSpace(codiComarca) ? "NULL" : $"N'{codiComarca}'")}
);";

                    if (!bd.ferOperacio(xsql)) {
                        MessageBox.Show($"Error inserint municipi {id}. Operació aturada.", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        pbImporticM.Hide();
                        return;
                    }
                }

                pbImporticM.Hide();
                MessageBox.Show("Importació completada correctament!", "Èxit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) {
                MessageBox.Show("Error en la importació: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmImportar_Load(object sender, EventArgs e) {

        }
    }
}
