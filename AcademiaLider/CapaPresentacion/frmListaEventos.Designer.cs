namespace AcademiaLider.CapaPresentacion
{
    partial class frmListaEventos
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
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCriterioBusqueda = new System.Windows.Forms.TextBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Location = new System.Drawing.Point(657, 11);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 32;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Buscar por";
            // 
            // txtCriterioBusqueda
            // 
            this.txtCriterioBusqueda.Location = new System.Drawing.Point(82, 13);
            this.txtCriterioBusqueda.Name = "txtCriterioBusqueda";
            this.txtCriterioBusqueda.Size = new System.Drawing.Size(206, 20);
            this.txtCriterioBusqueda.TabIndex = 30;
            this.txtCriterioBusqueda.TextChanged += new System.EventHandler(this.txtCriterioBusqueda_TextChanged);
            // 
            // dgvListado
            // 
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 40);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(720, 369);
            this.dgvListado.TabIndex = 29;
            this.dgvListado.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListado_RowHeaderMouseDoubleClick);
            // 
            // frmListaEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 420);
            this.ControlBox = false;
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCriterioBusqueda);
            this.Controls.Add(this.dgvListado);
            this.Name = "frmListaEventos";
            this.Text = "frmListaEventos";
            this.Load += new System.EventHandler(this.frmListaEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCriterioBusqueda;
        private System.Windows.Forms.DataGridView dgvListado;
    }
}