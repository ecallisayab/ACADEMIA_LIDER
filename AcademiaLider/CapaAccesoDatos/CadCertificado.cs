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
    class CadCertificado
    {
        private String id;

        public CadCertificado()
        {
            id = "";
        }

        public String Id
        {
            get { return id; }
        }

        public bool Crear(Certificado objCertificado)
        {
            bool respuesta = false;
            String sql = "INSERT INTO certificados (codigo, cod_inscripcion, fecha) OUTPUT INSERTED.codigo " +
                "VALUES (CONCAT('LC-', RIGHT('00000' + Ltrim(Rtrim(NEXT VALUE FOR seq_certificado)),5)), @cod_inscripcion, GETDATE())";

            try
            {
                ConexionBaseDatos bd = new ConexionBaseDatos();
                SqlCommand comando = new SqlCommand(sql, bd.Conectar());
                comando.Parameters.AddWithValue("@cod_inscripcion", objCertificado.CodInscripcion);
                id = (String)comando.ExecuteScalar();
                bd.Cerrar();
                if (!id.Equals(""))
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
    }
}
