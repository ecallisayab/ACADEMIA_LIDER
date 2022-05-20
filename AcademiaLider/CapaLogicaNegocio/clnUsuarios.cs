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
    class clnUsuarios
    {
        private cadUsuarios access;
        public clnUsuarios()
        {
            this.access = new cadUsuarios();
        }

        public String insert(Usuarios user)
        {
            String confirm = "";
            if (access.insert(user))
            {
                confirm = "Mensaje:Usuario Registrado";
            }
            return confirm;
        }

        public String update(Usuarios user)
        {
            String confirm = "";
            if (access.update(user))
            {
                confirm = "Mensaje:Usuario Modificado";
            }
            return confirm;
        }
        public String delete(Usuarios user)
        {

            String confirm = "";
            if (access.delete(user))
            {
                confirm = "Mensaje:Usuario Eliminado";
            }
            return confirm;

        }
        public DataTable getAll()
        {
            return this.access.getAll();
        }
        public DataTable busqueda(String val)
        {
            return this.access.busqueda(val);
        }
    }
}
