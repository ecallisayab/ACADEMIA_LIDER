using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AcademiaLider.Entidades;
using AcademiaLider.CapaLogicaNegocio;
namespace AcademiaLider.CapaPresentacion
{
    public partial class frmGradosAcademi : Form
    {
        private clnGrados action;
        private Grados updateLocal;
        public frmGradosAcademi()
        {
            InitializeComponent();
        }
        public void selectAll()
        {
            action = new clnGrados();
            dgvList.DataSource = this.action.getAll();

        }

        public void actionDataGrid()
        {
            btnNuevo.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
            lblMessage.Text = "Mensaje:";
        }
        public void disableDataGrid()
        {
            btnNuevo.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

        }
        public void clean()
        {
            txtGradoAcademico.Text = "";

        }
        public Boolean validar()
        {

            if (txtGradoAcademico.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                Grados mongo = new Grados();
                mongo.Nombres = txtGradoAcademico.Text;

                action = new clnGrados();
                lblMessage.Text = action.insert(mongo);
                selectAll();
                clean();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos...");

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (validar())
            {

                Grados mongo = new Grados();
                mongo.Codigo = updateLocal.Codigo;
                mongo.Nombres = txtGradoAcademico.Text;
                action = new clnGrados();
                lblMessage.Text = action.update(mongo);
                selectAll();
                clean();
                disableDataGrid();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos...");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (validar())
            {

                Grados mongo = new Grados();
                mongo.Codigo = updateLocal.Codigo;
                mongo.Nombres = txtGradoAcademico.Text;
                action = new clnGrados();
                lblMessage.Text = action.delete(mongo);
                selectAll();
                clean();
                disableDataGrid();

            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos...");

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            clean();
            selectAll();
            disableDataGrid();
        }

        private void frmGradosAcademi_Load(object sender, EventArgs e)
        {
            selectAll();
            disableDataGrid();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }

        private void dgvCargar(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvList.Rows.Count - 1)
            {
                updateLocal = new Grados();
                updateLocal.Codigo = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[0].Value.ToString());
                updateLocal.Nombres = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtGradoAcademico.Text = updateLocal.Nombres;
                actionDataGrid();
            }
        }
    }
}
