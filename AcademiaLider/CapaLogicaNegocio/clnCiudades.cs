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
    class clnCiudades
    {
        private cadCiudades access;
        public clnCiudades()
        {
            this.access = new cadCiudades();
        }

        public String insert(Ciudades city)
        {
            String confirm = "";
            if (access.insert(city))
            {
                confirm = "Mensaje:Registro insertado";
            }
            return confirm;
        }

        public String update(Ciudades city)
        {
            String confirm = "";
            if (access.update(city))
            {
                confirm = "Mensaje:Registro Modificado";
            }
            return confirm;
        }
        public String delete(Ciudades city)
        {

            String confirm = "";
            if (access.delete(city))
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
