using DAM_CRUDTerritoris.CLASSES;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAM_CRUDTerritoris.FORMULARIS
{
    public partial class FrmABMTerritoris : Form
    {
        // Propietats corresponents als camps de la taula de la base de dades. IMPORTANT!!!! LES FEM PÚBLIQUES
        public String id { get; set; } = "";
        public String descripcio { get; set; } = "";
        public int idRegio { get; set; }

        // Altres propietats
        Char op { get; set; } = '\0';   // operació a realitzar: A (alta), B (baixa), M (modificació)
        ClBd bd { get; set; }           // rebrem la classe ClBd que gestiona la base de dades des del FrmMain
        DataTable dtRegions { get; set; } = new DataTable(); // En aquest DataTable deixarem les dades de les regions per a omplir el combobox

        public FrmABMTerritoris(Char xop, ClBd xbd)
        {
            InitializeComponent();
            op = xop;
            bd = xbd;
        }

        #region ------------------------- EVENTS DEL FORM I OBJECTES ---------------------------
        private void FrmABMTerritoris_Load(object sender, EventArgs e)
        {
            omplirComboRegions();
            switch (op)
            {
                case 'A': this.Text = "Alta d'un nou territori"; break;
                case 'B': this.Text = "Eliminar el territori"; break;
                case 'M': this.Text = "Modificar el territori"; break;
            }

            // omplim les dades en el form
            tbId.Text= id;
            tbDescripcio.Text= descripcio;
            cbRegions.SelectedValue=idRegio;

            // activem o desactivem els objectes depenent de l'operació a realitzar
            tbId.Enabled = (op == 'A');
            tbDescripcio.Enabled = (op != 'B');
            cbRegions.Enabled = (op != 'B');
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            id = "";
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (vDades())
            {
                switch (op)
                {
                    case 'A': addTerritori(); break;
                    case 'B': delTerritori(); break;
                    case 'M': updTerritori(); break;
                }
                this.Close();
            }
        }
        #endregion

        #region ------------------------- ALTRES MÈTODES (FUNCIONS I PROCEDIMENTS) ---------------------------
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

        // verifiquem les dades introduïdes
        private Boolean vDades()
        {
            Boolean xb=true;

            if ((tbId.Text.Trim().Length == 0) || (tbDescripcio.Text.Trim().Length == 0) || (cbRegions.SelectedItem==null)) { 
                MessageBox.Show("No es poden deixar dades en blanc","ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                xb = false;
            }
            return xb;
        }

        // inserim un territori
        private void addTerritori()
        {
            id= tbId.Text.Trim();
            descripcio= tbDescripcio.Text.Trim();
            idRegio= (int) cbRegions.SelectedValue;

            String xsql=$"INSERT INTO Territories (TerritoryID, TerritoryDescription, RegionID) VALUES('{id}','{descripcio}',{idRegio})";

            if (!bd.ferOperacio(xsql))
            {
                MessageBox.Show("No s'ha pogut donar d'alta el territori", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // eliminem un territori
        private void delTerritori()
        {
            id = tbId.Text.Trim();
            String xsql = $"DELETE FROM Territories WHERE TerritoryID='{id}'";

            if (!bd.ferOperacio(xsql))
            {
                MessageBox.Show("No s'ha pogut eliminar el territori", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // modifiquem un territori
        private void updTerritori()
        {
            id = tbId.Text.Trim();
            descripcio = tbDescripcio.Text.Trim();
            idRegio = (int)cbRegions.SelectedValue;

            String xsql = $"UPDATE Territories SET TerritoryDescription='{descripcio}', RegionID={idRegio} WHERE TerritoryID='{id}'";

            if (!bd.ferOperacio(xsql))
            {
                MessageBox.Show("No s'ha pogut modificar el territori", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
