using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using AcademiaLider.CapaAccesoDatos;
using AcademiaLider.Entidades;

namespace AcademiaLider.CapaLogicaNegocio
{
    class ClnCertificado
    {
        private CadCertificado objAccesoDatos;
        private bool estado;
        private String mensaje;
        private String id;

        public ClnCertificado()
        {
            this.objAccesoDatos = new CadCertificado();
            this.estado = false;
            this.mensaje = "";
            this.id = "";
        }

        public bool Estado
        {
            get { return this.estado; }
        }

        public String Mensaje
        {
            get { return this.mensaje; }
        }

        public String Id
        {
            get { return this.id; }
        }

        public void CrearRegistro(Certificado objCertificado)
        {
            this.mensaje = this.Validar(objCertificado);
            if (this.mensaje.Equals(""))
            {
                this.estado = this.objAccesoDatos.Crear(objCertificado);
                if (this.estado)
                {
                    this.id = this.objAccesoDatos.Id;
                    this.mensaje = "El registro fue creado.";
                }
                else
                {
                    this.mensaje = "No se pudo crear el registro.";
                }
            }
            else
            {
                this.estado = false;
            }
        }

        private String Validar(Certificado objCertificado)
        {
            String respuesta = "";

            if (objCertificado.CodInscripcion.Equals(""))
            {
                respuesta += "El código de inscripción no tiene valor.\n";
            }

            return respuesta;
        }
    }
}
