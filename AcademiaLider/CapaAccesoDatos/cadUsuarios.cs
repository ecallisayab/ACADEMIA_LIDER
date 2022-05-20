using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AcademiaLider.Core;
using System.Data;
using AcademiaLider.Entidades;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AcademiaLider.CapaAccesoDatos
{
    class cadUsuarios
    {
        private ConexionBaseDatos conn;
        public cadUsuarios()
        {
            conn = new ConexionBaseDatos();
        }
        public Boolean insert(Usuarios user)
        {
            Boolean val = false;
            int fila = -1;
            try
            {
                String sql = "INSERT INTO usuarios (nombre_completo,usuario,contrasena,correo) values (@1,@2,ENCRYPTBYPASSPHRASE('password',@3),@4)";

                SqlCommand comando = new SqlCommand(sql, conn.Conectar());
                comando.Parameters.AddWithValue("@1", user.Nombres);
                comando.Parameters.AddWithValue("@2", user.Usuario);
                comando.Parameters.AddWithValue("@3", user.Password);
                comando.Parameters.AddWithValue("@4", user.Correo);

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
        public Boolean update(Usuarios user)
        {
            Boolean val = false;
            int fila = -1;
            try
            {
                String sql = "update usuarios set nombre_completo=@1, usuario=@2,correo=@3  where codigo=@4";

                SqlCommand comando = new SqlCommand(sql, conn.Conectar());
                comando.Parameters.AddWithValue("@1", user.Nombres);
                comando.Parameters.AddWithValue("@2", user.Usuario);
                comando.Parameters.AddWithValue("@3", user.Correo);
                comando.Parameters.AddWithValue("@4", user.Codigo);
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

        public Boolean delete(Usuarios user)
        {
            Boolean val = false;
            int fila = -1;
            try
            {
                String sql = "delete from usuarios  where codigo=@4";

                SqlCommand comando = new SqlCommand(sql, conn.Conectar());
                comando.Parameters.AddWithValue("@4", user.Codigo);
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
                String sql = "select codigo,nombre_completo as nombres,usuario,correo  from usuarios";
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
                String sql = " select  codigo ,nombre_completo as nombre,usuario,correo  from usuarios where nombre_completo LIKE CONCAT('%',@1,'%')" +
             " or usuario LIKE CONCAT('%',@1,'%')" +
             " or correo LIKE CONCAT('%',@1,'%')" +
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
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return list;
        }
    }
}
