using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

using AcademiaLider.Core;
namespace AcademiaLider.CapaAccesoDatos
{
    class Accesslogin
    {
        private ConexionBaseDatos conn;
        public Accesslogin()
        {
            conn = new ConexionBaseDatos();
        }
        public Boolean login(String user, String password)
        {
            Boolean acceso = false;
            try
            {

                String sql = "select * from usuarios where usuario =@us and CONVERT(VARCHAR(MAX), DECRYPTBYPASSPHRASE('password',contrasena))= @con";
                SqlCommand comando = new SqlCommand(sql, conn.Conectar());
                comando.Parameters.AddWithValue("@us", user);
                comando.Parameters.AddWithValue("@con", password);
                SqlDataReader lector = comando.ExecuteReader();
                acceso = lector.HasRows;
                conn.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error desconocido");
            }
            return acceso;
        }
    }
}
