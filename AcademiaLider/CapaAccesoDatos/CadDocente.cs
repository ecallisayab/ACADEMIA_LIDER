using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

using AcademiaLider.Core;
using AcademiaLider.Entidades;

namespace AcademiaLider.CapaAccesoDatos
{
    class CadDocente
    {
        public CadDocente()
        {

        }

        public bool Crear(Docente objDocente)
        {
            bool respuesta = false;
            String sql = "INSERT INTO docentes (codigo, nombres, ap_paterno, ap_materno, ci, cod_grado, cod_ciudad, correo, telefono, cuenta_bancaria, cod_profesion) " +
                "VALUES (CONCAT('LD-', RIGHT('00000' + Ltrim(Rtrim(NEXT VALUE FOR seq_docente)),5)), @nombres, @ap_paterno, @ap_materno, @ci, @cod_grado, @cod_ciudad, @correo, @telefono, @cuenta_bancaria, @cod_profesion)";
            int filas;
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@nombres", objDocente.Nombres);
                comando.Parameters.AddWithValue("@ap_paterno", objDocente.ApPaterno);
                comando.Parameters.AddWithValue("@ap_materno", objDocente.ApMaterno);
                comando.Parameters.AddWithValue("@ci", objDocente.Ci);
                comando.Parameters.AddWithValue("@cod_grado", objDocente.CodGrado);
                comando.Parameters.AddWithValue("@cod_ciudad", objDocente.CodCiudad);
                comando.Parameters.AddWithValue("@correo", objDocente.Correo);
                comando.Parameters.AddWithValue("@telefono", objDocente.Telefono);
                comando.Parameters.AddWithValue("@cuenta_bancaria", objDocente.CuentaBancaria);
                comando.Parameters.AddWithValue("@cod_profesion", objDocente.CodProfesion);
                filas = comando.ExecuteNonQuery();
                bd.Cerrar();
                if (filas > 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return respuesta;
        }

        public bool Modificar(Docente objDocente)
        {
            bool respuesta = false;
            String sql = "UPDATE docentes SET nombres=@nombres, ap_paterno=@ap_paterno, ap_materno=@ap_materno, ci=@ci, cod_grado=@cod_grado, cod_ciudad=@cod_ciudad, correo=@correo, telefono=@telefono, cuenta_bancaria=@cuenta_bancaria, cod_profesion=@cod_profesion WHERE codigo=@codigo";
            int filas;
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@nombres", objDocente.Nombres);
                comando.Parameters.AddWithValue("@ap_paterno", objDocente.ApPaterno);
                comando.Parameters.AddWithValue("@ap_materno", objDocente.ApMaterno);
                comando.Parameters.AddWithValue("@ci", objDocente.Ci);
                comando.Parameters.AddWithValue("@cod_grado", objDocente.CodGrado);
                comando.Parameters.AddWithValue("@cod_ciudad", objDocente.CodCiudad);
                comando.Parameters.AddWithValue("@correo", objDocente.Correo);
                comando.Parameters.AddWithValue("@telefono", objDocente.Telefono);
                comando.Parameters.AddWithValue("@cuenta_bancaria", objDocente.CuentaBancaria);
                comando.Parameters.AddWithValue("@cod_profesion", objDocente.CodProfesion);
                comando.Parameters.AddWithValue("@codigo", objDocente.Codigo);
                filas = comando.ExecuteNonQuery();
                bd.Cerrar();
                if (filas > 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return respuesta;
        }

        public bool Eliminar(String codigo)
        {
            bool respuesta = false;
            String sql = "DELETE FROM docentes WHERE codigo=@codigo";
            int filas;
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@codigo", codigo);
                filas = comando.ExecuteNonQuery();
                bd.Cerrar();
                if (filas > 0)
                {
                    respuesta = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return respuesta;
        }

        public Docente Obtener(String codigo)
        {
            Docente objDocente = new Docente();
            try
            {
                String sql = "SELECT * FROM docentes WHERE codigo=@codigo";
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@codigo", codigo);
                SqlDataReader datos = comando.ExecuteReader();
                if (datos.Read())
                {
                    objDocente.Codigo = datos["codigo"].ToString();
                    objDocente.Nombres = datos["nombres"].ToString();
                    objDocente.ApPaterno = datos["ap_paterno"].ToString();
                    objDocente.ApMaterno = datos["ap_materno"].ToString();
                    objDocente.Ci = datos["ci"].ToString();
                    objDocente.CodGrado = Convert.ToInt32(datos["cod_grado"].ToString());
                    objDocente.CodCiudad = Convert.ToInt32(datos["cod_ciudad"].ToString());
                    objDocente.Correo = datos["correo"].ToString();
                    objDocente.Telefono = Convert.ToInt32(datos["telefono"].ToString());
                    objDocente.CuentaBancaria = datos["cuenta_bancaria"].ToString();
                    objDocente.CodProfesion = Convert.ToInt32(datos["cod_profesion"].ToString());
                }
                bd.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return objDocente;
        }
        public DataTable Listar()
        {
            String sql = "SELECT t1.codigo, t1.nombres, t1.ap_paterno, t1.ap_materno, t1.ci, t2.nombre as grado_academico, t3.nombre as ciudad, t1.correo, t1.telefono, t1.cuenta_bancaria, t4.nombre AS profesion " +
                "FROM docentes t1 " +
                "INNER JOIN catalogo_grados_academicos t2 ON t1.cod_grado=t2.codigo " +
                "INNER JOIN catalogo_ciudades t3 ON t1.cod_ciudad=t3.codigo " +
                "INNER JOIN catalogo_profesiones t4 ON t1.cod_profesion=t4.codigo";
            DataTable tabla = new DataTable();
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                SqlDataReader datos = comando.ExecuteReader();
                tabla.Load(datos);
                datos.Close();
                bd.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return tabla;
        }

        public DataTable Buscar(String criterio)
        {
            String sql = "SELECT t1.codigo, t1.nombres, t1.ap_paterno, t1.ap_materno, t1.ci, t2.nombre AS grado_academico, t3.nombre AS ciudad, t1.correo, t1.telefono, t1.cuenta_bancaria, t4.nombre AS profesion " +
                "FROM docentes t1 " +
                "INNER JOIN catalogo_grados_academicos t2 ON t1.cod_grado=t2.codigo " +
                "INNER JOIN catalogo_ciudades t3 ON t1.cod_ciudad=t3.codigo " +
                "INNER JOIN catalogo_profesiones t4 ON t1.cod_profesion=t4.codigo " +
                "WHERE t1.codigo LIKE CONCAT('%',@criterio,'%') " +
                "OR t1.nombres LIKE CONCAT('%',@criterio,'%') " +
                "OR t1.ap_paterno LIKE CONCAT('%',@criterio,'%') " +
                "OR t1.ap_materno LIKE CONCAT('%',@criterio,'%') " +
                "OR t1.ci LIKE CONCAT('%',@criterio,'%') " +
                "OR t2.nombre LIKE CONCAT('%',@criterio,'%') " +
                "OR t3.nombre LIKE CONCAT('%',@criterio,'%') " +
                "OR t1.telefono LIKE CONCAT('%',@criterio,'%') " +
                "OR t1.cuenta_bancaria LIKE CONCAT('%',@criterio,'%')" +
                "OR t4.nombre LIKE CONCAT('%',@criterio,'%') ";
            DataTable tabla = new DataTable();
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.Add("@criterio", SqlDbType.VarChar);
                comando.Parameters["@criterio"].Value = criterio;
                SqlDataReader datos = comando.ExecuteReader();
                tabla.Load(datos);
                datos.Close();
                bd.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return tabla;
        }

        public DataTable ListarGradosAcademicos()
        {
            String sql = "SELECT codigo, nombre FROM catalogo_grados_academicos ORDER BY codigo ASC";
            DataTable tabla = new DataTable();
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                SqlDataReader datos = comando.ExecuteReader();
                tabla.Load(datos);
                datos.Close();
                bd.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return tabla;
        }

        public DataTable ListarCiudades()
        {
            String sql = "SELECT codigo, nombre FROM catalogo_ciudades ORDER BY codigo ASC";
            DataTable tabla = new DataTable();
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                SqlDataReader datos = comando.ExecuteReader();
                tabla.Load(datos);
                datos.Close();
                bd.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return tabla;
        }

        public DataTable ListarProfesiones()
        {
            String sql = "SELECT codigo, nombre FROM catalogo_profesiones ORDER BY codigo ASC";
            DataTable tabla = new DataTable();
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                SqlDataReader datos = comando.ExecuteReader();
                tabla.Load(datos);
                datos.Close();
                bd.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return tabla;
        }
    }
}
