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
using AcademiaLider.Entidades;

namespace AcademiaLider.CapaPresentacion
{
    public partial class frmDocente : Form
    {
        private ClnDocente objLogicaNegocio = new ClnDocente();
        private Docente objDocente = new Docente();

        public frmDocente()
        {
            InitializeComponent();
        }

        private void frmDocentes_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Limpiar();
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
            CargarGradosAcademicos();
            CargarProfesioness();
            CargarCiudades();
            Listar();
        }

        private void Limpiar()
        {
            txtNombres.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtCi.Text = "";
            txtCuenta.Text = "";
            if (cboCiudad.Items.Count > 0)
            {
                cboCiudad.SelectedIndex = 0;
            }
            else
            {
                cboCiudad.Text = "";
            }
            if (cboProfesion.Items.Count > 0)
            {
                cboProfesion.SelectedIndex = 0;
            }
            else
            {
                cboProfesion.Text = "";
            }

            if (cboGradoAcademico.Items.Count > 0)
            {
                cboGradoAcademico.SelectedIndex = 0;
            }
            else
            {
                cboGradoAcademico.Text = "";
            }
            txtCorreo.Text = "";
            txtTelefono.Text = "";
        }

        private void Inicializar()
        {
            objDocente = new Docente();
        }

        private void HabilitarBtnNuevo()
        {
            btnNuevo.Enabled = true;
        }

        private void DeshabilitarBtnNuevo()
        {
            btnNuevo.Enabled = false;
        }

        private void HabilitarBtnModificar()
        {
            btnModificar.Enabled = true;
        }

        private void DeshabilitarBtnModificar()
        {
            btnModificar.Enabled = false;
        }

        private void HabilitarBtnEliminar()
        {
            btnEliminar.Enabled = true;
        }

        private void DeshabilitarBtnEliminar()
        {
            btnEliminar.Enabled = false;
        }

        private void CargarGradosAcademicos()
        {
            cboGradoAcademico.ValueMember = "codigo";
            cboGradoAcademico.DisplayMember = "nombre";
            cboGradoAcademico.DataSource = objLogicaNegocio.ListarGradosAcademicos();
        }

        private void CargarProfesioness()
        {
            cboProfesion.ValueMember = "codigo";
            cboProfesion.DisplayMember = "nombre";
            cboProfesion.DataSource = objLogicaNegocio.ListarProfesiones();
        }

        private void CargarCiudades()
        {
            cboCiudad.ValueMember = "codigo";
            cboCiudad.DisplayMember = "nombre";
            cboCiudad.DataSource = objLogicaNegocio.ListarCiudades();
        }

        private void Listar()
        {
            dgvListado.DataSource = objLogicaNegocio.ListarRegistros();
        }

        private void CargarDatos()
        {
            objDocente.Nombres = txtNombres.Text;
            objDocente.ApPaterno = txtApPaterno.Text;
            objDocente.ApMaterno = txtApMaterno.Text;
            objDocente.Ci = txtCi.Text;
            objDocente.CuentaBancaria = txtCuenta.Text;
            objDocente.CodProfesion = Convert.ToInt32(cboProfesion.SelectedValue);
            objDocente.CodGrado = Convert.ToInt32(cboGradoAcademico.SelectedValue);
            objDocente.CodCiudad = Convert.ToInt32(cboCiudad.SelectedValue);
            objDocente.Correo = txtCorreo.Text;
            objDocente.Telefono = txtTelefono.Text.Equals("") ? 0 : Convert.ToInt32(txtTelefono.Text);
        }

        private void MostrarDatos()
        {
            txtNombres.Text = objDocente.Nombres;
            txtApPaterno.Text = objDocente.ApPaterno;
            txtApMaterno.Text = objDocente.ApMaterno;
            txtCi.Text = objDocente.Ci;
            txtCuenta.Text = objDocente.CuentaBancaria;
            cboCiudad.SelectedValue = objDocente.CodCiudad;
            cboProfesion.SelectedValue = objDocente.CodProfesion;
            cboGradoAcademico.SelectedValue = objDocente.CodGrado;
            txtCorreo.Text = objDocente.Correo;
            txtTelefono.Text = objDocente.Telefono.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DeshabilitarBtnNuevo();
            Inicializar();
            CargarDatos();
            objLogicaNegocio.CrearRegistro(objDocente);
            if (objLogicaNegocio.Estado)
            {
                Limpiar();
                Listar();
                //MessageBox.Show(objLogicaNegocio.Mensaje);
                lblMensaje.Text = objLogicaNegocio.Mensaje;
            }
            else
            {
                MessageBox.Show(objLogicaNegocio.Mensaje);
            }
            HabilitarBtnNuevo();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
            CargarDatos();
            objLogicaNegocio.ModificarRegistro(objDocente);
            if (objLogicaNegocio.Estado)
            {
                Limpiar();
                HabilitarBtnNuevo();
                Listar();
                //MessageBox.Show(objLogicaNegocio.Mensaje);
                lblMensaje.Text = objLogicaNegocio.Mensaje;
            }
            else
            {
                HabilitarBtnModificar();
                HabilitarBtnEliminar();
                MessageBox.Show(objLogicaNegocio.Mensaje);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
            objLogicaNegocio.EliminarRegistro(objDocente.Codigo);
            if (objLogicaNegocio.Estado)
            {
                Limpiar();
                HabilitarBtnNuevo();
                Listar();
                //MessageBox.Show(objLogicaNegocio.Mensaje);
                lblMensaje.Text = objLogicaNegocio.Mensaje;
            }
            else
            {
                HabilitarBtnModificar();
                HabilitarBtnEliminar();
                MessageBox.Show(objLogicaNegocio.Mensaje);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Inicializar();
            HabilitarBtnNuevo();
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
        }

        private void dgvListado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvListado.Rows.Count - 1)
            {
                String codigo = dgvListado.Rows[e.RowIndex].Cells[0].Value.ToString();
                objDocente = objLogicaNegocio.ObtenerRegistro(codigo);
                DeshabilitarBtnNuevo();
                HabilitarBtnModificar();
                HabilitarBtnEliminar();
                MostrarDatos();
            }
        }

        private void txtCriterioBusqueda_TextChanged(object sender, EventArgs e)
        {
            String criterio = txtCriterioBusqueda.Text;
            dgvListado.DataSource = objLogicaNegocio.BuscarRegistros(criterio);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String criterio = txtCriterioBusqueda.Text;
            dgvListado.DataSource = objLogicaNegocio.BuscarRegistros(criterio);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
