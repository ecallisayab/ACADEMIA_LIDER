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
    public partial class frmCiudades : Form
    {
        private clnCiudades action;
        private Ciudades updateLocal;
        public frmCiudades()
        {
            InitializeComponent();
        }
        public void selectAll()
        {
            action = new clnCiudades();
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
            txtCiudad.Text = "";

        }
        public Boolean validar()
        {

            if (txtCiudad.Text == "")
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

                Ciudades city = new Ciudades();
                city.Nombres = txtCiudad.Text;

                action = new clnCiudades();
                lblMessage.Text = action.insert(city);
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

                Ciudades city = new Ciudades();
                city.Codigo = updateLocal.Codigo;
                city.Nombres = txtCiudad.Text;
                action = new clnCiudades();
                lblMessage.Text = action.update(city);
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

                Ciudades city = new Ciudades();
                city.Codigo = updateLocal.Codigo;
                city.Nombres = txtCiudad.Text;
                action = new clnCiudades();
                lblMessage.Text = action.delete(city);
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
                action = new clnCiudades();
                dgvList.DataSource = action.busqueda(txtBuscar.Text);

            }
            else
            {
                selectAll();
            }
        }

        private void frmCiudades_Load(object sender, EventArgs e)
        {
            selectAll();
            selectAll();
            disableDataGrid();
        }

        private void dgvCargar(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvList.Rows.Count - 1)
            {
                updateLocal = new Ciudades();
                updateLocal.Codigo = Convert.ToInt32(dgvList.Rows[e.RowIndex].Cells[0].Value.ToString());
                updateLocal.Nombres = dgvList.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtCiudad.Text = updateLocal.Nombres;
                actionDataGrid();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}
