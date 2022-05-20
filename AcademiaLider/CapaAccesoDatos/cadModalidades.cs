using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using AcademiaLider.Core;
using AcademiaLider.Entidades;
using System.Data;

namespace AcademiaLider.CapaAccesoDatos
{
    class cadModalidades
    {

        private ConexionBaseDatos conn;
        public cadModalidades()
        {
            conn = new ConexionBaseDatos();
        }
        public Boolean insert(Modalidades bite)
        {
            Boolean val = false;
            int fila = -1;
            try
            {
                String sql = "INSERT INTO catalogo_modalidades (nombre) values (@1)";

                SqlCommand comando = new SqlCommand(sql, conn.Conectar());
                comando.Parameters.AddWithValue("@1", bite.Nombres);
                fila = comando.ExecuteNonQuery();
                conn.Cerrar();
                if (fila > 0)
                {
                    val = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos:" + ex.Message);

            }
            return val;
        }
        public Boolean update(Modalidades bite)
        {
            Boolean val = false;
            int fila = -1;
            try
            {
                String sql = "update catalogo_modalidades set nombre=@1  where codigo=@4";
                SqlCommand comando = new SqlCommand(sql, conn.Conectar());
                comando.Parameters.AddWithValue("@1", bite.Nombres);
                comando.Parameters.AddWithValue("@4", bite.Codigo);
                fila = comando.ExecuteNonQuery();
                conn.Cerrar();
                if (fila > 0)
                {
                    val = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar datos" + ex.Message);

            }
            return val;
        }

        public Boolean delete(Modalidades bite)
        {
            Boolean val = false;
            int fila = -1;
            try
            {
                String sql = "delete from catalogo_modalidades  where codigo=@4";

                SqlCommand comando = new SqlCommand(sql, conn.Conectar());
                comando.Parameters.AddWithValue("@4", bite.Codigo);
                fila = comando.ExecuteNonQuery();
                conn.Cerrar();
                if (fila > 0)
                {
                    val = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar datos:" + ex.Message);

            }
            return val;
        }

        public DataTable getAll()
        {
            DataTable list = new DataTable();

            try
            {
                String sql = "select codigo, nombre  from catalogo_modalidades";
                SqlCommand comando = new SqlCommand(sql, conn.Conectar());
                SqlDataReader res = comando.ExecuteReader();
                list.Load(res);
                res.Close();
                conn.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return list;
        }
        public DataTable busqueda(String val)
        {

            DataTable list = new DataTable();
            try
            {
                String sql = "select  codigo ,nombre  from catalogo_modalidades where nombre LIKE CONCAT('%',@1,'%')" +
                    " or codigo LIKE CONCAT('%',@1,'%')";
                SqlCommand comando = new SqlCommand(sql, conn.Conectar());
                comando.Parameters.Add("@1", SqlDbType.VarChar);
                comando.Parameters["@1"].Value = val;
                SqlDataReader datos = comando.ExecuteReader();
                list.Load(datos);
                datos.Close();
                conn.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la busqueda: " + ex.Message);
            }
            return list;
        }
    }
}
