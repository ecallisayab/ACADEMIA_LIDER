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
    public class CadEvento
    {
        public CadEvento()
        {

        }

        public bool Crear(Evento objEvento)
        {
            bool respuesta = false;
            String sql = "INSERT INTO eventos (codigo, nombre, cod_modalidad, carga_horaria, fecha_inicio, fecha_final, cod_ciudad, estado, cod_docente) " +
                "VALUES (CONCAT('LE-', RIGHT('00000' + Ltrim(Rtrim(NEXT VALUE FOR seq_evento)),5)), @nombre, @cod_modalidad, @carga_horaria, @fecha_inicio, @fecha_final, @cod_ciudad, @estado, @cod_docente)";
            int filas;
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@nombre", objEvento.Nombre);
                comando.Parameters.AddWithValue("@cod_modalidad", objEvento.CodModalidad);
                comando.Parameters.AddWithValue("@carga_horaria", objEvento.CargaHoraria);
                comando.Parameters.AddWithValue("@fecha_inicio", objEvento.FechaInicio);
                comando.Parameters.AddWithValue("@fecha_final", objEvento.FechaFinal);
                comando.Parameters.AddWithValue("@cod_ciudad", objEvento.CodCiudad);
                comando.Parameters.AddWithValue("@estado", objEvento.Estado);
                comando.Parameters.AddWithValue("@cod_docente", objEvento.CodDocente);
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

        public bool Modificar(Evento objEvento)
        {
            bool respuesta = false;
            String sql = "UPDATE eventos SET nombre=@nombre, cod_modalidad=@cod_modalidad, carga_horaria=@carga_horaria, fecha_inicio=@fecha_inicio, fecha_final=@fecha_final, cod_ciudad=@cod_ciudad, estado=@estado, cod_docente=@cod_docente WHERE codigo=@codigo";
            int filas;
            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@nombre", objEvento.Nombre);
                comando.Parameters.AddWithValue("@cod_modalidad", objEvento.CodModalidad);
                comando.Parameters.AddWithValue("@carga_horaria", objEvento.CargaHoraria);
                comando.Parameters.AddWithValue("@fecha_inicio", objEvento.FechaInicio);
                comando.Parameters.AddWithValue("@fecha_final", objEvento.FechaFinal);
                comando.Parameters.AddWithValue("@cod_ciudad", objEvento.CodCiudad);
                comando.Parameters.AddWithValue("@estado", objEvento.Estado);
                comando.Parameters.AddWithValue("@cod_docente", objEvento.CodDocente);
                comando.Parameters.AddWithValue("@codigo", objEvento.Codigo);
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
            String sql = "DELETE FROM eventos WHERE codigo=@codigo";
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

        public Evento Obtener(String codigo)
        {
            Evento objEvento = new Evento();
            try
            {
                String sql = "SELECT * FROM eventos WHERE codigo=@codigo";
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@codigo", codigo);
                SqlDataReader datos = comando.ExecuteReader();
                if (datos.Read())
                {
                    objEvento.Codigo = datos["codigo"].ToString();
                    objEvento.Nombre = datos["nombre"].ToString();
                    objEvento.CodModalidad = Convert.ToInt32(datos["cod_modalidad"].ToString());
                    objEvento.CargaHoraria = Convert.ToInt32(datos["carga_horaria"].ToString());
                    objEvento.FechaInicio = datos["fecha_inicio"].ToString();
                    objEvento.FechaFinal = datos["fecha_final"].ToString();
                    objEvento.CodCiudad = Convert.ToInt32(datos["cod_ciudad"].ToString());
                    objEvento.Estado = datos["estado"].ToString();
                    objEvento.CodDocente = Convert.ToString(datos["cod_docente"]).ToString();
                }
                bd.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error en la consulta: " + ex.Message);
            }
            return objEvento;
        }

        public DataTable Listar()
        {
            String sql = "SELECT t1.codigo,t1.nombre,t2.nombre as modalidad,t1.carga_horaria,t1.fecha_inicio,t1.fecha_final,t3.nombre as ciudad,t1.estado,CONCAT(t4.nombres,' ',t4.ap_paterno,' ',t4.ap_materno) as docente " +
                "FROM eventos t1 " +
                "INNER JOIN catalogo_modalidades t2 ON t2.codigo = t1.cod_modalidad " +
                "INNER JOIN catalogo_ciudades t3 ON t3.codigo = t1.cod_ciudad " +
                "INNER JOIN docentes t4 ON t1.cod_docente = t4.codigo ";
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
            String sql = "SELECT t1.codigo,t1.nombre,t2.nombre as modalidad,t1.carga_horaria,t1.fecha_inicio,t1.fecha_final,t3.nombre as ciudad,t1.estado,CONCAT(t4.nombres,' ',t4.ap_paterno,' ',t4.ap_materno) as docente " +
                "FROM eventos t1 " +
                "INNER JOIN catalogo_modalidades t2 ON t2.codigo = t1.cod_modalidad " +
                "INNER JOIN catalogo_ciudades t3 ON t3.codigo = t1.cod_ciudad " +
                "INNER JOIN docentes t4 ON t1.cod_docente = t4.codigo " +
                 "WHERE t1.codigo LIKE CONCAT('%',@criterio,'%') " +
                 "OR t1.nombre LIKE CONCAT('%',@criterio,'%') " +
                 "OR t2.nombre LIKE CONCAT('%',@criterio,'%') " + 
                 "OR t1.carga_horaria LIKE CONCAT('%',@criterio,'%') " +
                 "OR t1.fecha_inicio LIKE CONCAT('%',@criterio,'%') " +
                 "OR t1.fecha_final LIKE CONCAT('%',@criterio,'%') " +
                 "OR t3.nombre LIKE CONCAT('%',@criterio,'%') " +
                 "OR t1.estado LIKE CONCAT('%',@criterio,'%') " +
                 "OR t4.nombres LIKE CONCAT('%',@criterio,'%') " +
                 "OR t4.ap_paterno LIKE CONCAT('%',@criterio,'%') " +
                 "OR t4.ap_materno LIKE CONCAT('%',@criterio,'%') ";
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

        public DataTable ListarModalidades()
        {
            String sql = "SELECT codigo, nombre FROM catalogo_modalidades ORDER BY codigo ASC";
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

        public DataTable ListarDocentes()
        { 
            String sql = "SELECT codigo, CONCAT(nombres,' ',ap_paterno,' ',ap_materno) as nombre FROM docentes ORDER BY codigo ASC";
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
