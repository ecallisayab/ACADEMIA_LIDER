using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaLider.CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        private Form formActivo = null;

        private Form formParticipante = null;
        private Form formDocente = null;
        private Form formEvento = null;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }

        private void MostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void OcultarSubmenu()
        {
            panelCertificados.Visible = false;
            panelCatalogos.Visible = false;
        }

        

        private void MostrarFormularioHijo(Form formHijo)
        {
            if (formActivo != null)
            {
                formActivo.Hide();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.TopMost = true;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            //panelContenedor.Tag = formHijo;
            //formHijo.BringToFront();
            formHijo.Show();
        }

        private void btnMenuParticipante_Click(object sender, EventArgs e)
        {
            if (formParticipante == null)
            {
                formParticipante = new frmParticipante();
                MostrarFormularioHijo(formParticipante);
            }
            else
            {
                MostrarFormularioHijo(formParticipante);
            }
        }

        private void btnMenuDocente_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuEvento_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuInscripcion_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuCertificado_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelCertificados);
        }

        private void btnSubmenuImpParticipante_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmenuImpEvento_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuCatalogo_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelCatalogos);
        }

        private void btnSubmenuProfesion_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmenuGradoAcademico_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmenuCiudad_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmenuModalidad_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
