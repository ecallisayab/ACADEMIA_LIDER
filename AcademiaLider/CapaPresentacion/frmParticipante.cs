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
using System.IO;
using System.Drawing.Imaging;

namespace AcademiaLider.CapaPresentacion
{
    public partial class frmParticipante : Form
    {
        private ClnParticipante objLogicaNegocio = new ClnParticipante();
        private Participante objParticipante = new Participante();

        public frmParticipante()
        {
            InitializeComponent();
        }

        private void frmParticipante_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DeshabilitarBtnModificar();
            DeshabilitarBtnEliminar();
            CargarGradosAcademicos();
            CargarProfesioness();
            CargarCiudades();
            Listar();
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombres.Text = "";
            txtApPaterno.Text = "";
            txtApMaterno.Text = "";
            txtCi.Text = "";
            dtpFechaNac.Text = "";
            if (cboCiudad.Items.Count > 0)
            {
                cboCiudad.SelectedIndex = 0;
            }else
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
            txtTelefono.Text = "0";
            LimpiarFoto();
        }

        private void Inicializar()
        {
            objParticipante = new Participante();

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
            objParticipante.Nombres = txtNombres.Text;
            objParticipante.ApPaterno = txtApPaterno.Text;
            objParticipante.ApMaterno = txtApMaterno.Text;
            objParticipante.Ci = txtCi.Text;
            objParticipante.FechaNac = dtpFechaNac.Value.Year + "-" + dtpFechaNac.Value.Month + "-" + dtpFechaNac.Value.Day;
            objParticipante.CodProfesion = Convert.ToInt32(cboProfesion.SelectedValue);
            objParticipante.CodGrado = Convert.ToInt32(cboGradoAcademico.SelectedValue);
            objParticipante.CodCiudad = Convert.ToInt32(cboCiudad.SelectedValue);
            objParticipante.Correo = txtCorreo.Text;
            objParticipante.Telefono = txtTelefono.Text.Equals("") ? 0 : Convert.ToInt32(txtTelefono.Text);
            if (pbFoto.Image != null)
            {
                MemoryStream  ms = new MemoryStream();
                pbFoto.Image.Save(ms, ImageFormat.Jpeg);
                byte[] cadenaFoto = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(cadenaFoto, 0, cadenaFoto.Length);
                objParticipante.Foto = cadenaFoto;
            }
        }

        private void MostrarDatos()
        {
            txtNombres.Text = objParticipante.Nombres;
            txtApPaterno.Text = objParticipante.ApPaterno;
            txtApMaterno.Text = objParticipante.ApMaterno;
            txtCi.Text = objParticipante.Ci;
            dtpFechaNac.Text = objParticipante.FechaNac;
            cboCiudad.SelectedValue = objParticipante.CodCiudad;
            cboProfesion.SelectedValue = objParticipante.CodProfesion;
            cboGradoAcademico.SelectedValue = objParticipante.CodGrado;
            txtCorreo.Text = objParticipante.Correo;
            txtTelefono.Text = objParticipante.Telefono.ToString();
            if (objParticipante.Foto != null)
            {
                MemoryStream ms = new MemoryStream(objParticipante.Foto);
                MostrarFoto(new Bitmap(Image.FromStream(ms)));
            }
            else
            {
                LimpiarFoto();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DeshabilitarBtnNuevo();
            Inicializar();
            CargarDatos();
            objLogicaNegocio.CrearRegistro(objParticipante);
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
            objLogicaNegocio.ModificarRegistro(objParticipante);
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
            objLogicaNegocio.EliminarRegistro(objParticipante.Codigo);
            if (objLogicaNegocio.Estado)
            {
                Limpiar();
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

        private void dgvListado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvListado.Rows.Count - 1)
            {
                String codigo = dgvListado.Rows[e.RowIndex].Cells[0].Value.ToString();
                objParticipante = objLogicaNegocio.ObtenerRegistro(codigo);
                DeshabilitarBtnNuevo();
                HabilitarBtnModificar();
                HabilitarBtnEliminar();
                MostrarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String criterio = txtCriterioBusqueda.Text;
            dgvListado.DataSource = objLogicaNegocio.BuscarRegistros(criterio);
        }

        private void txtCriterioBusqueda_TextChanged(object sender, EventArgs e)
        {
            String criterio = txtCriterioBusqueda.Text;
            dgvListado.DataSource = objLogicaNegocio.BuscarRegistros(criterio);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pbFoto_Click(object sender, EventArgs e)
        {
            
        }

        private void pbFoto_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                Bitmap imagen = RedimensionarImagen(new Bitmap(archivo.FileName), new Size(pbFoto.Width, pbFoto.Height));
                MostrarFoto(imagen);
            }
        }

        private Bitmap RedimensionarImagen(Bitmap imagen, Size marco)
        {
            Double ratioAlto = (Double)marco.Height / (Double)imagen.Height;
            int alto = (int)(imagen.Height * ratioAlto);
            int ancho = (int)(imagen.Width * ratioAlto);
            return new Bitmap(imagen, new Size(ancho, alto));
        }

        private void MostrarFoto(Bitmap imagen)
        {
            pbFoto.Image = imagen;
            pbFoto.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void LimpiarFoto()
        {
            pbFoto.Image = null;
        }

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
