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
    public partial class frmProfesionales : Form
    {
        private clnProfesiones action;
        private Profesiones updateLocal;
        private frmCatalogos cat = null;
        public frmProfesionales()
        {
            InitializeComponent();
          
        }
        public void selectAll()
        {
            action = new clnProfesiones();
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
            txtProfesion.Text = "";

        }
        public Boolean validar()
        {

            if (txtProfesion.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        public void volver(frmCatalogos cat)
        {
            this.cat = cat;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (validar())
            {

                Profesiones mongo = new Profesiones();
                mongo.Nombres = txtProfesion.Text;

                action = new clnProfesiones();
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

                Profesiones mongo = new Profesiones();
                mongo.Codigo = updateLocal.Codigo;
                mongo.Nombres = txtProfesion.Text;
                action = new clnProfesiones();
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

                Profesiones mongo = new Profesiones();
                mongo.Codigo = updateLocal.Codigo;
                mongo.Nombres = txtProfesion.Text;
                action = new clnProfesiones();
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                action = new clnProfesiones();
                dgvList.DataSource = action.busqueda(txtBuscar.Text);

            }
            else
            {
                selectAll();
            }
        }

        private void frmProfesionales_Load(object sender, EventArgs e)
        {
            selectAll();
            disableDataGrid();
        }

        private void dgvCargar(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvList.Rows.Count - 1)
            {
                updateLocal = new Profesiones();
                updateLocal.Codigo = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[0].Value.ToString());
                updateLocal.Nombres = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtProfesion.Text = updateLocal.Nombres;
                actionDataGrid();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.cat.Show();
            this.Close();
        }
    }
}
