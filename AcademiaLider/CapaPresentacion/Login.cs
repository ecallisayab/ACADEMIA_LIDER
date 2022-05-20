using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AcademiaLider.CapaLogicaNegocio;
namespace AcademiaLider.CapaPresentacion

{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            logicaLogin verificar = new logicaLogin(txtUsuario.Text, txtPassword.Text);
            if (verificar.validar())
            {
                frmCatalogos cat = new frmCatalogos();
                //  frmMain cat = new frmMain();
                this.Hide();
                cat.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
