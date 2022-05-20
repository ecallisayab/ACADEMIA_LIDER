namespace AcademiaLider.CapaPresentacion
{
    partial class frmPrincipal
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogotipo = new System.Windows.Forms.Panel();
            this.btnMenuParticipante = new System.Windows.Forms.Button();
            this.btnMenuDocente = new System.Windows.Forms.Button();
            this.btnMenuEvento = new System.Windows.Forms.Button();
            this.btnMenuInscripcion = new System.Windows.Forms.Button();
            this.btnMenuCertificado = new System.Windows.Forms.Button();
            this.panelCertificados = new System.Windows.Forms.Panel();
            this.btnSubmenuImpParticipante = new System.Windows.Forms.Button();
            this.btnSubmenuImpEvento = new System.Windows.Forms.Button();
            this.btnMenuCatalogo = new System.Windows.Forms.Button();
            this.panelCatalogos = new System.Windows.Forms.Panel();
            this.btnSubmenuGradoAcademico = new System.Windows.Forms.Button();
            this.btnSubmenuProfesion = new System.Windows.Forms.Button();
            this.btnSubmenuCiudad = new System.Windows.Forms.Button();
            this.btnSubmenuModalidad = new System.Windows.Forms.Button();
            this.btnMenuUsuario = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelCertificados.SuspendLayout();
            this.panelCatalogos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelMenu.Controls.Add(this.btnMenuUsuario);
            this.panelMenu.Controls.Add(this.panelCatalogos);
            this.panelMenu.Controls.Add(this.btnMenuCatalogo);
            this.panelMenu.Controls.Add(this.panelCertificados);
            this.panelMenu.Controls.Add(this.btnMenuCertificado);
            this.panelMenu.Controls.Add(this.btnMenuInscripcion);
            this.panelMenu.Controls.Add(this.btnMenuEvento);
            this.panelMenu.Controls.Add(this.btnMenuDocente);
            this.panelMenu.Controls.Add(this.btnMenuParticipante);
            this.panelMenu.Controls.Add(this.panelLogotipo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 661);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogotipo
            // 
            this.panelLogotipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogotipo.Location = new System.Drawing.Point(0, 0);
            this.panelLogotipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogotipo.Name = "panelLogotipo";
            this.panelLogotipo.Size = new System.Drawing.Size(233, 96);
            this.panelLogotipo.TabIndex = 1;
            // 
            // btnMenuParticipante
            // 
            this.btnMenuParticipante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuParticipante.FlatAppearance.BorderSize = 0;
            this.btnMenuParticipante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMenuParticipante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.btnMenuParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuParticipante.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuParticipante.Location = new System.Drawing.Point(0, 96);
            this.btnMenuParticipante.Name = "btnMenuParticipante";
            this.btnMenuParticipante.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuParticipante.Size = new System.Drawing.Size(233, 45);
            this.btnMenuParticipante.TabIndex = 2;
            this.btnMenuParticipante.Text = "Participantes";
            this.btnMenuParticipante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuParticipante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuParticipante.UseVisualStyleBackColor = true;
            this.btnMenuParticipante.Click += new System.EventHandler(this.btnMenuParticipante_Click);
            // 
            // btnMenuDocente
            // 
            this.btnMenuDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuDocente.FlatAppearance.BorderSize = 0;
            this.btnMenuDocente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMenuDocente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.btnMenuDocente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuDocente.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuDocente.Location = new System.Drawing.Point(0, 141);
            this.btnMenuDocente.Name = "btnMenuDocente";
            this.btnMenuDocente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuDocente.Size = new System.Drawing.Size(233, 45);
            this.btnMenuDocente.TabIndex = 3;
            this.btnMenuDocente.Text = "Docentes";
            this.btnMenuDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuDocente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuDocente.UseVisualStyleBackColor = true;
            this.btnMenuDocente.Click += new System.EventHandler(this.btnMenuDocente_Click);
            // 
            // btnMenuEvento
            // 
            this.btnMenuEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuEvento.FlatAppearance.BorderSize = 0;
            this.btnMenuEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMenuEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.btnMenuEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuEvento.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuEvento.Location = new System.Drawing.Point(0, 186);
            this.btnMenuEvento.Name = "btnMenuEvento";
            this.btnMenuEvento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuEvento.Size = new System.Drawing.Size(233, 45);
            this.btnMenuEvento.TabIndex = 4;
            this.btnMenuEvento.Text = "Eventos";
            this.btnMenuEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuEvento.UseVisualStyleBackColor = true;
            this.btnMenuEvento.Click += new System.EventHandler(this.btnMenuEvento_Click);
            // 
            // btnMenuInscripcion
            // 
            this.btnMenuInscripcion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuInscripcion.FlatAppearance.BorderSize = 0;
            this.btnMenuInscripcion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMenuInscripcion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.btnMenuInscripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInscripcion.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuInscripcion.Location = new System.Drawing.Point(0, 231);
            this.btnMenuInscripcion.Name = "btnMenuInscripcion";
            this.btnMenuInscripcion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuInscripcion.Size = new System.Drawing.Size(233, 45);
            this.btnMenuInscripcion.TabIndex = 6;
            this.btnMenuInscripcion.Text = "Inscripción";
            this.btnMenuInscripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuInscripcion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuInscripcion.UseVisualStyleBackColor = true;
            this.btnMenuInscripcion.Click += new System.EventHandler(this.btnMenuInscripcion_Click);
            // 
            // btnMenuCertificado
            // 
            this.btnMenuCertificado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCertificado.FlatAppearance.BorderSize = 0;
            this.btnMenuCertificado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMenuCertificado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.btnMenuCertificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCertificado.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuCertificado.Location = new System.Drawing.Point(0, 276);
            this.btnMenuCertificado.Name = "btnMenuCertificado";
            this.btnMenuCertificado.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuCertificado.Size = new System.Drawing.Size(233, 45);
            this.btnMenuCertificado.TabIndex = 7;
            this.btnMenuCertificado.Text = "Certificados";
            this.btnMenuCertificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCertificado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuCertificado.UseVisualStyleBackColor = true;
            this.btnMenuCertificado.Click += new System.EventHandler(this.btnMenuCertificado_Click);
            // 
            // panelCertificados
            // 
            this.panelCertificados.AutoSize = true;
            this.panelCertificados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelCertificados.Controls.Add(this.btnSubmenuImpEvento);
            this.panelCertificados.Controls.Add(this.btnSubmenuImpParticipante);
            this.panelCertificados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCertificados.Location = new System.Drawing.Point(0, 321);
            this.panelCertificados.Name = "panelCertificados";
            this.panelCertificados.Size = new System.Drawing.Size(233, 90);
            this.panelCertificados.TabIndex = 8;
            // 
            // btnSubmenuImpParticipante
            // 
            this.btnSubmenuImpParticipante.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmenuImpParticipante.FlatAppearance.BorderSize = 0;
            this.btnSubmenuImpParticipante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.btnSubmenuImpParticipante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnSubmenuImpParticipante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmenuImpParticipante.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubmenuImpParticipante.Location = new System.Drawing.Point(0, 0);
            this.btnSubmenuImpParticipante.Name = "btnSubmenuImpParticipante";
            this.btnSubmenuImpParticipante.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubmenuImpParticipante.Size = new System.Drawing.Size(233, 45);
            this.btnSubmenuImpParticipante.TabIndex = 8;
            this.btnSubmenuImpParticipante.Text = ">  Impresión por participante";
            this.btnSubmenuImpParticipante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmenuImpParticipante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmenuImpParticipante.UseVisualStyleBackColor = true;
            this.btnSubmenuImpParticipante.Click += new System.EventHandler(this.btnSubmenuImpParticipante_Click);
            // 
            // btnSubmenuImpEvento
            // 
            this.btnSubmenuImpEvento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmenuImpEvento.FlatAppearance.BorderSize = 0;
            this.btnSubmenuImpEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.btnSubmenuImpEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnSubmenuImpEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmenuImpEvento.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubmenuImpEvento.Location = new System.Drawing.Point(0, 45);
            this.btnSubmenuImpEvento.Name = "btnSubmenuImpEvento";
            this.btnSubmenuImpEvento.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubmenuImpEvento.Size = new System.Drawing.Size(233, 45);
            this.btnSubmenuImpEvento.TabIndex = 9;
            this.btnSubmenuImpEvento.Text = ">  Impresión por evento";
            this.btnSubmenuImpEvento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmenuImpEvento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmenuImpEvento.UseVisualStyleBackColor = true;
            this.btnSubmenuImpEvento.Click += new System.EventHandler(this.btnSubmenuImpEvento_Click);
            // 
            // btnMenuCatalogo
            // 
            this.btnMenuCatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCatalogo.FlatAppearance.BorderSize = 0;
            this.btnMenuCatalogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMenuCatalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.btnMenuCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCatalogo.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuCatalogo.Location = new System.Drawing.Point(0, 411);
            this.btnMenuCatalogo.Name = "btnMenuCatalogo";
            this.btnMenuCatalogo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuCatalogo.Size = new System.Drawing.Size(233, 45);
            this.btnMenuCatalogo.TabIndex = 9;
            this.btnMenuCatalogo.Text = "Catálogos";
            this.btnMenuCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuCatalogo.UseVisualStyleBackColor = true;
            this.btnMenuCatalogo.Click += new System.EventHandler(this.btnMenuCatalogo_Click);
            // 
            // panelCatalogos
            // 
            this.panelCatalogos.AutoSize = true;
            this.panelCatalogos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(61)))));
            this.panelCatalogos.Controls.Add(this.btnSubmenuModalidad);
            this.panelCatalogos.Controls.Add(this.btnSubmenuCiudad);
            this.panelCatalogos.Controls.Add(this.btnSubmenuGradoAcademico);
            this.panelCatalogos.Controls.Add(this.btnSubmenuProfesion);
            this.panelCatalogos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCatalogos.Location = new System.Drawing.Point(0, 456);
            this.panelCatalogos.Name = "panelCatalogos";
            this.panelCatalogos.Size = new System.Drawing.Size(233, 180);
            this.panelCatalogos.TabIndex = 10;
            // 
            // btnSubmenuGradoAcademico
            // 
            this.btnSubmenuGradoAcademico.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmenuGradoAcademico.FlatAppearance.BorderSize = 0;
            this.btnSubmenuGradoAcademico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.btnSubmenuGradoAcademico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnSubmenuGradoAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmenuGradoAcademico.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubmenuGradoAcademico.Location = new System.Drawing.Point(0, 45);
            this.btnSubmenuGradoAcademico.Name = "btnSubmenuGradoAcademico";
            this.btnSubmenuGradoAcademico.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubmenuGradoAcademico.Size = new System.Drawing.Size(233, 45);
            this.btnSubmenuGradoAcademico.TabIndex = 9;
            this.btnSubmenuGradoAcademico.Text = ">  Grados académicos";
            this.btnSubmenuGradoAcademico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmenuGradoAcademico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmenuGradoAcademico.UseVisualStyleBackColor = true;
            this.btnSubmenuGradoAcademico.Click += new System.EventHandler(this.btnSubmenuGradoAcademico_Click);
            // 
            // btnSubmenuProfesion
            // 
            this.btnSubmenuProfesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmenuProfesion.FlatAppearance.BorderSize = 0;
            this.btnSubmenuProfesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.btnSubmenuProfesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnSubmenuProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmenuProfesion.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubmenuProfesion.Location = new System.Drawing.Point(0, 0);
            this.btnSubmenuProfesion.Name = "btnSubmenuProfesion";
            this.btnSubmenuProfesion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubmenuProfesion.Size = new System.Drawing.Size(233, 45);
            this.btnSubmenuProfesion.TabIndex = 8;
            this.btnSubmenuProfesion.Text = ">  Profesiones";
            this.btnSubmenuProfesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmenuProfesion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmenuProfesion.UseVisualStyleBackColor = true;
            this.btnSubmenuProfesion.Click += new System.EventHandler(this.btnSubmenuProfesion_Click);
            // 
            // btnSubmenuCiudad
            // 
            this.btnSubmenuCiudad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmenuCiudad.FlatAppearance.BorderSize = 0;
            this.btnSubmenuCiudad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.btnSubmenuCiudad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnSubmenuCiudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmenuCiudad.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubmenuCiudad.Location = new System.Drawing.Point(0, 90);
            this.btnSubmenuCiudad.Name = "btnSubmenuCiudad";
            this.btnSubmenuCiudad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubmenuCiudad.Size = new System.Drawing.Size(233, 45);
            this.btnSubmenuCiudad.TabIndex = 10;
            this.btnSubmenuCiudad.Text = ">  Ciudades";
            this.btnSubmenuCiudad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmenuCiudad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmenuCiudad.UseVisualStyleBackColor = true;
            this.btnSubmenuCiudad.Click += new System.EventHandler(this.btnSubmenuCiudad_Click);
            // 
            // btnSubmenuModalidad
            // 
            this.btnSubmenuModalidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmenuModalidad.FlatAppearance.BorderSize = 0;
            this.btnSubmenuModalidad.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(32)))), ((int)(((byte)(49)))));
            this.btnSubmenuModalidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(43)))), ((int)(((byte)(66)))));
            this.btnSubmenuModalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmenuModalidad.ForeColor = System.Drawing.Color.LightGray;
            this.btnSubmenuModalidad.Location = new System.Drawing.Point(0, 135);
            this.btnSubmenuModalidad.Name = "btnSubmenuModalidad";
            this.btnSubmenuModalidad.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubmenuModalidad.Size = new System.Drawing.Size(233, 45);
            this.btnSubmenuModalidad.TabIndex = 11;
            this.btnSubmenuModalidad.Text = ">  Modalidades";
            this.btnSubmenuModalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmenuModalidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSubmenuModalidad.UseVisualStyleBackColor = true;
            this.btnSubmenuModalidad.Click += new System.EventHandler(this.btnSubmenuModalidad_Click);
            // 
            // btnMenuUsuario
            // 
            this.btnMenuUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuUsuario.FlatAppearance.BorderSize = 0;
            this.btnMenuUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnMenuUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(40)))));
            this.btnMenuUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuUsuario.ForeColor = System.Drawing.Color.LightGray;
            this.btnMenuUsuario.Location = new System.Drawing.Point(0, 636);
            this.btnMenuUsuario.Name = "btnMenuUsuario";
            this.btnMenuUsuario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuUsuario.Size = new System.Drawing.Size(233, 45);
            this.btnMenuUsuario.TabIndex = 11;
            this.btnMenuUsuario.Text = "Usuarios";
            this.btnMenuUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuUsuario.UseVisualStyleBackColor = true;
            this.btnMenuUsuario.Click += new System.EventHandler(this.btnMenuUsuario_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(694, 661);
            this.panelContenedor.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 661);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instituto de Capacitación Líder";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelCertificados.ResumeLayout(false);
            this.panelCatalogos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogotipo;
        private System.Windows.Forms.Button btnMenuParticipante;
        private System.Windows.Forms.Button btnMenuEvento;
        private System.Windows.Forms.Button btnMenuDocente;
        private System.Windows.Forms.Button btnMenuInscripcion;
        private System.Windows.Forms.Button btnMenuCertificado;
        private System.Windows.Forms.Panel panelCertificados;
        private System.Windows.Forms.Button btnSubmenuImpEvento;
        private System.Windows.Forms.Button btnSubmenuImpParticipante;
        private System.Windows.Forms.Button btnMenuCatalogo;
        private System.Windows.Forms.Panel panelCatalogos;
        private System.Windows.Forms.Button btnSubmenuModalidad;
        private System.Windows.Forms.Button btnSubmenuCiudad;
        private System.Windows.Forms.Button btnSubmenuGradoAcademico;
        private System.Windows.Forms.Button btnSubmenuProfesion;
        private System.Windows.Forms.Button btnMenuUsuario;
        private System.Windows.Forms.Panel panelContenedor;
    }
}