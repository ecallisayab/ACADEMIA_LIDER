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
    class clnGrados
    {
        private cadGrados access;
        public clnGrados()
        {
            this.access = new cadGrados();
        }

        public String insert(Grados mega)
        {
            String confirm = "";
            if (access.insert(mega))
            {
                confirm = "Mensaje:Registro insertado";
            }
            return confirm;
        }

        public String update(Grados mega)
        {
            String confirm = "";
            if (access.update(mega))
            {
                confirm = "Mensaje:Registro Modificado";
            }
            return confirm;
        }
        public String delete(Grados mega)
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
