using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaLider.Entidades
{
    public class Participante
    {
        private String codigo;
        private String nombres;
        private String ap_paterno;
        private String ap_materno;
        private String ci;
        private int cod_grado;
        private int cod_ciudad;
        private String correo;
        private int telefono;
        private String fecha_nac;
        private int cod_profesion;
        private Byte[] foto;

        public Participante()
        {
            codigo = "";
            nombres = "";
            ap_paterno = "";
            ap_materno = "";
            ci = "";
            cod_grado = 0;
            cod_ciudad = 0;
            correo = "";
            telefono = 0;
            fecha_nac = "";
            cod_profesion = 0;
            foto = null;
        }

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public String ApPaterno
        {
            get { return ap_paterno; }
            set { ap_paterno = value; }
        }

        public String ApMaterno
        {
            get { return ap_materno; }
            set { ap_materno = value; }
        }

        public String Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        public int CodGrado
        {
            get { return cod_grado; }
            set { cod_grado = value; }
        }

        public int CodCiudad
        {
            get { return cod_ciudad; }
            set { cod_ciudad = value; }
        }

        public String Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public String FechaNac
        {
            get { return fecha_nac; }
            set { fecha_nac = value; }
        }

        public int CodProfesion
        {
            get { return cod_profesion; }
            set { cod_profesion = value; }
        }

        public Byte[] Foto
        {
            get { return foto; }
            set { foto = value; }
        }
    }
}
