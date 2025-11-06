using DAM_CRUDTerritoris.CLASSES;
using DAM_CRUDTerritoris.FORMULARIS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAM_ARTICLES.ClComarca;

namespace DAM_CRUDTerritoris
{
    public partial class FrmMain : Form
    {
        // Propietats
        private ClFitxerConnexioBD fitxerConnexioBD { get; set; }  // obtindrem la cadena de connexió del fitxer de configuració
        private ClBd bd { get; set; }     // gestionarem la base de dades amb la classe ClBd que anirem passant als altres formularis a través del constructor

        // Formularis fills - fem una variable per a cada formulari que puguem obrir des del menú de l'FrmMain,
        // d'aquesta manera només podrem tenir una instància oberta de cada formulari
        FrmConnexioBD fConnexioBD = null;
        FrmTerritoris fTerritoris = null;
        FrmImportar fImportar = null;
        FrmMunicipis fMunicipis = null;
        FrmComarca fComarcas = null;
        FrmComPerHab fComPerHab = null;
        FrmMunPerCom fMunPerCom = null;
        public FrmMain()
        {
            InitializeComponent();
        }

        #region ------------------------- EVENTS DEL FORM I OBJECTES ---------------------------
        private void FrmMain_Load(object sender, EventArgs e)
        {
            fitxerConnexioBD = new ClFitxerConnexioBD();
            if (fitxerConnexioBD.getCadenaConnexio().Trim() != "")
            {
                activarConnexio();
            }
            else
            {
                MessageBox.Show("No hi ha cap cadena de connexió. Abans de res has d'establir la connexió amb la base de dades.", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "QÜESTIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region ------------------------- OPCIONS DEL MENÚ GENERAL ---------------------------
        private void connexioBDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "ConnexióBD";

            if (!(ja_esta_obert(xnom)))
            {
                fConnexioBD = new FrmConnexioBD(); 
                fConnexioBD.Name = xnom;
                fConnexioBD.MdiParent = this;
                // quan es tanqui el formulari, cridarem a la funció canviarBaseDades
                fConnexioBD.FormClosed += (s, ev) => canviarBaseDades();
                fConnexioBD.Show();
            }
            fConnexioBD.Activate();
        }

        private void canviarBaseDades()
        {
            foreach (Form f in this.MdiChildren)  // tanquem tots els formularis oberts que no siguin el de connexió
            {
                if (f.Name != "ConnexióBD")
                {
                    f.Close();
                }
            }
            activarConnexio();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region ------------------------- OPCIONS DEL MENÚ FINESTRES ---------------------------
        private void horitzontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }


        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void organitzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        #endregion

        #region ------------------------- OPCIONS DEL MENÚ DADES BÀSIQUES ---------------------------
        private void territorisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String xnom = "Territoris";

            if (!(ja_esta_obert(xnom)))
            {
                fTerritoris=new FrmTerritoris(bd);  // li passem la classe ClBd que gestiona la base de dades
                fTerritoris.Name = xnom;            // posem el nom al formulari per a poder comprovar si ja està obert
                fTerritoris.MdiParent = this;       // establim que el formulari fill (MdiChild) depèn del FrmMain (MdiParent)
                
                // quan es tanqui el formulari, posem la variable a null per a que es pugui tornar a obrir
                fTerritoris.FormClosed += (s, ev) => fTerritoris = null;
                fTerritoris.Show();
            }
            fTerritoris.Activate();

        }
        #endregion

        #region ------------------------- ALTRES MÈTODES (FUNCIONS I PROCEDIMENTS) ---------------------------

        // comprova si el formulari ja està obert
        // aquí ho fem manualment a partir de la llista de fills del contenidor MDI
        // també ho podríem fer a partir de la llista llFormularis com ho hem fet a mostrarFormulari()
        private Boolean ja_esta_obert(String xnom)
        {

            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom);
                x1++;
            }
            return (xb);
        }

        private void activarMenus(Boolean xactivar)
        {
            gestioToolStripMenuItem.Enabled = xactivar;
        }

        private Boolean activarConnexio()
        {
            Boolean xb = false;

            if (bd !=null && bd.hihaConnexio())
            {
                bd.tancarConnexio();
            }

            fitxerConnexioBD = new ClFitxerConnexioBD();
            bd = new ClBd(fitxerConnexioBD.getCadenaConnexio());
            if (!(bd.testConnexio()))
            {
                activarMenus(false);
                MessageBox.Show("No s'ha pogut connectar amb la base de dades. Revisa la cadena de connexió.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                xb = true;
                activarMenus(true);
            }
            return (xb);
        }

        #endregion

        private void importarDadesToolStripMenuItem_Click(object sender, EventArgs e) {
            String xnom = "importar";

            if (!(ja_esta_obert(xnom))) {
                fImportar = new FrmImportar(bd);
                fImportar.Name = xnom;
                fImportar.MdiParent = this;
                fImportar.Show();
            }
            fImportar.Activate();
        }

        private void municipisToolStripMenuItem_Click(object sender, EventArgs e) {
            String xnom = "municipis";

            if (!(ja_esta_obert(xnom))) {
                fMunicipis = new FrmMunicipis(bd);
                fMunicipis.Name = xnom;
                fMunicipis.MdiParent = this;
                fMunicipis.Show();
            }
            fMunicipis.Activate();
        }

        private void comarcasToolStripMenuItem_Click(object sender, EventArgs e) {
            String xnom = "comarcas";

            if (!(ja_esta_obert(xnom))) {
                fComarcas = new FrmComarca(bd);
                fComarcas.Name = xnom;
                fComarcas.MdiParent = this;
                fComarcas.Show();
            }
            fComarcas.Activate();
        }

        private void comarquesPerHabitantsToolStripMenuItem_Click(object sender, EventArgs e) {
            String xnom = "habitants";

            if (!(ja_esta_obert(xnom))) {
                fComPerHab = new FrmComPerHab(bd);
                fComPerHab.Name = xnom;
                fComPerHab.MdiParent = this;
                fComPerHab.Show();
            }
            fComPerHab.Activate();
        }

        private void municipisPerComarcaToolStripMenuItem_Click(object sender, EventArgs e) {
            String xnom = "munpercom";

            if (!(ja_esta_obert(xnom))) {
                fMunPerCom = new FrmMunPerCom(bd);
                fMunPerCom.Name = xnom;
                fMunPerCom.MdiParent = this;
                fMunPerCom.Show();
            }
            fMunPerCom.Activate();
        }
    }
}
