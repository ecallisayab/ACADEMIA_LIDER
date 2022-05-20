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
    public class ClnDocente
    {
        private CadDocente objAccesoDatos;
        private bool estado;
        private String mensaje;

        public ClnDocente()
        {
            this.objAccesoDatos = new CadDocente();
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

        public void CrearRegistro(Docente objDocente)
        {
            this.mensaje = this.Validar(objDocente);
            if (this.mensaje.Equals(""))
            {
                this.estado = this.objAccesoDatos.Crear(objDocente);
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

        public void ModificarRegistro(Docente objDocente)
        {
            this.mensaje = this.Validar(objDocente);
            if (this.mensaje.Equals(""))
            {
                this.estado = this.objAccesoDatos.Modificar(objDocente);
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

        public Docente ObtenerRegistro(String codigo)
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

        private String Validar(Docente objDocente)
        {
            String respuesta = "";

            if (objDocente.Nombres.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Nombres.\n";
            }

            if (objDocente.ApPaterno.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Apellido paterno.\n";
            }

            if (objDocente.ApMaterno.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Apellido materno.\n";
            }

            if (objDocente.Ci.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Cédula de identidad.\n";
            }

            if (objDocente.CuentaBancaria.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Nro. Cuenta.\n";
            }

            if (objDocente.CodProfesion.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Profesión.\n";
            }

            if (objDocente.CodGrado.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Grado académico.\n";
            }

            if (objDocente.CodCiudad.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Ciudad de procedencia.\n";
            }

            if (objDocente.Correo.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Correo electrónico.\n";
            }

            if (objDocente.Telefono.Equals(""))
            {
                respuesta += "Ingrese datos en el campo Teléfono.";
            }

            return respuesta;
        }
    }
}
