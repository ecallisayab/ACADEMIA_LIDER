using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaLider.Entidades
{
    class Usuarios
    {

        private int codigo;
        private String nombre_completo;
        private String usuario;
        private String password;
        private String correo;
        public Usuarios()
        {
            this.codigo = 0;
            this.nombre_completo = "";
            this.usuario = "";
            this.password = "";
            this.correo = "";
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
                return nombre_completo;
            }
            set
            {
                nombre_completo = value;
            }
        }
        public String Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }

        }
        public String Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public String Correo
        {
            get
            {
                return correo;
            }
            set
            {
                correo = value;
            }
        }
    }
}
