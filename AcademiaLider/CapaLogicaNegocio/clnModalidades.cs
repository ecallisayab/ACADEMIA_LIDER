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
    class clnModalidades
    {

        private cadModalidades access;
        public clnModalidades()
        {
            this.access = new cadModalidades();
        }

        public String insert(Modalidades mega)
        {
            String confirm = "";
            if (access.insert(mega))
            {
                confirm = "Mensaje:Registro insertado";
            }
            return confirm;
        }

        public String update(Modalidades mega)
        {
            String confirm = "";
            if (access.update(mega))
            {
                confirm = "Mensaje:Registro Modificado";
            }
            return confirm;
        }
        public String delete(Modalidades mega)
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
