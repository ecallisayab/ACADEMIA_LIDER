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
    public class ClnParticipante
    {
        private CadParticipante objAccesoDatos;
        private bool estado;
        private String mensaje;

        public ClnParticipante()
        {
            this.objAccesoDatos = new CadParticipante();
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

        public void CrearRegistro(Participante objParticipante)
        {
            this.mensaje = this.Validar(objParticipante);
            if (this.mensaje.Equals(""))
            {
                this.estado = this.objAccesoDatos.Crear(objParticipante);
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

        public void ModificarRegistro(Participante objParticipante)
        {
            this.mensaje = this.Validar(objParticipante);
            if (this.mensaje.Equals(""))
            {
                this.estado = this.objAccesoDatos.Modificar(objParticipante);
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

        public Participante ObtenerRegistro(String codigo)
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

        public DataTable ListarGradosAcademicos()
        {
            return this.objAccesoDatos.ListarGradosAcademicos();
        }

        public DataTable ListarCiudades()
        {
            return this.objAccesoDatos.ListarCiudades();
        }

        public DataTable ListarProfesiones()
        {
            return this.objAccesoDatos.ListarProfesiones();
        }

        private String Validar(Participante objParticipante)
        {
            String respuesta = "";

            if (objParticipante.Nombres.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Nombres.\n";
            }

            if (objParticipante.ApPaterno.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Apellido paterno.\n";
            }

            if (objParticipante.ApMaterno.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Apellido materno.\n";
            }

            if (objParticipante.Ci.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Cédula de identidad.\n";
            }

            if (objParticipante.FechaNac.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Fecha de nacimiento.\n";
            }

            if (objParticipante.CodProfesion.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Profesión.\n";
            }

            if (objParticipante.CodGrado.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Grado académico.\n";
            }

            if (objParticipante.CodCiudad.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Ciudad de procedencia.\n";
            }

            if (objParticipante.Correo.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Correo electrónico.\n";
            }

            if (objParticipante.Telefono.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Teléfono.";
            }

            return respuesta;
        }
    }
}
