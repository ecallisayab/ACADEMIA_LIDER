namespace AcademiaLider.CapaPresentacion
{
    partial class frmCertificado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCabecera = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlPie = new System.Windows.Forms.Panel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlListado = new System.Windows.Forms.Panel();
            this.txtCriterioBusqueda = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.pnlPrevisualizacion = new System.Windows.Forms.Panel();
            this.lblTextoEvento = new System.Windows.Forms.Label();
            this.lblTextoParticipante = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnZoomInc = new System.Windows.Forms.Button();
            this.pbCertificado = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printCertificado = new System.Drawing.Printing.PrintDocument();
            this.pnlCabecera.SuspendLayout();
            this.pnlPie.SuspendLayout();
            this.pnlListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.pnlPrevisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCertificado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCabecera
            // 
            this.pnlCabecera.Controls.Add(this.lblTitulo);
            this.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCabecera.Location = new System.Drawing.Point(0, 0);
            this.pnlCabecera.Name = "pnlCabecera";
            this.pnlCabecera.Size = new System.Drawing.Size(984, 40);
            this.pnlCabecera.TabIndex = 73;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(11, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(105, 20);
            this.lblTitulo.TabIndex = 66;
            this.lblTitulo.Text = "Certificados";
            // 
            // pnlPie
            // 
            this.pnlPie.Controls.Add(this.lblMensaje);
            this.pnlPie.Controls.Add(this.label12);
            this.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPie.Location = new System.Drawing.Point(0, 573);
            this.pnlPie.Name = "pnlPie";
            this.pnlPie.Size = new System.Drawing.Size(984, 38);
            this.pnlPie.TabIndex = 75;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(68, 11);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 13);
            this.lblMensaje.TabIndex = 70;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 69;
            this.label12.Text = "Mensaje:";
            // 
            // pnlListado
            // 
            this.pnlListado.Controls.Add(this.txtCriterioBusqueda);
            this.pnlListado.Controls.Add(this.label1);
            this.pnlListado.Controls.Add(this.dgvListado);
            this.pnlListado.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlListado.Location = new System.Drawing.Point(0, 40);
            this.pnlListado.Name = "pnlListado";
            this.pnlListado.Size = new System.Drawing.Size(572, 533);
            this.pnlListado.TabIndex = 76;
            // 
            // txtCriterioBusqueda
            // 
            this.txtCriterioBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCriterioBusqueda.Location = new System.Drawing.Point(76, 11);
            this.txtCriterioBusqueda.Name = "txtCriterioBusqueda";
            this.txtCriterioBusqueda.Size = new System.Drawing.Size(347, 20);
            this.txtCriterioBusqueda.TabIndex = 78;
            this.txtCriterioBusqueda.TextChanged += new System.EventHandler(this.txtCriterioBusqueda_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Buscar por";
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(15, 45);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(600, 482);
            this.dgvListado.TabIndex = 76;
            this.dgvListado.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListado_RowHeaderMouseDoubleClick);
            // 
            // pnlPrevisualizacion
            // 
            this.pnlPrevisualizacion.AutoSize = true;
            this.pnlPrevisualizacion.Controls.Add(this.btnImprimir);
            this.pnlPrevisualizacion.Controls.Add(this.lblTextoEvento);
            this.pnlPrevisualizacion.Controls.Add(this.lblTextoParticipante);
            this.pnlPrevisualizacion.Controls.Add(this.label3);
            this.pnlPrevisualizacion.Controls.Add(this.label2);
            this.pnlPrevisualizacion.Controls.Add(this.btnCancelar);
            this.pnlPrevisualizacion.Controls.Add(this.btnGenerar);
            this.pnlPrevisualizacion.Controls.Add(this.btnZoomInc);
            this.pnlPrevisualizacion.Controls.Add(this.pbCertificado);
            this.pnlPrevisualizacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrevisualizacion.Location = new System.Drawing.Point(572, 40);
            this.pnlPrevisualizacion.Name = "pnlPrevisualizacion";
            this.pnlPrevisualizacion.Size = new System.Drawing.Size(412, 533);
            this.pnlPrevisualizacion.TabIndex = 77;
            // 
            // lblTextoEvento
            // 
            this.lblTextoEvento.AutoSize = true;
            this.lblTextoEvento.Location = new System.Drawing.Point(75, 37);
            this.lblTextoEvento.Name = "lblTextoEvento";
            this.lblTextoEvento.Size = new System.Drawing.Size(16, 13);
            this.lblTextoEvento.TabIndex = 92;
            this.lblTextoEvento.Text = "...";
            // 
            // lblTextoParticipante
            // 
            this.lblTextoParticipante.AutoSize = true;
            this.lblTextoParticipante.Location = new System.Drawing.Point(75, 14);
            this.lblTextoParticipante.Name = "lblTextoParticipante";
            this.lblTextoParticipante.Size = new System.Drawing.Size(16, 13);
            this.lblTextoParticipante.TabIndex = 91;
            this.lblTextoParticipante.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 90;
            this.label3.Text = "Evento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Participante:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(313, 35);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 23);
            this.btnCancelar.TabIndex = 88;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerar.Location = new System.Drawing.Point(313, 6);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(87, 23);
            this.btnGenerar.TabIndex = 86;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnZoomInc
            // 
            this.btnZoomInc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomInc.Location = new System.Drawing.Point(200, 504);
            this.btnZoomInc.Name = "btnZoomInc";
            this.btnZoomInc.Size = new System.Drawing.Size(107, 23);
            this.btnZoomInc.TabIndex = 84;
            this.btnZoomInc.Text = "Ajustar imagen";
            this.btnZoomInc.UseVisualStyleBackColor = true;
            this.btnZoomInc.Click += new System.EventHandler(this.btnZoomInc_Click_1);
            // 
            // pbCertificado
            // 
            this.pbCertificado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCertificado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCertificado.Location = new System.Drawing.Point(6, 64);
            this.pbCertificado.Name = "pbCertificado";
            this.pbCertificado.Size = new System.Drawing.Size(394, 428);
            this.pbCertificado.TabIndex = 83;
            this.pbCertificado.TabStop = false;
            this.pbCertificado.Resize += new System.EventHandler(this.pbCertificado_Resize);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(313, 504);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(87, 23);
            this.btnImprimir.TabIndex = 93;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click_1);
            // 
            // printCertificado
            // 
            this.printCertificado.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCertificado_PrintPage);
            // 
            // frmCertificado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.ControlBox = false;
            this.Controls.Add(this.pnlPrevisualizacion);
            this.Controls.Add(this.pnlListado);
            this.Controls.Add(this.pnlPie);
            this.Controls.Add(this.pnlCabecera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCertificado";
            this.Text = "Certificados";
            this.Load += new System.EventHandler(this.frmCertificado_Load);
            this.pnlCabecera.ResumeLayout(false);
            this.pnlCabecera.PerformLayout();
            this.pnlPie.ResumeLayout(false);
            this.pnlPie.PerformLayout();
            this.pnlListado.ResumeLayout(false);
            this.pnlListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.pnlPrevisualizacion.ResumeLayout(false);
            this.pnlPrevisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCertificado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlCabecera;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlPie;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlListado;
        private System.Windows.Forms.TextBox txtCriterioBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Panel pnlPrevisualizacion;
        private System.Windows.Forms.Button btnZoomInc;
        private System.Windows.Forms.PictureBox pbCertificado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTextoEvento;
        private System.Windows.Forms.Label lblTextoParticipante;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printCertificado;
    }
}