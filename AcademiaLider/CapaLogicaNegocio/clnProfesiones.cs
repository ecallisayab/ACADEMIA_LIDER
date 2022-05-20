using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using AcademiaLider.CapaAccesoDatos;
using AcademiaLider.Entidades;
using System.Data;

namespace AcademiaLider.CapaLogicaNegocio
{
    class clnProfesiones
    {

        private cadProfesiones access;
        public clnProfesiones()
        {
            this.access = new cadProfesiones();
        }

        public String insert(Profesiones mega)
        {
            String confirm = "";
            if (access.insert(mega))
            {
                confirm = "Mensaje:Registro insertado";
            }
            return confirm;
        }

        public String update(Profesiones mega)
        {
            String confirm = "";
            if (access.update(mega))
            {
                confirm = "Mensaje:Registro Modificado";
            }
            return confirm;
        }
        public String delete(Profesiones mega)
        {

            String confirm = "";
            if (access.delete(mega))
            {
                confirm = "Mensaje:Registro Eliminado";
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
