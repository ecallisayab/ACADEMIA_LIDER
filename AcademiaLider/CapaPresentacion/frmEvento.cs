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
    public partial class Evento : Form
    {
        private ClnEvento objLogicaNegocio = new ClnEvento();
        private Entidades.Evento objEvento = new Entidades.Evento();

        public Evento()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DeshabilitarBtnNuevo();
            Inicializar();
            CargarDatos();
            objLogicaNegocio.CrearRegistro(objEvento);
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
            objLogicaNegocio.ModificarRegistro(objEvento);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
            objLogicaNegocio.EliminarRegistro(objEvento.Codigo);
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

        private void Listar()
        {
            dgvListado.DataSource = objLogicaNegocio.ListarRegistros();
        }

        private void frmEvento_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Limpiar();
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
            CargarModalidades();
            CargarCiudades();
            CargarDocentes();
            Listar();
        }

        private void Limpiar()
        {
            txtNombres.Text = "";
            cboModalidad.Text = "";
            txtCargaHoraria.Text = "";
            dtpFechaInicio.Text = "";
            dtpFechaFinal.Text = "";
            if (cboCiudad.Items.Count > 0)
            {
                cboCiudad.SelectedIndex = 0;
            }
            else
            {
                cboCiudad.Text = "";
            }

            if (cboEstado.Items.Count > 0)
            {
                cboEstado.SelectedIndex = 0;
            }
            else
            {
                cboEstado.Text = "";
            }

            if (cboDocente.Items.Count > 0)
            {
                cboDocente.SelectedIndex = 0;
            }
            else
            {
                cboDocente.Text = "";
            }
            
        }

        private void Inicializar()
        {
            objEvento = new Entidades.Evento();
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

        private void CargarModalidades()
        {
            cboModalidad.ValueMember = "codigo";
            cboModalidad.DisplayMember = "nombre";
            cboModalidad.DataSource = objLogicaNegocio.ListarModalidades();
        }

        private void CargarCiudades()
        {
            cboCiudad.ValueMember = "codigo";
            cboCiudad.DisplayMember = "nombre";
            cboCiudad.DataSource = objLogicaNegocio.ListarCiudades();
        }

        private void CargarDocentes()
        {
            cboDocente.ValueMember = "codigo";
            cboDocente.DisplayMember = "nombre";
            cboDocente.DataSource = objLogicaNegocio.ListarDocentes();
        }

        private void CargarDatos()
        {
            objEvento.Nombre = txtNombres.Text;
            objEvento.CodModalidad = Convert.ToInt32(cboModalidad.SelectedValue);
            objEvento.CargaHoraria = Convert.ToInt32(txtCargaHoraria.Text);
            objEvento.FechaInicio = dtpFechaInicio.Value.Year + "-" + dtpFechaInicio.Value.Month + "-" + dtpFechaInicio.Value.Day;
            objEvento.FechaFinal = dtpFechaFinal.Value.Year + "-" + dtpFechaFinal.Value.Month + "-" + dtpFechaFinal.Value.Day;
            objEvento.CodCiudad = Convert.ToInt32(cboCiudad.SelectedValue);
            objEvento.Estado = cboEstado.Text;
            objEvento.CodDocente = Convert.ToString(cboDocente.SelectedValue);
        }

        private void MostrarDatos()
        {
            txtNombres.Text = objEvento.Nombre;
            cboModalidad.SelectedValue = objEvento.CodModalidad;
            txtCargaHoraria.Text = objEvento.CargaHoraria.ToString();
            dtpFechaInicio.Text = objEvento.FechaInicio;
            dtpFechaFinal.Text = objEvento.FechaFinal;
            cboCiudad.SelectedValue = objEvento.CodCiudad;
            cboEstado.Text = objEvento.Estado;
            cboDocente.SelectedValue = objEvento.CodDocente;
        }

        private void dgvListado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvListado.Rows.Count - 1)
            {
                String codigo = dgvListado.Rows[e.RowIndex].Cells[0].Value.ToString();
                objEvento = objLogicaNegocio.ObtenerRegistro(codigo);
                DeshabilitarBtnNuevo();
                HabilitarBtnModificar();
                HabilitarBtnEliminar();
                MostrarDatos();
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
