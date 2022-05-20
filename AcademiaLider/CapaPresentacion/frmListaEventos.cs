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

namespace AcademiaLider.CapaPresentacion
{
    public partial class frmListaEventos : Form
    {
        private ClnEvento objCapaLogica = new ClnEvento();
        private String codigo;
        private String nombre;

        public frmListaEventos()
        {
            InitializeComponent();
        }

        private void frmListaEventos_Load(object sender, EventArgs e)
        {
            Limpiar();
            Listar();
        }

        public String Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private void Limpiar()
        {
            txtCriterioBusqueda.Text = "";
            codigo = "0";
            nombre = "";
        }

        private void Listar()
        {
            dgvListado.DataSource = objCapaLogica.ListarRegistros();
        }

        private void Buscar(String criterio)
        {
            dgvListado.DataSource = objCapaLogica.BuscarRegistros(criterio);
        }

        private void Cerrar()
        {
            this.Hide();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void txtCriterioBusqueda_TextChanged(object sender, EventArgs e)
        {
            String criterio = txtCriterioBusqueda.Text;
            if (criterio.Equals(""))
            {
                Listar();
            }
            else
            {
                Buscar(criterio);
            }
        }

        private void dgvListado_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dgvListado.Rows.Count - 1)
            {
                codigo = dgvListado.Rows[e.RowIndex].Cells[0].Value.ToString();
                nombre = dgvListado.Rows[e.RowIndex].Cells[1].Value.ToString();
                Cerrar();
            }
        }
    }
}
