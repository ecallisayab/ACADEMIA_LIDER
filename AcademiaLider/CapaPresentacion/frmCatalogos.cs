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
    public partial class frmCatalogos : Form
    {
        public frmCatalogos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmProfesionales f = new frmProfesionales();
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmGradosAcademi f = new frmGradosAcademi();
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            frmCiudades f = new frmCiudades();
            this.Hide();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmModalidades f = new frmModalidades();
            this.Hide();
            f.ShowDialog();
        }
    }
}
