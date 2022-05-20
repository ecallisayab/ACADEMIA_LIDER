using AcademiaLider.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AcademiaLider.Core;
using AcademiaLider.CapaLogicaNegocio;
using AcademiaLider.Entidades;
using System.Drawing.Printing;

namespace AcademiaLider.CapaPresentacion
{
    public partial class frmCertificado : Form
    {
        private ClnInscripcion objLogicaNegocio = new ClnInscripcion();
        private ClnParticipante objLogicaParticipante = new ClnParticipante();
        private Participante objParticipante = new Participante();

        private Bitmap imagenPlantilla;
        private Bitmap imagenQr;

        private String codigoCertificado;
        private String nombreParticipante;
        private String ciParticipante;
        private String nombreEvento;
        private String nota;
        private String fecha;
        private String cargaHoraria;

        public frmCertificado()
        {
            InitializeComponent();
            imagenPlantilla = null;
            imagenQr = null;
        }

        private void frmCertificado_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            DeshabilitarBtnImprimir();
            DeshabilitarBtnGenerar();
        }

        private void Limpiar()
        {
            txtCriterioBusqueda.Text = "";
            lblTextoParticipante.Text = "...";
            lblTextoEvento.Text = "...";
        }

        private void Inicializar()
        {
            codigoCertificado = "";
            nombreParticipante = "";
            ciParticipante = "";
            nombreEvento = "";
            nota = "";
            fecha = "";
            cargaHoraria = "";

            pbCertificado.Image = null;
            imagenPlantilla = null;
            imagenQr = null;
        }

        private void HabilitarBtnGenerar()
        {
            btnGenerar.Enabled = true;
        }

        private void DeshabilitarBtnGenerar()
        {
            btnGenerar.Enabled = false;
        }

        private void HabilitarBtnImprimir()
        {
            btnImprimir.Enabled = true;
        }

        private void DeshabilitarBtnImprimir()
        {
            btnImprimir.Enabled = false;
        }

        private void HabilitarListado()
        {
            dgvListado.Enabled = true;
        }

        private void DeshabilitarListado()
        {
            dgvListado.Enabled = false;
        }

        private void btnZoomInc_Click(object sender, EventArgs e)
        {
            
        }

        private void btnZoomInc_Click_1(object sender, EventArgs e)
        {
            AmpliarPanel(); 
        }

        private void btnZoomDec_Click(object sender, EventArgs e)
        {
            ReducirPanel();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            String texto = codigoCertificado+";"+nombreParticipante+";"+ciParticipante+";"+nombreEvento+";"+nota+";"+fecha;
            CargarPlantilla();
            GenerarCodigoQr(texto);
            GenerarCertificado();
            DeshabilitarBtnGenerar();
            HabilitarBtnImprimir();
        }

        private void CargarPlantilla()
        {
            if (imagenPlantilla == null)
            {
                imagenPlantilla = new Bitmap(Resources.plantilla);
            }
        }

        private void GenerarCodigoQr(String texto)
        {
            if (imagenQr == null)
            {
                Qr codigo = new Qr();
                imagenQr = codigo.GenerarImagen(texto);
            }
        }

        private void GenerarCertificado()
        {
            int mitad = imagenPlantilla.Width / 2;
            Double ratio = (double)pbCertificado.Height / (Double)imagenPlantilla.Height;
            int alto = (int)(imagenPlantilla.Height * ratio);
            int ancho = (int)(imagenPlantilla.Width * ratio);

            //Dibujo la imagen
            Graphics graphicsImage = Graphics.FromImage(imagenPlantilla);

            //Establezco la orientación mediante coordenadas  
            StringFormat stringformat = new StringFormat();
            stringformat.Alignment = StringAlignment.Center;
            stringformat.LineAlignment = StringAlignment.Center;

            StringFormat stringformat2 = new StringFormat();
            stringformat2.Alignment = StringAlignment.Center;
            stringformat2.LineAlignment = StringAlignment.Center;

            StringFormat stringformat3 = new StringFormat();
            stringformat3.Alignment = StringAlignment.Center;
            stringformat3.LineAlignment = StringAlignment.Center;

            //Propiedades de la fuente  
            Color StringColor = System.Drawing.ColorTranslator.FromHtml("#000000");
            Color StringColor2 = System.Drawing.ColorTranslator.FromHtml("#34495e");            
            string parrafo1 = "Por haber aprobado el Curso Taller en Linea de Especialización";
            string parrafo2 = "Realizado en la Universidad en fecha " + fecha;
            string parrafo3 = "con una carga horaria de " +cargaHoraria+ " horas académicas.";

            graphicsImage.DrawString(nombreParticipante, new System.Drawing.Font("arial", 60,
            FontStyle.Regular), new SolidBrush(StringColor), new Point(mitad, 1110),stringformat);
            //Response.ContentType = "image/jpeg";

            graphicsImage.DrawString(parrafo1, new System.Drawing.Font("arial", 36,
            FontStyle.Regular), new SolidBrush(StringColor), new Point(mitad, 1280),stringformat3);

            graphicsImage.DrawString(nombreEvento, new System.Drawing.Font("arial", 60,
            FontStyle.Bold), new SolidBrush(StringColor2), new Point(mitad, 1430),stringformat2);

            graphicsImage.DrawString(parrafo2, new System.Drawing.Font("arial", 36,
            FontStyle.Regular), new SolidBrush(StringColor), new Point(mitad, 1580),stringformat3);

            graphicsImage.DrawString(parrafo3, new System.Drawing.Font("arial", 36,
            FontStyle.Regular), new SolidBrush(StringColor), new Point(mitad, 1640),stringformat3);

            graphicsImage.DrawString("CÓDIGO: LC-00004", new System.Drawing.Font("arial", 24,
            FontStyle.Regular), new SolidBrush(StringColor), new Point(imagenPlantilla.Width-500, 385),stringformat3);

            if (!nota.Equals(""))
            {
                graphicsImage.DrawString("NOTA APROBACIÓN: " + nota + "/100", new System.Drawing.Font("arial", 24,
                FontStyle.Regular), new SolidBrush(StringColor), new Point(imagenPlantilla.Width - 500, 1010),stringformat3);
            }

            Double qrRatio = (Double)450 / (Double)imagenQr.Height;
            int altoQr = (int)(imagenQr.Height * qrRatio);
            int anchoQr = (int)(imagenQr.Width * qrRatio);

            graphicsImage.DrawImage(new Bitmap(imagenQr, new Size(anchoQr, altoQr)), new PointF(200, 1800));

            if (objParticipante.Foto != null)
            {
                MemoryStream ms = new MemoryStream(objParticipante.Foto);
                Bitmap foto = new Bitmap(Image.FromStream(ms));
                Double fotoRatio = (Double)510 / (Double)foto.Height;
                int altoFoto = (int)(foto.Height * fotoRatio);
                int anchoFoto = (int)(foto.Width * fotoRatio);

                graphicsImage.DrawImage(new Bitmap(Image.FromStream(ms), new Size(anchoFoto, altoFoto)), new PointF(imagenPlantilla.Width - 730, 430));
            }
            

            Bitmap imagen = RedimensionarImagen(imagenPlantilla, new Size(pbCertificado.Width, pbCertificado.Height));
            pbCertificado.Image = imagen;
            pbCertificado.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Inicializar();
            DeshabilitarBtnGenerar();
            DeshabilitarBtnImprimir();
            HabilitarListado();
        }

        private void AmpliarPanel(int tamano=50)
        {
            if (imagenPlantilla != null)
            {
                if (pnlCabecera.Height != imagenPlantilla.Height)
                {
                    pbCertificado.Image = RedimensionarImagen(imagenPlantilla, new Size(pbCertificado.Width, pbCertificado.Height));
                    int nuevoAncho = pbCertificado.Image.Width - pbCertificado.Width;
                    pnlListado.Width = pnlListado.Width - nuevoAncho;
                    pnlPrevisualizacion.Width = pnlPrevisualizacion.Width + nuevoAncho;
                }
            }
        }

        private void ReducirPanel(int tamano = 50)
        {
            if (imagenPlantilla != null)
            {
                Double ancho = pnlListado.Width;
                if (ancho < CalcularAncho(this.Width, 50))
                {
                    pnlPrevisualizacion.Width = pnlPrevisualizacion.Width - tamano;
                    pnlListado.Width = pnlListado.Width + tamano;
                }
                if (pnlCabecera.Width != imagenPlantilla.Height)
                {
                    pbCertificado.Image = RedimensionarImagen(imagenPlantilla, new Size(pbCertificado.Width, pbCertificado.Height));
                }
            }
        }

        private Double CalcularAncho(Double ancho, Double porcentaje)
        {
            return ancho * porcentaje / 100;
        }

        private Bitmap RedimensionarImagen(Bitmap imagen, Size contenedor)
        {
            Double ratio;
            ratio = (Double)contenedor.Height / (Double)imagen.Height;
            int ancho = (int)(imagen.Width * ratio);
            int alto = (int)(imagen.Height * ratio);
            return new Bitmap(imagen, new Size(ancho, alto));
        }

        private void txtCriterioBusqueda_TextChanged(object sender, EventArgs e)
        {
            String criterio = txtCriterioBusqueda.Text;
            if (!criterio.Equals(""))
            {
                DataTable tabla = objLogicaNegocio.BuscarRegistroInscritos(criterio);
                if (tabla != null)
                {
                    dgvListado.DataSource = tabla;
                }
            }
        }

        private void MostrarDatos()
        {
            lblTextoParticipante.Text = nombreParticipante;
            lblTextoEvento.Text = nombreEvento;
        }

        private void dgvListado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvListado.Rows.Count - 1)
            {
                String codigoParticipante = dgvListado.Rows[e.RowIndex].Cells[1].Value.ToString();
                nombreParticipante = dgvListado.Rows[e.RowIndex].Cells[2].Value.ToString();
                ciParticipante = dgvListado.Rows[e.RowIndex].Cells[3].Value.ToString();
                nombreEvento = dgvListado.Rows[e.RowIndex].Cells[5].Value.ToString();
                nota = dgvListado.Rows[e.RowIndex].Cells[6].Value.ToString();
                fecha = dgvListado.Rows[e.RowIndex].Cells[7].Value.ToString();
                cargaHoraria = dgvListado.Rows[e.RowIndex].Cells[8].Value.ToString();
                objParticipante = objLogicaParticipante.ObtenerRegistro(codigoParticipante);
                MostrarDatos();
                HabilitarBtnGenerar();
                DeshabilitarListado();
            }
        }

        private void pbCertificado_Resize(object sender, EventArgs e)
        {
            
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            int altoPapel = (int)(21.6 * 300 / 2.54);
            int anchoPapel = (int)(27.9 * 300 / 2.54);

            PrintDocument imprimirDocumento = new PrintDocument();
            imprimirDocumento.DefaultPageSettings.Landscape = true;
            PaperSize psize = new PaperSize("Custom", altoPapel, anchoPapel);
            imprimirDocumento.DefaultPageSettings.PaperSize = psize;
            PrintDialog dialogoImpresion = new PrintDialog();
            imprimirDocumento.PrintPage += new PrintPageEventHandler(printCertificado_PrintPage);
            dialogoImpresion.Document = imprimirDocumento;
            if (dialogoImpresion.ShowDialog() == DialogResult.OK)
            {
                imprimirDocumento.Print();
            }
        }

        private void printCertificado_PrintPage(object sender, PrintPageEventArgs e)
        {
            int altoPapel = (int)(21.6 / 2.54 * 96);
            int anchoPapel = (int)(27.9 / 2.54 * 96);
            e.Graphics.DrawImage(RedimensionarImagen(imagenPlantilla, new Size(anchoPapel, altoPapel)), 0, 0);
        }
    }
}
