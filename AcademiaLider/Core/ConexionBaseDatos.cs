using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace AcademiaLider.Core
{
    class ConexionBaseDatos
    {
        private String cadenaConexion;
        private SqlConnection conexion;

        public ConexionBaseDatos()
        {
            cadenaConexion = "";
            conexion = null;
        }

        private String ObtenerCadenaConexion()
        {
            try
            {
                cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo encontrar la cadena de conexión, revise el archivo de configuración.\nERROR: " + ex.Message);
            }
            return cadenaConexion;
        }

        public SqlConnection Conectar()
        {
            try
            {
                if (conexion == null)
                {
                    conexion = new SqlConnection(cadenaConexion);
                    conexion.Open();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error en la conexion: " + ex.Message);
            }
            return conexion;
        }

        public void Cerrar()
        {
            if (conexion != null)
            {
                conexion.Close();
            }
        }
    }
}
