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
    public partial class frmInscripcion : Form
    {
        private ClnInscripcion objLogicaNegocio = new ClnInscripcion();
        private Inscripcion objInscripcion = new Inscripcion();
        private frmListaParticipantes viewParticipante = null;
        private frmListaEventos viewEvento = null;

        public frmInscripcion()
        {
            InitializeComponent();
        }

        private void frmInscripcion_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
            Listar();
            Limpiar();
        }

        private void Limpiar()
        {
            txtParticipante.Text = "";
            txtEvento.Text = "";
            dtpFecha.Text = "";
            txtNota.Text = "";
        }

        private void Inicializar()
        {
            objInscripcion.Codigo = 0;
            objInscripcion.CodParticipante = "";
            objInscripcion.CodEvento = "";
            objInscripcion.Fecha = "";
            objInscripcion.Nota = 0;
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

        private void Listar()
        {
            dgvListado.DataSource = objLogicaNegocio.ListarRegistros();
        }

        private void CargarDatos()
        {
            objInscripcion.Fecha = dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" + dtpFecha.Value.Day;
            objInscripcion.Nota = !txtNota.Text.Equals("") ? Convert.ToInt32(txtNota.Text) : 0;
        }

        private void MostrarDatos()
        {
            txtParticipante.Text = objInscripcion.NombreParticipante;
            txtEvento.Text = objInscripcion.NombreEvento;
            dtpFecha.Text = objInscripcion.Fecha;
            txtNota.Text = objInscripcion.Nota.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            objLogicaNegocio.VerificarDuplicidadRegistro(objInscripcion.CodParticipante, objInscripcion.CodEvento);
            if (objLogicaNegocio.Estado == false)
            {
                DeshabilitarBtnNuevo();
                //Inicializar();
                CargarDatos();
                objLogicaNegocio.CrearRegistro(objInscripcion);
                if (objLogicaNegocio.Estado)
                {
                    Limpiar();
                    Inicializar();
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
            else
            {
                MessageBox.Show(objLogicaNegocio.Mensaje);
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
            CargarDatos();
            objLogicaNegocio.ModificarRegistro(objInscripcion);
            if (objLogicaNegocio.Estado)
            {
                Limpiar();
                Inicializar();
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
            objLogicaNegocio.EliminarRegistro(objInscripcion.Codigo);
            if (objLogicaNegocio.Estado)
            {
                Limpiar();
                Inicializar();
                HabilitarBtnNuevo();
                Listar();
                lblMensaje.Text = objLogicaNegocio.Mensaje;
                //MessageBox.Show(objLogicaNegocio.Mensaje);
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

        private void btnBuscarParticipante_Click(object sender, EventArgs e)
        {
            if (viewParticipante == null)
            {
                viewParticipante = new frmListaParticipantes();
            }
            viewParticipante.ShowDialog();
            MostrarPartipante();
        }

        public void MostrarPartipante()
        {
            objInscripcion.CodParticipante = viewParticipante.Codigo;
            objInscripcion.NombreParticipante = viewParticipante.Nombre;
            txtParticipante.Text = viewParticipante.Nombre;
        }

        private void btnBuscarEvento_Click(object sender, EventArgs e)
        {
            if (viewEvento == null)
            {
                viewEvento = new frmListaEventos();
            }
            viewEvento.ShowDialog();
            MostrarEvento();
        }

        public void MostrarEvento()
        {
            objInscripcion.CodEvento = viewEvento.Codigo;
            objInscripcion.NombreEvento = viewEvento.Nombre;
            txtEvento.Text = viewEvento.Nombre;
        }

        private void txtCriterioBusqueda_TextChanged(object sender, EventArgs e)
        {
            String criterio = txtCriterioBusqueda.Text;
            dgvListado.DataSource = objLogicaNegocio.BuscarRegistros(criterio);
        }

        private void dgvListado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvListado.Rows.Count - 1)
            {
                int codigo = Convert.ToInt32(dgvListado.Rows[e.RowIndex].Cells[0].Value);
                objInscripcion = objLogicaNegocio.ObtenerRegistro(codigo);
                DeshabilitarBtnNuevo();
                HabilitarBtnModificar();
                HabilitarBtnEliminar();
                MostrarDatos();
            }
        }
    }
}
