using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaLider.Entidades
{
    class Grados
    {

        private int codigo;
        private String nombre;
        public Grados()
        {
            this.codigo = 0;
            this.nombre = "";
        }

       
        public String Nombres
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Codigo
        {
            get
            {
                return codigo;
            }
            set
            {
                codigo = value;
            }
        }
    }
}
