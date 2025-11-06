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
    public partial class FrmConnexioBD : Form
    {
        // Propietats
        private ClFitxerConnexioBD fitxerConnexioBD { get; set; }

        public FrmConnexioBD()
        {
            InitializeComponent();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (fitxerConnexioBD.guardarCadenaConnexio(tbCadenaConnexio.Text))
            {
                this.Close();
            }
        }

        private void FrmConnexioBD_Load(object sender, EventArgs e)
        {
            fitxerConnexioBD=new ClFitxerConnexioBD();
            tbCadenaConnexio.Text= fitxerConnexioBD.getCadenaConnexio();
        }
    }
}
