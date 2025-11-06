using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DAM_CRUDTerritoris.CLASSES
{
    public class ClBd
    {
        // PROPIETATS

        String cadenaConnexio { get; set; } = "AQAAANCMnd8BFdERjHoAwE/Cl+sBAAAA984EoItJWkuAg+79dG27zwQAAAACAAAAAAAQZgAAAAEAACAAAABUgObP+PjhsBKqUNFlLc8Q1578ehSBdlgeZNNqe9aetQAAAAAOgAAAAAIAACAAAADOEDUJ3Gw5creeicjDYN5kd5L+phZDiNSd0U3mHyUY2FAAAAAk0SVQTlNn6Ba9/nTUyOr6zntEHz9HPFEFeTdIy2ihqyI2mLnse3btnScdubEgZ0N4oiaQXXjzxITBEcfx6AsvxKafSzN3LfN4CFu5XH9kqUAAAAAeA3AsUG8dqrF+19x6iREM5pLqGQ5zUQuSYlLuVcur4KlBfFAfJByesOmDr7Y89t8h74WkydaCEJ3GYHnlQR7z";
        SqlConnection dbConnexio { get; set; }        // Permet establir la connexió amb SQL Server
        SqlDataAdapter dbAdaptador { get; set; }      // El DataAdapter és l'intermediari que executarà les instruccions SQL a la base de dades  

        public ClBd(String xcadenaConnexio)
        {           
            if (validarCadenaConnexioEncriptada(ClKryptonita486.desencriptarText(xcadenaConnexio)))
            {
                cadenaConnexio = ClKryptonita486.desencriptarText(xcadenaConnexio);
            }
            else
            {
                MessageBox.Show("La cadena de connexió no és vàlida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region --- MÈTODES PÚBLICS DE LA CLASSE ---
        public Boolean testConnexio()
        {
            // comprovem si tenim connexió amb la BD
            Boolean xb = false;

            if (cadenaConnexio.Trim() == "")
            {
                MessageBox.Show("No s'ha introduït cadena de connexió", "ERROR - testConnexio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if ((dbConnexio == null) || (dbConnexio.State != ConnectionState.Open))
                {
                    try
                    {
                        dbConnexio = new SqlConnection(cadenaConnexio);
                        xb=obrirConnexio();
                    }
                    catch (Exception excp)
                    {
                        MessageBox.Show(excp.Message, "Excepció - testConnexio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    xb = true;
                }
            }
            return xb;
        }

        public Boolean obrirConnexio()
        {
            // estableix la connexió amb la BD
            Boolean xb =false;

            try
            {
                if (dbConnexio != null)
                {
                    dbConnexio.Open();
                    xb = (dbConnexio.State == ConnectionState.Open);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - obrirConnexio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return xb;
        }

        public Boolean hihaConnexio()
        {
            // indica si hi ha connexió oberta amb la BD
            return (dbConnexio != null && dbConnexio.State == ConnectionState.Open);
        }

        public SqlConnection getConnexio()
        {
            // retorna l'objecte de connexió
            return dbConnexio;
        }

        public Boolean getDades(String xsql, DataTable xdTable)
        {
            // omple el DataTable passat com a paràmetre amb les dades obtingudes de la consulta SQL passada com a paràmetre
            Boolean xb = false;

            try
            {
                dbAdaptador = new SqlDataAdapter(xsql, dbConnexio);
                xdTable.Clear();
                dbAdaptador.Fill(xdTable);
                xb = true;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - getDades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return xb;
        }

        public Boolean ferOperacio(String xsql)
        {
            // executa una instrucció SQL passada com a paràmetre (INSERT, UPDATE, DELETE)
            Boolean xb = false;
            SqlCommand xcommand = new SqlCommand(xsql, dbConnexio);

            try
            {
                xcommand.ExecuteNonQuery();
                xb = true;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - ferOperacio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return xb;
        }

        public void tancarConnexio()
        {
            // tanca la connexió amb la BD
            dbConnexio.Close();
        }
        #endregion

        #region ---- ALTRES FUNCIONS O MÈTODES ---
        private Boolean validarCadenaConnexioEncriptada(String xcadena)
        {
            // comprovem que la cadena tingui el Data Source, l'Initial Catalog i l'Integrated Security
            // estem fent una comprovació molt bàsica, es podria millorar

            String[] vCadena = xcadena.Split(';');
            return (vCadena[0].StartsWith("Data Source=") && vCadena[1].StartsWith("Initial Catalog=") && vCadena[2].StartsWith("Integrated Security="));
        }
        #endregion
    }
}
