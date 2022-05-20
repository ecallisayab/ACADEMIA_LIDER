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
    public partial class frmMain : Form
    {
        private Form viewParticipante = null;
        private Form viewDocente = null;
        private Form viewEvento  = null;
        private Form viewInscripcion = null;
        private Form viewCertificado = null;
        private Form viewUsuarios = null;

        public frmMain()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            if (!this.MdiChildren.Contains(viewParticipante))
            {
                viewParticipante = new frmParticipante();
                viewParticipante.MdiParent = this;
            }
            viewParticipante.Show();
            viewParticipante.BringToFront();
        }



        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            init();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(viewDocente))
            {
                viewDocente = new frmDocente();
                viewDocente.MdiParent = this;
            }
            viewDocente.Show();
            viewDocente.BringToFront();
        }

        private void registroToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(viewInscripcion))
            {
                viewInscripcion = new frmInscripcion();
                viewInscripcion.MdiParent = this;
            }
            viewInscripcion.Show();
            viewInscripcion.BringToFront();
        }

        private void registroToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(viewEvento))
            {
                viewEvento = new Evento();
                viewEvento.MdiParent = this;
            }
            viewEvento.Show();
            viewEvento.BringToFront();
        }

        private void generarCertificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(viewCertificado))
            {
                viewCertificado = new frmCertificado();
                viewCertificado.MdiParent = this;
            }
            viewCertificado.Show();
            viewCertificado.BringToFront();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatalogos fr =new frmCatalogos();
           
            fr.ventana(fr);
    
            fr.ShowDialog();
           
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.MdiChildren.Contains(viewUsuarios))
            {
                viewUsuarios = new frmUsuarios();
                viewUsuarios.MdiParent = this;
            }
            viewUsuarios.Show();
            viewUsuarios.BringToFront();

        }
    }
}
