using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaLider.Entidades
{
    class Modalidades
    {

        private int codigo;
        private String nombre;
        public Modalidades()
        {
            this.codigo = 0;
            this.nombre = "";
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
    }
}
