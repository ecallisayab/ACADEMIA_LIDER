using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using AcademiaLider.CapaAccesoDatos;
using AcademiaLider.Entidades;

namespace AcademiaLider.CapaLogicaNegocio
{
    class ClnInscripcion
    {
        private CadInscripcion objAccesoDatos;
        private bool estado;
        private String mensaje;

        public ClnInscripcion()
        {
            this.objAccesoDatos = new CadInscripcion();
            this.estado = false;
            this.mensaje = "";
        }

        public bool Estado
        {
            get { return this.estado; }
        }

        public String Mensaje
        {
            get { return this.mensaje; }
        }

        public void CrearRegistro(Inscripcion objInscripcion)
        {
            this.mensaje = this.Validar(objInscripcion);
            if (this.mensaje.Equals(""))
            {
                this.estado = this.objAccesoDatos.Crear(objInscripcion);
                if (this.estado)
                {
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

        public void ModificarRegistro(Inscripcion objInscripcion)
        {
            this.mensaje = this.Validar(objInscripcion);
            if (this.mensaje.Equals(""))
            {
                this.estado = this.objAccesoDatos.Modificar(objInscripcion);
                if (this.estado)
                {
                    this.mensaje = "El registro fue actualizado.";
                }
                else
                {
                    this.mensaje = "No se pudo actualizar el registro.";
                }
            }
            else
            {
                this.estado = false;
            }
        }

        public void EliminarRegistro(int codigo)
        {
            if (!codigo.Equals(""))
            {
                this.estado = this.objAccesoDatos.Eliminar(codigo);
                if (this.estado)
                {
                    this.mensaje = "El registro ha sido eliminado.";
                }
                else
                {
                    this.mensaje = "No se pudo eliminar el registro.";
                }
            }
            else
            {
                this.estado = false;
                this.mensaje = "Ingrese el código del registro que desea eliminar.";
            }
        }

        public Inscripcion ObtenerRegistro(int codigo)
        {
            return this.objAccesoDatos.Obtener(codigo);
        }

        public DataTable ListarRegistros()
        {
            return this.objAccesoDatos.Listar();
        }

        public DataTable BuscarRegistros(String criterio)
        {
            if (criterio.Equals(""))
            {
                return this.objAccesoDatos.Listar();
            }
            else
            {
                return this.objAccesoDatos.Buscar(criterio);
            }
        }

        public DataTable BuscarRegistroInscritos(String criterio)
        {
            if (criterio.Equals(""))
            {
                return null;
            }
            else
            {
                return this.objAccesoDatos.BuscarInscritos(criterio);
            }
        }

        private String Validar(Inscripcion objInscripcion)
        {
            String respuesta = "";

            if (objInscripcion.CodParticipante.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Participante.\n";
            }

            if (objInscripcion.CodEvento.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Evento.\n";
            }

            if (objInscripcion.Fecha.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Fecha.\n";
            }

            if (objInscripcion.Nota.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Nota.\n";
            }

            return respuesta;
        }
    }
}
