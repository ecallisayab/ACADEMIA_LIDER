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
using System.IO;

namespace AcademiaLider.CapaAccesoDatos
{
    public class CadParticipante
    {
        public CadParticipante()
        {

        }

        public bool Crear(Participante objParticipante)
        {
            bool respuesta = false;
            String sql;
            String sqlFoto = "";
            String sqlFotoValor = "";

            if (objParticipante.Foto != null)
            {
                sqlFoto = ", foto";
                sqlFotoValor = ", @foto";
            }
            sql = "INSERT INTO participantes (codigo, nombres, ap_paterno, ap_materno, ci, cod_grado, cod_ciudad, correo, telefono, fecha_nac, cod_profesion"+sqlFoto+") " +
                "VALUES (CONCAT('LP-', RIGHT('00000' + Ltrim(Rtrim(NEXT VALUE FOR seq_participante)),5)), @nombres, @ap_paterno, @ap_materno, @ci, @cod_grado, @cod_ciudad, @correo, @telefono, @fecha_nac, @cod_profesion"+sqlFotoValor+")";

            int filas;
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@nombres", objParticipante.Nombres);
                comando.Parameters.AddWithValue("@ap_paterno", objParticipante.ApPaterno);
                comando.Parameters.AddWithValue("@ap_materno", objParticipante.ApMaterno);
                comando.Parameters.AddWithValue("@ci", objParticipante.Ci);
                comando.Parameters.AddWithValue("@cod_grado", objParticipante.CodGrado);
                comando.Parameters.AddWithValue("@cod_ciudad", objParticipante.CodCiudad);
                comando.Parameters.AddWithValue("@correo", objParticipante.Correo);
                comando.Parameters.AddWithValue("@telefono", objParticipante.Telefono);
                comando.Parameters.AddWithValue("@fecha_nac", objParticipante.FechaNac);
                comando.Parameters.AddWithValue("@cod_profesion", objParticipante.CodProfesion);
                if (objParticipante.Foto != null) {
                    comando.Parameters.AddWithValue("@foto", objParticipante.Foto);
                }
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

        public bool Modificar(Participante objParticipante)
        {
            bool respuesta = false;
            String sql;
            String sqlFoto = "";

            if (objParticipante.Foto != null)
            {
                sqlFoto = ", foto=@foto";
            }

            sql = "UPDATE participantes SET nombres=@nombres, ap_paterno=@ap_paterno, ap_materno=@ap_materno, ci=@ci, cod_grado=@cod_grado, cod_ciudad=@cod_ciudad, correo=@correo, telefono=@telefono, fecha_nac=@fecha_nac, cod_profesion=@cod_profesion"+sqlFoto+" WHERE codigo=@codigo";

            int filas;
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@nombres", objParticipante.Nombres);
                comando.Parameters.AddWithValue("@ap_paterno", objParticipante.ApPaterno);
                comando.Parameters.AddWithValue("@ap_materno", objParticipante.ApMaterno);
                comando.Parameters.AddWithValue("@ci", objParticipante.Ci);
                comando.Parameters.AddWithValue("@cod_grado", objParticipante.CodGrado);
                comando.Parameters.AddWithValue("@cod_ciudad", objParticipante.CodCiudad);
                comando.Parameters.AddWithValue("@correo", objParticipante.Correo);
                comando.Parameters.AddWithValue("@telefono", objParticipante.Telefono);
                comando.Parameters.AddWithValue("@fecha_nac", objParticipante.FechaNac);
                comando.Parameters.AddWithValue("@cod_profesion", objParticipante.CodProfesion);
                if (objParticipante.Foto != null)
                {
                    comando.Parameters.AddWithValue("@foto", objParticipante.Foto);
                }
                comando.Parameters.AddWithValue("@codigo", objParticipante.Codigo);
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
            String sql = "DELETE FROM participantes WHERE codigo=@codigo";
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

        public Participante Obtener(String codigo)
        {
            Participante objParticipante = new Participante();
            try
            {
                String sql = "SELECT * FROM participantes WHERE codigo=@codigo";
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@codigo", codigo);
                SqlDataReader datos = comando.ExecuteReader();
                if (datos.Read())
                {
                    objParticipante.Codigo = datos["codigo"].ToString();
                    objParticipante.Nombres = datos["nombres"].ToString();
                    objParticipante.ApPaterno = datos["ap_paterno"].ToString();
                    objParticipante.ApMaterno = datos["ap_materno"].ToString();
                    objParticipante.Ci = datos["ci"].ToString();
                    objParticipante.CodGrado = Convert.ToInt32(datos["cod_grado"].ToString());
                    objParticipante.CodCiudad = Convert.ToInt32(datos["cod_ciudad"].ToString());
                    objParticipante.Correo = datos["correo"].ToString();
                    objParticipante.Telefono = Convert.ToInt32(datos["telefono"].ToString());
                    objParticipante.FechaNac = datos["fecha_nac"].ToString();
                    objParticipante.CodProfesion = Convert.ToInt32(datos["cod_profesion"].ToString());
                    objParticipante.Foto = datos["foto"] != DBNull.Value ? (Byte[]) datos["foto"] : null;
                }
                bd.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return objParticipante;
        }

        public DataTable Listar()
        {
            String sql = "SELECT t1.codigo, t1.nombres, t1.ap_paterno, t1.ap_materno, t1.ci, t2.nombre as grado_academico, t3.nombre as ciudad, t1.correo, t1.telefono, t1.fecha_nac, t4.nombre AS profesion "+
                "FROM participantes t1 "+
                "INNER JOIN catalogo_grados_academicos t2 ON t1.cod_grado=t2.codigo "+
                "INNER JOIN catalogo_ciudades t3 ON t1.cod_ciudad=t3.codigo "+
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
            String sql = "SELECT t1.codigo, t1.nombres, t1.ap_paterno, t1.ap_materno, t1.ci, t2.nombre AS grado_academico, t3.nombre AS ciudad, t1.correo, t1.telefono, t1.fecha_nac, t4.nombre AS profesion " +
                "FROM participantes t1 " +
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
                "OR t1.fecha_nac LIKE CONCAT('%',@criterio,'%')"+
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
