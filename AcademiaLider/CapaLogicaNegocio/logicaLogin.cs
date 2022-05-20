using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcademiaLider.CapaAccesoDatos;
namespace AcademiaLider.CapaLogicaNegocio
{
    class logicaLogin
    {
        private Accesslogin ac;
        private String user;
        private String password;
        public logicaLogin(String user, String password)
        {
            this.user = user;
            this.password = password;
            ac = new Accesslogin();

        }
        public Boolean validar()
        {
            return ac.login(user, password);
        }
    }
}
