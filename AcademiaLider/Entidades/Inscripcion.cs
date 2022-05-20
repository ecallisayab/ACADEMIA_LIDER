using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaLider.Entidades
{
    public class Inscripcion
    {
        private int codigo;
        private String cod_participante;
        private String nombre_participante;
        private String cod_evento;
        private String nombre_evento;
        private String fecha;
        private int nota;

        public Inscripcion()
        {
            codigo = 0;
            cod_participante = "";
            cod_evento = "";
            fecha = "";
            nota = 0;
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String CodParticipante
        {
            get { return cod_participante; }
            set { cod_participante = value; }
        }

        public String NombreParticipante
        {
            get { return nombre_participante; }
            set { nombre_participante = value; }
        }

        public String CodEvento
        {
            get { return cod_evento; }
            set { cod_evento = value; }
        }

        public String NombreEvento
        {
            get { return nombre_evento; }
            set { nombre_evento = value; }
        }

        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public int Nota
        {
            get { return nota; }
            set { nota = value; }
        }
    }
}
