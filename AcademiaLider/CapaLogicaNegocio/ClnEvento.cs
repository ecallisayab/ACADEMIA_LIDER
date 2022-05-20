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
    public class ClnEvento
    {
        private CadEvento objAccesoDatos;
        private bool estado;
        private String mensaje;

        public ClnEvento()
        {
            this.objAccesoDatos = new CadEvento();
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

        public void CrearRegistro(Evento objEvento)
        {
            this.mensaje = this.Validar(objEvento);
            if (this.mensaje.Equals(""))
            {
                this.estado = this.objAccesoDatos.Crear(objEvento);
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

        public void ModificarRegistro(Evento objEvento)
        {
            this.mensaje = this.Validar(objEvento);
            if (this.mensaje.Equals(""))
            {
                this.estado = this.objAccesoDatos.Modificar(objEvento);
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

        public void EliminarRegistro(String codigo)
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

        public Evento ObtenerRegistro(String codigo)
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

        public DataTable ListarModalidades()
        {
            return this.objAccesoDatos.ListarModalidades();
        }

        public DataTable ListarCiudades()
        {
            return this.objAccesoDatos.ListarCiudades();
        }

        public DataTable ListarDocentes()
        {
            return this.objAccesoDatos.ListarDocentes();
        }

        private String Validar(Evento objEvento)
        {
            String respuesta = "";

            if (objEvento.Nombre.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Nombre.\n";
            }

            if (objEvento.CodModalidad.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Modalidad.\n";
            }

            if (objEvento.CargaHoraria.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Carga Horaria.\n";
            }

            if (objEvento.FechaInicio.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Fecha Inicio.\n";
            }

            if (objEvento.FechaFinal.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Fecha Final.\n";
            }

            if (objEvento.CodCiudad.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Ciudad.\n";
            }

            if (objEvento.Estado.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Estado.\n";
            }

            if (objEvento.CodDocente.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Docente.";
            }

            return respuesta;
        }

    }
}
