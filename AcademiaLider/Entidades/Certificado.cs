using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaLider.Entidades
{
    class Certificado
    {
        private String codigo;
        private int cod_inscripcion;

        public Certificado()
        {
            codigo = "";
            cod_inscripcion = 0;
        }

        public String Codigo
        {
            get{ return codigo; }
            set { codigo = value; }
        }

        public int CodInscripcion
        {
            get { return cod_inscripcion; }
            set { cod_inscripcion = value; }
        }
    }
}
