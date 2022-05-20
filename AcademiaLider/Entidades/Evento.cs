using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaLider.Entidades
{
    public class Evento
    {
        private String codigo;
        private String nombre;
        private int cod_modalidad;
        private String cod_docente;
        private int cod_ciudad;
        private int carga_horaria;
        private String fecha_inicio;
        private String fecha_final;
        private String estado;

        public Evento()
        {
            codigo = "";
            nombre = "";
            cod_modalidad = 0;
            cod_docente = "";
            cod_ciudad = 0;
            carga_horaria = 0;
            fecha_inicio = "";
            fecha_final = "";
            estado = "";
        }

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int CodModalidad
        {
            get { return cod_modalidad; }
            set { cod_modalidad = value; }
        }

        public String CodDocente
        {
            get { return cod_docente; }
            set { cod_docente = value; }
        }

        public int CodCiudad
        {
            get { return cod_ciudad; }
            set { cod_ciudad = value; }
        }

        public int CargaHoraria
        {
            get { return carga_horaria; }
            set { carga_horaria = value; }
        }

        public String FechaInicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }

        public String FechaFinal
        {
            get { return fecha_final; }
            set { fecha_final = value; }
        }
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }
    }


}
