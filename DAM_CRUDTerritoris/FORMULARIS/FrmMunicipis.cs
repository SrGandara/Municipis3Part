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

        FrmABMTerritoris fABMTerritoris = null;

        public FrmMunicipis(ClBd xbd)
        {
            InitializeComponent();
            bd = xbd;
        }


    }
}
