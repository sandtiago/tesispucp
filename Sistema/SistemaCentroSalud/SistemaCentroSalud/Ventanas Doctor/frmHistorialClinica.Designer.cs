namespace SistemaCentroSalud.Ventanas_Doctor
{
    partial class frmHistorialClinica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorialClinica));
            this.tbcHistoriaClinica = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.dgvHistoriasClinicas = new System.Windows.Forms.DataGridView();
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.tbcHistoriaClinicaPartes = new System.Windows.Forms.TabControl();
            this.tbpEctoscopia = new System.Windows.Forms.TabPage();
            this.lblEctoscopiaActual = new System.Windows.Forms.Label();
            this.lblEctoscopiaAnterior = new System.Windows.Forms.Label();
            this.tbpAnamnesis = new System.Windows.Forms.TabPage();
            this.tbcAnamnesisPartes = new System.Windows.Forms.TabControl();
            this.tbpFiliacion = new System.Windows.Forms.TabPage();
            this.tbpEnfermedadActual = new System.Windows.Forms.TabPage();
            this.lblRelatoCronologico = new System.Windows.Forms.Label();
            this.lblSintomasEnfermedad = new System.Windows.Forms.Label();
            this.lblCursoEnfermedad = new System.Windows.Forms.Label();
            this.lblInicioEnfermedad = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTiempoEnfermedad = new System.Windows.Forms.Label();
            this.tbpAntecedentes = new System.Windows.Forms.TabPage();
            this.tbpExamenFisico = new System.Windows.Forms.TabPage();
            this.tbpDiagnostico = new System.Windows.Forms.TabPage();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblDescripcionActual = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.lblDiagnosticoAnterior = new System.Windows.Forms.Label();
            this.gbxPersonal = new System.Windows.Forms.GroupBox();
            this.cboEstadoCivil = new System.Windows.Forms.ComboBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.cboReligion = new System.Windows.Forms.ComboBox();
            this.lblReligion = new System.Windows.Forms.Label();
            this.cboRaza = new System.Windows.Forms.ComboBox();
            this.lblRaza = new System.Windows.Forms.Label();
            this.cboOcupacion = new System.Windows.Forms.ComboBox();
            this.lblOcupacion = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblMaterno = new System.Windows.Forms.Label();
            this.lblPaterno = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.gbxDomicilio = new System.Windows.Forms.GroupBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.cboDistritoDomicilio = new System.Windows.Forms.ComboBox();
            this.cboProvinciaDomicilio = new System.Windows.Forms.ComboBox();
            this.cboDepartamentoDomicilio = new System.Windows.Forms.ComboBox();
            this.lblDistritoDomicilio = new System.Windows.Forms.Label();
            this.lblProvinciaDomicilio = new System.Windows.Forms.Label();
            this.lblDepartamentoDomicilio = new System.Windows.Forms.Label();
            this.gbxLugarNacimiento = new System.Windows.Forms.GroupBox();
            this.cboDistrito = new System.Windows.Forms.ComboBox();
            this.cboProvincia = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDistrito = new System.Windows.Forms.Label();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cboPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblGrupoSanguineo = new System.Windows.Forms.Label();
            this.cboGrupoSanguineo = new System.Windows.Forms.ComboBox();
            this.cboFactorSanguineo = new System.Windows.Forms.ComboBox();
            this.lblFactorSanguineo = new System.Windows.Forms.Label();
            this.gbxSignosVitales = new System.Windows.Forms.GroupBox();
            this.gbxOtrosDatos = new System.Windows.Forms.GroupBox();
            this.lblOtrosExamenes = new System.Windows.Forms.Label();
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPulso = new System.Windows.Forms.Label();
            this.lblFrecuenciaRespiratoria = new System.Windows.Forms.Label();
            this.lblPresionArterial = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblTalla = new System.Windows.Forms.Label();
            this.rtxtEctoscopiaActual = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtEctoscopiaAnterior = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtDireccion = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtEdad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNombres = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtMaterno = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPaterno = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtRelatoCronologico = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.rtxtSintomasEnfermedad = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtCursoEnfermedad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtInicioEnfermedad = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtTiempoEnfermedad = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtOtrosExamenes = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtTalla = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPeso = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPresionArterial = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtFrecuenciaRespiratoria = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtPulso = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtFrecuenciaCardiaca = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtTemperatura = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtDiagnosticoActual = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.txtDiagnostico = new SistemaCentroSalud.Controles.cuTextBox();
            this.rtxtDiagnosticoAnterior = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.tbcHistoriaClinica.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).BeginInit();
            this.tbpDetalle.SuspendLayout();
            this.tbcHistoriaClinicaPartes.SuspendLayout();
            this.tbpEctoscopia.SuspendLayout();
            this.tbpAnamnesis.SuspendLayout();
            this.tbcAnamnesisPartes.SuspendLayout();
            this.tbpFiliacion.SuspendLayout();
            this.tbpEnfermedadActual.SuspendLayout();
            this.tbpExamenFisico.SuspendLayout();
            this.tbpDiagnostico.SuspendLayout();
            this.gbxPersonal.SuspendLayout();
            this.gbxDomicilio.SuspendLayout();
            this.gbxLugarNacimiento.SuspendLayout();
            this.gbxSignosVitales.SuspendLayout();
            this.gbxOtrosDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcHistoriaClinica
            // 
            this.tbcHistoriaClinica.Controls.Add(this.tbpBuscar);
            this.tbcHistoriaClinica.Controls.Add(this.tbpDetalle);
            this.tbcHistoriaClinica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcHistoriaClinica.Location = new System.Drawing.Point(0, 0);
            this.tbcHistoriaClinica.Name = "tbcHistoriaClinica";
            this.tbcHistoriaClinica.SelectedIndex = 0;
            this.tbcHistoriaClinica.Size = new System.Drawing.Size(820, 435);
            this.tbcHistoriaClinica.TabIndex = 0;
            this.tbcHistoriaClinica.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tbcHistoriaClinica_Selecting);
            this.tbcHistoriaClinica.SelectedIndexChanged += new System.EventHandler(this.tbcHistoriaClinica_SelectedIndexChanged);
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnSalir);
            this.tbpBuscar.Controls.Add(this.btnVer);
            this.tbpBuscar.Controls.Add(this.btnModificar);
            this.tbpBuscar.Controls.Add(this.btnNuevo);
            this.tbpBuscar.Controls.Add(this.gbxCriterios);
            this.tbpBuscar.Controls.Add(this.dgvHistoriasClinicas);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(812, 409);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(729, 380);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVer
            // 
            this.btnVer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(99, 380);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 14;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(190, 380);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(8, 380);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxCriterios.Location = new System.Drawing.Point(8, 6);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(796, 179);
            this.gbxCriterios.TabIndex = 1;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de Búsqueda";
            // 
            // dgvHistoriasClinicas
            // 
            this.dgvHistoriasClinicas.AllowUserToAddRows = false;
            this.dgvHistoriasClinicas.AllowUserToDeleteRows = false;
            this.dgvHistoriasClinicas.AllowUserToResizeColumns = false;
            this.dgvHistoriasClinicas.AllowUserToResizeRows = false;
            this.dgvHistoriasClinicas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHistoriasClinicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistoriasClinicas.Location = new System.Drawing.Point(8, 191);
            this.dgvHistoriasClinicas.MultiSelect = false;
            this.dgvHistoriasClinicas.Name = "dgvHistoriasClinicas";
            this.dgvHistoriasClinicas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistoriasClinicas.Size = new System.Drawing.Size(796, 184);
            this.dgvHistoriasClinicas.TabIndex = 0;
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.tbcHistoriaClinicaPartes);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(812, 409);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // tbcHistoriaClinicaPartes
            // 
            this.tbcHistoriaClinicaPartes.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpEctoscopia);
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpAnamnesis);
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpExamenFisico);
            this.tbcHistoriaClinicaPartes.Controls.Add(this.tbpDiagnostico);
            this.tbcHistoriaClinicaPartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcHistoriaClinicaPartes.Location = new System.Drawing.Point(3, 3);
            this.tbcHistoriaClinicaPartes.Multiline = true;
            this.tbcHistoriaClinicaPartes.Name = "tbcHistoriaClinicaPartes";
            this.tbcHistoriaClinicaPartes.SelectedIndex = 0;
            this.tbcHistoriaClinicaPartes.Size = new System.Drawing.Size(806, 403);
            this.tbcHistoriaClinicaPartes.TabIndex = 0;
            // 
            // tbpEctoscopia
            // 
            this.tbpEctoscopia.Controls.Add(this.rtxtEctoscopiaActual);
            this.tbpEctoscopia.Controls.Add(this.lblEctoscopiaActual);
            this.tbpEctoscopia.Controls.Add(this.rtxtEctoscopiaAnterior);
            this.tbpEctoscopia.Controls.Add(this.lblEctoscopiaAnterior);
            this.tbpEctoscopia.Location = new System.Drawing.Point(4, 4);
            this.tbpEctoscopia.Name = "tbpEctoscopia";
            this.tbpEctoscopia.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEctoscopia.Size = new System.Drawing.Size(779, 395);
            this.tbpEctoscopia.TabIndex = 0;
            this.tbpEctoscopia.Text = "Ectoscopia";
            this.tbpEctoscopia.UseVisualStyleBackColor = true;
            // 
            // lblEctoscopiaActual
            // 
            this.lblEctoscopiaActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblEctoscopiaActual.AutoSize = true;
            this.lblEctoscopiaActual.Location = new System.Drawing.Point(6, 200);
            this.lblEctoscopiaActual.Name = "lblEctoscopiaActual";
            this.lblEctoscopiaActual.Size = new System.Drawing.Size(40, 13);
            this.lblEctoscopiaActual.TabIndex = 2;
            this.lblEctoscopiaActual.Text = "Actual:";
            // 
            // lblEctoscopiaAnterior
            // 
            this.lblEctoscopiaAnterior.AutoSize = true;
            this.lblEctoscopiaAnterior.Location = new System.Drawing.Point(6, 3);
            this.lblEctoscopiaAnterior.Name = "lblEctoscopiaAnterior";
            this.lblEctoscopiaAnterior.Size = new System.Drawing.Size(46, 13);
            this.lblEctoscopiaAnterior.TabIndex = 0;
            this.lblEctoscopiaAnterior.Text = "Anterior:";
            // 
            // tbpAnamnesis
            // 
            this.tbpAnamnesis.Controls.Add(this.tbcAnamnesisPartes);
            this.tbpAnamnesis.Location = new System.Drawing.Point(4, 4);
            this.tbpAnamnesis.Name = "tbpAnamnesis";
            this.tbpAnamnesis.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAnamnesis.Size = new System.Drawing.Size(779, 395);
            this.tbpAnamnesis.TabIndex = 1;
            this.tbpAnamnesis.Text = "Anamnesis";
            this.tbpAnamnesis.UseVisualStyleBackColor = true;
            // 
            // tbcAnamnesisPartes
            // 
            this.tbcAnamnesisPartes.Controls.Add(this.tbpFiliacion);
            this.tbcAnamnesisPartes.Controls.Add(this.tbpEnfermedadActual);
            this.tbcAnamnesisPartes.Controls.Add(this.tbpAntecedentes);
            this.tbcAnamnesisPartes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcAnamnesisPartes.Location = new System.Drawing.Point(3, 3);
            this.tbcAnamnesisPartes.Name = "tbcAnamnesisPartes";
            this.tbcAnamnesisPartes.SelectedIndex = 0;
            this.tbcAnamnesisPartes.Size = new System.Drawing.Size(773, 389);
            this.tbcAnamnesisPartes.TabIndex = 0;
            // 
            // tbpFiliacion
            // 
            this.tbpFiliacion.Controls.Add(this.gbxDomicilio);
            this.tbpFiliacion.Controls.Add(this.gbxLugarNacimiento);
            this.tbpFiliacion.Controls.Add(this.gbxPersonal);
            this.tbpFiliacion.Location = new System.Drawing.Point(4, 22);
            this.tbpFiliacion.Name = "tbpFiliacion";
            this.tbpFiliacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpFiliacion.Size = new System.Drawing.Size(765, 363);
            this.tbpFiliacion.TabIndex = 0;
            this.tbpFiliacion.Text = "Filiación";
            this.tbpFiliacion.UseVisualStyleBackColor = true;
            // 
            // tbpEnfermedadActual
            // 
            this.tbpEnfermedadActual.Controls.Add(this.lblRelatoCronologico);
            this.tbpEnfermedadActual.Controls.Add(this.lblSintomasEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.lblCursoEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.lblInicioEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.lblDias);
            this.tbpEnfermedadActual.Controls.Add(this.lblTiempoEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.rtxtRelatoCronologico);
            this.tbpEnfermedadActual.Controls.Add(this.rtxtSintomasEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.txtCursoEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.txtInicioEnfermedad);
            this.tbpEnfermedadActual.Controls.Add(this.txtTiempoEnfermedad);
            this.tbpEnfermedadActual.Location = new System.Drawing.Point(4, 22);
            this.tbpEnfermedadActual.Name = "tbpEnfermedadActual";
            this.tbpEnfermedadActual.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEnfermedadActual.Size = new System.Drawing.Size(765, 363);
            this.tbpEnfermedadActual.TabIndex = 1;
            this.tbpEnfermedadActual.Text = "Enfermedad Actual";
            this.tbpEnfermedadActual.UseVisualStyleBackColor = true;
            // 
            // lblRelatoCronologico
            // 
            this.lblRelatoCronologico.AutoSize = true;
            this.lblRelatoCronologico.Location = new System.Drawing.Point(7, 277);
            this.lblRelatoCronologico.Name = "lblRelatoCronologico";
            this.lblRelatoCronologico.Size = new System.Drawing.Size(100, 13);
            this.lblRelatoCronologico.TabIndex = 10;
            this.lblRelatoCronologico.Text = "Relato Cronológico:";
            // 
            // lblSintomasEnfermedad
            // 
            this.lblSintomasEnfermedad.AutoSize = true;
            this.lblSintomasEnfermedad.Location = new System.Drawing.Point(7, 110);
            this.lblSintomasEnfermedad.Name = "lblSintomasEnfermedad";
            this.lblSintomasEnfermedad.Size = new System.Drawing.Size(184, 13);
            this.lblSintomasEnfermedad.TabIndex = 7;
            this.lblSintomasEnfermedad.Text = "Signos y Síntomas de la Enfermedad:";
            // 
            // lblCursoEnfermedad
            // 
            this.lblCursoEnfermedad.AutoSize = true;
            this.lblCursoEnfermedad.Location = new System.Drawing.Point(7, 75);
            this.lblCursoEnfermedad.Name = "lblCursoEnfermedad";
            this.lblCursoEnfermedad.Size = new System.Drawing.Size(123, 13);
            this.lblCursoEnfermedad.TabIndex = 6;
            this.lblCursoEnfermedad.Text = "Curso de la Enfermedad:";
            // 
            // lblInicioEnfermedad
            // 
            this.lblInicioEnfermedad.AutoSize = true;
            this.lblInicioEnfermedad.Location = new System.Drawing.Point(7, 40);
            this.lblInicioEnfermedad.Name = "lblInicioEnfermedad";
            this.lblInicioEnfermedad.Size = new System.Drawing.Size(121, 13);
            this.lblInicioEnfermedad.TabIndex = 3;
            this.lblInicioEnfermedad.Text = "Inicio de la Enfermedad:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(256, 6);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 2;
            this.lblDias.Text = "días";
            // 
            // lblTiempoEnfermedad
            // 
            this.lblTiempoEnfermedad.AutoSize = true;
            this.lblTiempoEnfermedad.Location = new System.Drawing.Point(7, 6);
            this.lblTiempoEnfermedad.Name = "lblTiempoEnfermedad";
            this.lblTiempoEnfermedad.Size = new System.Drawing.Size(120, 13);
            this.lblTiempoEnfermedad.TabIndex = 0;
            this.lblTiempoEnfermedad.Text = "Tiempo de Enfermedad:";
            // 
            // tbpAntecedentes
            // 
            this.tbpAntecedentes.Location = new System.Drawing.Point(4, 22);
            this.tbpAntecedentes.Name = "tbpAntecedentes";
            this.tbpAntecedentes.Size = new System.Drawing.Size(765, 363);
            this.tbpAntecedentes.TabIndex = 2;
            this.tbpAntecedentes.Text = "Antecedentes";
            this.tbpAntecedentes.UseVisualStyleBackColor = true;
            // 
            // tbpExamenFisico
            // 
            this.tbpExamenFisico.Controls.Add(this.rtxtOtrosExamenes);
            this.tbpExamenFisico.Controls.Add(this.lblOtrosExamenes);
            this.tbpExamenFisico.Controls.Add(this.gbxOtrosDatos);
            this.tbpExamenFisico.Controls.Add(this.gbxSignosVitales);
            this.tbpExamenFisico.Location = new System.Drawing.Point(4, 4);
            this.tbpExamenFisico.Name = "tbpExamenFisico";
            this.tbpExamenFisico.Size = new System.Drawing.Size(779, 395);
            this.tbpExamenFisico.TabIndex = 2;
            this.tbpExamenFisico.Text = "Examen Físico";
            this.tbpExamenFisico.UseVisualStyleBackColor = true;
            // 
            // tbpDiagnostico
            // 
            this.tbpDiagnostico.Controls.Add(this.btnBuscar);
            this.tbpDiagnostico.Controls.Add(this.btnGuardar);
            this.tbpDiagnostico.Controls.Add(this.btnCancelar);
            this.tbpDiagnostico.Controls.Add(this.lblDescripcionActual);
            this.tbpDiagnostico.Controls.Add(this.lblDiagnostico);
            this.tbpDiagnostico.Controls.Add(this.lblDiagnosticoAnterior);
            this.tbpDiagnostico.Controls.Add(this.rtxtDiagnosticoActual);
            this.tbpDiagnostico.Controls.Add(this.txtDiagnostico);
            this.tbpDiagnostico.Controls.Add(this.rtxtDiagnosticoAnterior);
            this.tbpDiagnostico.Location = new System.Drawing.Point(4, 4);
            this.tbpDiagnostico.Name = "tbpDiagnostico";
            this.tbpDiagnostico.Size = new System.Drawing.Size(779, 395);
            this.tbpDiagnostico.TabIndex = 3;
            this.tbpDiagnostico.Text = "Diagnóstico";
            this.tbpDiagnostico.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(672, 176);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 35;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(698, 362);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 33;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(582, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblDescripcionActual
            // 
            this.lblDescripcionActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDescripcionActual.AutoSize = true;
            this.lblDescripcionActual.Location = new System.Drawing.Point(6, 207);
            this.lblDescripcionActual.Name = "lblDescripcionActual";
            this.lblDescripcionActual.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcionActual.TabIndex = 4;
            this.lblDescripcionActual.Text = "Descripción:";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(6, 179);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(66, 13);
            this.lblDiagnostico.TabIndex = 2;
            this.lblDiagnostico.Text = "Diagnóstico:";
            // 
            // lblDiagnosticoAnterior
            // 
            this.lblDiagnosticoAnterior.AutoSize = true;
            this.lblDiagnosticoAnterior.Location = new System.Drawing.Point(6, 3);
            this.lblDiagnosticoAnterior.Name = "lblDiagnosticoAnterior";
            this.lblDiagnosticoAnterior.Size = new System.Drawing.Size(46, 13);
            this.lblDiagnosticoAnterior.TabIndex = 0;
            this.lblDiagnosticoAnterior.Text = "Anterior:";
            // 
            // gbxPersonal
            // 
            this.gbxPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxPersonal.Controls.Add(this.cboFactorSanguineo);
            this.gbxPersonal.Controls.Add(this.lblFactorSanguineo);
            this.gbxPersonal.Controls.Add(this.cboGrupoSanguineo);
            this.gbxPersonal.Controls.Add(this.lblGrupoSanguineo);
            this.gbxPersonal.Controls.Add(this.txtEdad);
            this.gbxPersonal.Controls.Add(this.lblEdad);
            this.gbxPersonal.Controls.Add(this.txtNombres);
            this.gbxPersonal.Controls.Add(this.txtMaterno);
            this.gbxPersonal.Controls.Add(this.txtPaterno);
            this.gbxPersonal.Controls.Add(this.cboEstadoCivil);
            this.gbxPersonal.Controls.Add(this.lblEstadoCivil);
            this.gbxPersonal.Controls.Add(this.dtpFechaNacimiento);
            this.gbxPersonal.Controls.Add(this.lblFechaNacimiento);
            this.gbxPersonal.Controls.Add(this.cboReligion);
            this.gbxPersonal.Controls.Add(this.lblReligion);
            this.gbxPersonal.Controls.Add(this.cboRaza);
            this.gbxPersonal.Controls.Add(this.lblRaza);
            this.gbxPersonal.Controls.Add(this.cboOcupacion);
            this.gbxPersonal.Controls.Add(this.lblOcupacion);
            this.gbxPersonal.Controls.Add(this.cboSexo);
            this.gbxPersonal.Controls.Add(this.lblSexo);
            this.gbxPersonal.Controls.Add(this.lblNombres);
            this.gbxPersonal.Controls.Add(this.lblMaterno);
            this.gbxPersonal.Controls.Add(this.lblPaterno);
            this.gbxPersonal.Location = new System.Drawing.Point(6, 6);
            this.gbxPersonal.Name = "gbxPersonal";
            this.gbxPersonal.Size = new System.Drawing.Size(753, 147);
            this.gbxPersonal.TabIndex = 1;
            this.gbxPersonal.TabStop = false;
            this.gbxPersonal.Text = "Información Personal";
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Items.AddRange(new object[] {
            "SOLTERO(A)",
            "CASADO(A)",
            "VIUDO(A)",
            "DIVORCIADO(A)",
            "OTRO"});
            this.cboEstadoCivil.Location = new System.Drawing.Point(10, 114);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(122, 21);
            this.cboEstadoCivil.TabIndex = 9;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(7, 99);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 20;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(161, 115);
            this.dtpFechaNacimiento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(125, 20);
            this.dtpFechaNacimiento.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(158, 99);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.lblFechaNacimiento.TabIndex = 18;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // cboReligion
            // 
            this.cboReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReligion.FormattingEnabled = true;
            this.cboReligion.Location = new System.Drawing.Point(313, 75);
            this.cboReligion.Name = "cboReligion";
            this.cboReligion.Size = new System.Drawing.Size(125, 21);
            this.cboReligion.TabIndex = 6;
            // 
            // lblReligion
            // 
            this.lblReligion.AutoSize = true;
            this.lblReligion.Location = new System.Drawing.Point(310, 59);
            this.lblReligion.Name = "lblReligion";
            this.lblReligion.Size = new System.Drawing.Size(48, 13);
            this.lblReligion.TabIndex = 12;
            this.lblReligion.Text = "Religión:";
            // 
            // cboRaza
            // 
            this.cboRaza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRaza.FormattingEnabled = true;
            this.cboRaza.Location = new System.Drawing.Point(161, 75);
            this.cboRaza.Name = "cboRaza";
            this.cboRaza.Size = new System.Drawing.Size(125, 21);
            this.cboRaza.TabIndex = 5;
            // 
            // lblRaza
            // 
            this.lblRaza.AutoSize = true;
            this.lblRaza.Location = new System.Drawing.Point(158, 59);
            this.lblRaza.Name = "lblRaza";
            this.lblRaza.Size = new System.Drawing.Size(35, 13);
            this.lblRaza.TabIndex = 10;
            this.lblRaza.Text = "Raza:";
            // 
            // cboOcupacion
            // 
            this.cboOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOcupacion.FormattingEnabled = true;
            this.cboOcupacion.Location = new System.Drawing.Point(463, 75);
            this.cboOcupacion.Name = "cboOcupacion";
            this.cboOcupacion.Size = new System.Drawing.Size(125, 21);
            this.cboOcupacion.TabIndex = 8;
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.Location = new System.Drawing.Point(460, 59);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(62, 13);
            this.lblOcupacion.TabIndex = 8;
            this.lblOcupacion.Text = "Ocupación:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO"});
            this.cboSexo.Location = new System.Drawing.Point(10, 75);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(125, 21);
            this.cboSexo.TabIndex = 4;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(7, 59);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNombres
            // 
            this.lblNombres.AutoSize = true;
            this.lblNombres.Location = new System.Drawing.Point(310, 20);
            this.lblNombres.Name = "lblNombres";
            this.lblNombres.Size = new System.Drawing.Size(52, 13);
            this.lblNombres.TabIndex = 4;
            this.lblNombres.Text = "Nombres:";
            // 
            // lblMaterno
            // 
            this.lblMaterno.AutoSize = true;
            this.lblMaterno.Location = new System.Drawing.Point(158, 20);
            this.lblMaterno.Name = "lblMaterno";
            this.lblMaterno.Size = new System.Drawing.Size(89, 13);
            this.lblMaterno.TabIndex = 2;
            this.lblMaterno.Text = "Apellido Materno:";
            // 
            // lblPaterno
            // 
            this.lblPaterno.AutoSize = true;
            this.lblPaterno.Location = new System.Drawing.Point(7, 20);
            this.lblPaterno.Name = "lblPaterno";
            this.lblPaterno.Size = new System.Drawing.Size(87, 13);
            this.lblPaterno.TabIndex = 0;
            this.lblPaterno.Text = "Apellido Paterno:";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(310, 99);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 21;
            this.lblEdad.Text = "Edad:";
            // 
            // gbxDomicilio
            // 
            this.gbxDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxDomicilio.Controls.Add(this.txtDireccion);
            this.gbxDomicilio.Controls.Add(this.lblDireccion);
            this.gbxDomicilio.Controls.Add(this.cboDistritoDomicilio);
            this.gbxDomicilio.Controls.Add(this.cboProvinciaDomicilio);
            this.gbxDomicilio.Controls.Add(this.cboDepartamentoDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblDistritoDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblProvinciaDomicilio);
            this.gbxDomicilio.Controls.Add(this.lblDepartamentoDomicilio);
            this.gbxDomicilio.Location = new System.Drawing.Point(6, 238);
            this.gbxDomicilio.Name = "gbxDomicilio";
            this.gbxDomicilio.Size = new System.Drawing.Size(753, 116);
            this.gbxDomicilio.TabIndex = 19;
            this.gbxDomicilio.TabStop = false;
            this.gbxDomicilio.Text = "Domicilio";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(7, 62);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 36;
            this.lblDireccion.Text = "Dirección:";
            // 
            // cboDistritoDomicilio
            // 
            this.cboDistritoDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistritoDomicilio.FormattingEnabled = true;
            this.cboDistritoDomicilio.Location = new System.Drawing.Point(313, 33);
            this.cboDistritoDomicilio.Name = "cboDistritoDomicilio";
            this.cboDistritoDomicilio.Size = new System.Drawing.Size(125, 21);
            this.cboDistritoDomicilio.TabIndex = 20;
            // 
            // cboProvinciaDomicilio
            // 
            this.cboProvinciaDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvinciaDomicilio.FormattingEnabled = true;
            this.cboProvinciaDomicilio.Location = new System.Drawing.Point(161, 33);
            this.cboProvinciaDomicilio.Name = "cboProvinciaDomicilio";
            this.cboProvinciaDomicilio.Size = new System.Drawing.Size(122, 21);
            this.cboProvinciaDomicilio.TabIndex = 19;
            // 
            // cboDepartamentoDomicilio
            // 
            this.cboDepartamentoDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamentoDomicilio.FormattingEnabled = true;
            this.cboDepartamentoDomicilio.Location = new System.Drawing.Point(10, 33);
            this.cboDepartamentoDomicilio.Name = "cboDepartamentoDomicilio";
            this.cboDepartamentoDomicilio.Size = new System.Drawing.Size(119, 21);
            this.cboDepartamentoDomicilio.TabIndex = 18;
            // 
            // lblDistritoDomicilio
            // 
            this.lblDistritoDomicilio.AutoSize = true;
            this.lblDistritoDomicilio.Location = new System.Drawing.Point(310, 17);
            this.lblDistritoDomicilio.Name = "lblDistritoDomicilio";
            this.lblDistritoDomicilio.Size = new System.Drawing.Size(42, 13);
            this.lblDistritoDomicilio.TabIndex = 32;
            this.lblDistritoDomicilio.Text = "Distrito:";
            // 
            // lblProvinciaDomicilio
            // 
            this.lblProvinciaDomicilio.AutoSize = true;
            this.lblProvinciaDomicilio.Location = new System.Drawing.Point(158, 17);
            this.lblProvinciaDomicilio.Name = "lblProvinciaDomicilio";
            this.lblProvinciaDomicilio.Size = new System.Drawing.Size(54, 13);
            this.lblProvinciaDomicilio.TabIndex = 31;
            this.lblProvinciaDomicilio.Text = "Provincia:";
            // 
            // lblDepartamentoDomicilio
            // 
            this.lblDepartamentoDomicilio.AutoSize = true;
            this.lblDepartamentoDomicilio.Location = new System.Drawing.Point(7, 16);
            this.lblDepartamentoDomicilio.Name = "lblDepartamentoDomicilio";
            this.lblDepartamentoDomicilio.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamentoDomicilio.TabIndex = 30;
            this.lblDepartamentoDomicilio.Text = "Departamento:";
            // 
            // gbxLugarNacimiento
            // 
            this.gbxLugarNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxLugarNacimiento.Controls.Add(this.cboDistrito);
            this.gbxLugarNacimiento.Controls.Add(this.cboProvincia);
            this.gbxLugarNacimiento.Controls.Add(this.cboDepartamento);
            this.gbxLugarNacimiento.Controls.Add(this.lblDistrito);
            this.gbxLugarNacimiento.Controls.Add(this.lblProvincia);
            this.gbxLugarNacimiento.Controls.Add(this.lblDepartamento);
            this.gbxLugarNacimiento.Controls.Add(this.cboPais);
            this.gbxLugarNacimiento.Controls.Add(this.lblPais);
            this.gbxLugarNacimiento.Location = new System.Drawing.Point(6, 159);
            this.gbxLugarNacimiento.Name = "gbxLugarNacimiento";
            this.gbxLugarNacimiento.Size = new System.Drawing.Size(753, 72);
            this.gbxLugarNacimiento.TabIndex = 18;
            this.gbxLugarNacimiento.TabStop = false;
            this.gbxLugarNacimiento.Text = "Lugar de Nacimiento";
            // 
            // cboDistrito
            // 
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(463, 32);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(125, 21);
            this.cboDistrito.TabIndex = 16;
            // 
            // cboProvincia
            // 
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(313, 32);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(125, 21);
            this.cboProvincia.TabIndex = 15;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(161, 32);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(119, 21);
            this.cboDepartamento.TabIndex = 14;
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.Location = new System.Drawing.Point(460, 16);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(42, 13);
            this.lblDistrito.TabIndex = 26;
            this.lblDistrito.Text = "Distrito:";
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(310, 16);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(54, 13);
            this.lblProvincia.TabIndex = 25;
            this.lblProvincia.Text = "Provincia:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(158, 16);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 24;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cboPais
            // 
            this.cboPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPais.FormattingEnabled = true;
            this.cboPais.Location = new System.Drawing.Point(10, 32);
            this.cboPais.Name = "cboPais";
            this.cboPais.Size = new System.Drawing.Size(125, 21);
            this.cboPais.TabIndex = 13;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(7, 16);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(30, 13);
            this.lblPais.TabIndex = 22;
            this.lblPais.Text = "Pais:";
            // 
            // lblGrupoSanguineo
            // 
            this.lblGrupoSanguineo.AutoSize = true;
            this.lblGrupoSanguineo.Location = new System.Drawing.Point(460, 99);
            this.lblGrupoSanguineo.Name = "lblGrupoSanguineo";
            this.lblGrupoSanguineo.Size = new System.Drawing.Size(95, 13);
            this.lblGrupoSanguineo.TabIndex = 23;
            this.lblGrupoSanguineo.Text = "Grupo Sanguíneo:";
            // 
            // cboGrupoSanguineo
            // 
            this.cboGrupoSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupoSanguineo.FormattingEnabled = true;
            this.cboGrupoSanguineo.Location = new System.Drawing.Point(463, 114);
            this.cboGrupoSanguineo.Name = "cboGrupoSanguineo";
            this.cboGrupoSanguineo.Size = new System.Drawing.Size(125, 21);
            this.cboGrupoSanguineo.TabIndex = 24;
            // 
            // cboFactorSanguineo
            // 
            this.cboFactorSanguineo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFactorSanguineo.FormattingEnabled = true;
            this.cboFactorSanguineo.Location = new System.Drawing.Point(616, 114);
            this.cboFactorSanguineo.Name = "cboFactorSanguineo";
            this.cboFactorSanguineo.Size = new System.Drawing.Size(125, 21);
            this.cboFactorSanguineo.TabIndex = 26;
            // 
            // lblFactorSanguineo
            // 
            this.lblFactorSanguineo.AutoSize = true;
            this.lblFactorSanguineo.Location = new System.Drawing.Point(613, 99);
            this.lblFactorSanguineo.Name = "lblFactorSanguineo";
            this.lblFactorSanguineo.Size = new System.Drawing.Size(96, 13);
            this.lblFactorSanguineo.TabIndex = 25;
            this.lblFactorSanguineo.Text = "Factor Sanguíneo:";
            // 
            // gbxSignosVitales
            // 
            this.gbxSignosVitales.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxSignosVitales.Controls.Add(this.txtPresionArterial);
            this.gbxSignosVitales.Controls.Add(this.txtFrecuenciaRespiratoria);
            this.gbxSignosVitales.Controls.Add(this.lblPresionArterial);
            this.gbxSignosVitales.Controls.Add(this.lblFrecuenciaRespiratoria);
            this.gbxSignosVitales.Controls.Add(this.txtPulso);
            this.gbxSignosVitales.Controls.Add(this.lblPulso);
            this.gbxSignosVitales.Controls.Add(this.txtFrecuenciaCardiaca);
            this.gbxSignosVitales.Controls.Add(this.label1);
            this.gbxSignosVitales.Controls.Add(this.txtTemperatura);
            this.gbxSignosVitales.Controls.Add(this.lblTemperatura);
            this.gbxSignosVitales.Location = new System.Drawing.Point(6, 6);
            this.gbxSignosVitales.Name = "gbxSignosVitales";
            this.gbxSignosVitales.Size = new System.Drawing.Size(770, 130);
            this.gbxSignosVitales.TabIndex = 0;
            this.gbxSignosVitales.TabStop = false;
            this.gbxSignosVitales.Text = "Signos Vitales";
            // 
            // gbxOtrosDatos
            // 
            this.gbxOtrosDatos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxOtrosDatos.Controls.Add(this.txtTalla);
            this.gbxOtrosDatos.Controls.Add(this.txtPeso);
            this.gbxOtrosDatos.Controls.Add(this.lblTalla);
            this.gbxOtrosDatos.Controls.Add(this.lblPeso);
            this.gbxOtrosDatos.Location = new System.Drawing.Point(6, 142);
            this.gbxOtrosDatos.Name = "gbxOtrosDatos";
            this.gbxOtrosDatos.Size = new System.Drawing.Size(770, 100);
            this.gbxOtrosDatos.TabIndex = 1;
            this.gbxOtrosDatos.TabStop = false;
            this.gbxOtrosDatos.Text = "Otros Datos";
            // 
            // lblOtrosExamenes
            // 
            this.lblOtrosExamenes.AutoSize = true;
            this.lblOtrosExamenes.Location = new System.Drawing.Point(3, 254);
            this.lblOtrosExamenes.Name = "lblOtrosExamenes";
            this.lblOtrosExamenes.Size = new System.Drawing.Size(87, 13);
            this.lblOtrosExamenes.TabIndex = 3;
            this.lblOtrosExamenes.Text = "Otros Exámenes:";
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(6, 27);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(70, 13);
            this.lblTemperatura.TabIndex = 0;
            this.lblTemperatura.Text = "Temperatura:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frecuencia Cardiaca:";
            // 
            // lblPulso
            // 
            this.lblPulso.AutoSize = true;
            this.lblPulso.Location = new System.Drawing.Point(6, 84);
            this.lblPulso.Name = "lblPulso";
            this.lblPulso.Size = new System.Drawing.Size(36, 13);
            this.lblPulso.TabIndex = 4;
            this.lblPulso.Text = "Pulso:";
            // 
            // lblFrecuenciaRespiratoria
            // 
            this.lblFrecuenciaRespiratoria.AutoSize = true;
            this.lblFrecuenciaRespiratoria.Location = new System.Drawing.Point(293, 55);
            this.lblFrecuenciaRespiratoria.Name = "lblFrecuenciaRespiratoria";
            this.lblFrecuenciaRespiratoria.Size = new System.Drawing.Size(122, 13);
            this.lblFrecuenciaRespiratoria.TabIndex = 6;
            this.lblFrecuenciaRespiratoria.Text = "Frecuencia Respiratoria:";
            // 
            // lblPresionArterial
            // 
            this.lblPresionArterial.AutoSize = true;
            this.lblPresionArterial.Location = new System.Drawing.Point(293, 84);
            this.lblPresionArterial.Name = "lblPresionArterial";
            this.lblPresionArterial.Size = new System.Drawing.Size(80, 13);
            this.lblPresionArterial.TabIndex = 7;
            this.lblPresionArterial.Text = "Presión Arterial:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(6, 25);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(34, 13);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Peso:";
            // 
            // lblTalla
            // 
            this.lblTalla.AutoSize = true;
            this.lblTalla.Location = new System.Drawing.Point(6, 59);
            this.lblTalla.Name = "lblTalla";
            this.lblTalla.Size = new System.Drawing.Size(33, 13);
            this.lblTalla.TabIndex = 7;
            this.lblTalla.Text = "Talla:";
            // 
            // rtxtEctoscopiaActual
            // 
            this.rtxtEctoscopiaActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtEctoscopiaActual.Location = new System.Drawing.Point(9, 216);
            this.rtxtEctoscopiaActual.Name = "rtxtEctoscopiaActual";
            this.rtxtEctoscopiaActual.Size = new System.Drawing.Size(764, 160);
            this.rtxtEctoscopiaActual.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtEctoscopiaActual.TabIndex = 3;
            this.rtxtEctoscopiaActual.Text = "";
            // 
            // rtxtEctoscopiaAnterior
            // 
            this.rtxtEctoscopiaAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtEctoscopiaAnterior.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtEctoscopiaAnterior.Location = new System.Drawing.Point(9, 19);
            this.rtxtEctoscopiaAnterior.Name = "rtxtEctoscopiaAnterior";
            this.rtxtEctoscopiaAnterior.ReadOnly = true;
            this.rtxtEctoscopiaAnterior.Size = new System.Drawing.Size(764, 178);
            this.rtxtEctoscopiaAnterior.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
            this.rtxtEctoscopiaAnterior.TabIndex = 1;
            this.rtxtEctoscopiaAnterior.Text = "";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(10, 83);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(737, 20);
            this.txtDireccion.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDireccion.TabIndex = 21;
            this.txtDireccion.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.AliceBlue;
            this.txtEdad.Location = new System.Drawing.Point(313, 115);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(65, 20);
            this.txtEdad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.verdadero;
            this.txtEdad.TabIndex = 22;
            this.txtEdad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(313, 36);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(275, 20);
            this.txtNombres.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtMaterno
            // 
            this.txtMaterno.Location = new System.Drawing.Point(161, 36);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(125, 20);
            this.txtMaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtMaterno.TabIndex = 2;
            this.txtMaterno.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // txtPaterno
            // 
            this.txtPaterno.Location = new System.Drawing.Point(10, 35);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(125, 20);
            this.txtPaterno.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPaterno.TabIndex = 1;
            this.txtPaterno.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Letras;
            // 
            // rtxtRelatoCronologico
            // 
            this.rtxtRelatoCronologico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtRelatoCronologico.Location = new System.Drawing.Point(201, 274);
            this.rtxtRelatoCronologico.Name = "rtxtRelatoCronologico";
            this.rtxtRelatoCronologico.Size = new System.Drawing.Size(558, 83);
            this.rtxtRelatoCronologico.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtRelatoCronologico.TabIndex = 4;
            this.rtxtRelatoCronologico.Text = "";
            // 
            // rtxtSintomasEnfermedad
            // 
            this.rtxtSintomasEnfermedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtSintomasEnfermedad.Location = new System.Drawing.Point(201, 107);
            this.rtxtSintomasEnfermedad.Name = "rtxtSintomasEnfermedad";
            this.rtxtSintomasEnfermedad.Size = new System.Drawing.Size(558, 161);
            this.rtxtSintomasEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtSintomasEnfermedad.TabIndex = 3;
            this.rtxtSintomasEnfermedad.Text = "";
            // 
            // txtCursoEnfermedad
            // 
            this.txtCursoEnfermedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCursoEnfermedad.Location = new System.Drawing.Point(201, 72);
            this.txtCursoEnfermedad.Name = "txtCursoEnfermedad";
            this.txtCursoEnfermedad.Size = new System.Drawing.Size(558, 20);
            this.txtCursoEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtCursoEnfermedad.TabIndex = 2;
            this.txtCursoEnfermedad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtInicioEnfermedad
            // 
            this.txtInicioEnfermedad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInicioEnfermedad.Location = new System.Drawing.Point(201, 37);
            this.txtInicioEnfermedad.Name = "txtInicioEnfermedad";
            this.txtInicioEnfermedad.Size = new System.Drawing.Size(558, 20);
            this.txtInicioEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtInicioEnfermedad.TabIndex = 1;
            this.txtInicioEnfermedad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtTiempoEnfermedad
            // 
            this.txtTiempoEnfermedad.BackColor = System.Drawing.Color.White;
            this.txtTiempoEnfermedad.Location = new System.Drawing.Point(201, 3);
            this.txtTiempoEnfermedad.Name = "txtTiempoEnfermedad";
            this.txtTiempoEnfermedad.Size = new System.Drawing.Size(49, 20);
            this.txtTiempoEnfermedad.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTiempoEnfermedad.TabIndex = 0;
            this.txtTiempoEnfermedad.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Enteros;
            // 
            // rtxtOtrosExamenes
            // 
            this.rtxtOtrosExamenes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtOtrosExamenes.Location = new System.Drawing.Point(6, 270);
            this.rtxtOtrosExamenes.Name = "rtxtOtrosExamenes";
            this.rtxtOtrosExamenes.Size = new System.Drawing.Size(770, 122);
            this.rtxtOtrosExamenes.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtOtrosExamenes.TabIndex = 4;
            this.rtxtOtrosExamenes.Text = "";
            // 
            // txtTalla
            // 
            this.txtTalla.Location = new System.Drawing.Point(130, 51);
            this.txtTalla.Name = "txtTalla";
            this.txtTalla.Size = new System.Drawing.Size(73, 20);
            this.txtTalla.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTalla.TabIndex = 9;
            this.txtTalla.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(130, 22);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(73, 20);
            this.txtPeso.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPeso.TabIndex = 8;
            this.txtPeso.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtPresionArterial
            // 
            this.txtPresionArterial.Location = new System.Drawing.Point(434, 81);
            this.txtPresionArterial.Name = "txtPresionArterial";
            this.txtPresionArterial.Size = new System.Drawing.Size(73, 20);
            this.txtPresionArterial.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPresionArterial.TabIndex = 9;
            this.txtPresionArterial.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtFrecuenciaRespiratoria
            // 
            this.txtFrecuenciaRespiratoria.Location = new System.Drawing.Point(434, 52);
            this.txtFrecuenciaRespiratoria.Name = "txtFrecuenciaRespiratoria";
            this.txtFrecuenciaRespiratoria.Size = new System.Drawing.Size(73, 20);
            this.txtFrecuenciaRespiratoria.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtFrecuenciaRespiratoria.TabIndex = 8;
            this.txtFrecuenciaRespiratoria.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtPulso
            // 
            this.txtPulso.Location = new System.Drawing.Point(130, 81);
            this.txtPulso.Name = "txtPulso";
            this.txtPulso.Size = new System.Drawing.Size(73, 20);
            this.txtPulso.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtPulso.TabIndex = 5;
            this.txtPulso.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtFrecuenciaCardiaca
            // 
            this.txtFrecuenciaCardiaca.Location = new System.Drawing.Point(130, 52);
            this.txtFrecuenciaCardiaca.Name = "txtFrecuenciaCardiaca";
            this.txtFrecuenciaCardiaca.Size = new System.Drawing.Size(73, 20);
            this.txtFrecuenciaCardiaca.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtFrecuenciaCardiaca.TabIndex = 3;
            this.txtFrecuenciaCardiaca.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(130, 24);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(73, 20);
            this.txtTemperatura.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtTemperatura.TabIndex = 1;
            this.txtTemperatura.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Decimales;
            // 
            // rtxtDiagnosticoActual
            // 
            this.rtxtDiagnosticoActual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDiagnosticoActual.Location = new System.Drawing.Point(9, 223);
            this.rtxtDiagnosticoActual.Name = "rtxtDiagnosticoActual";
            this.rtxtDiagnosticoActual.Size = new System.Drawing.Size(764, 133);
            this.rtxtDiagnosticoActual.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.falso;
            this.rtxtDiagnosticoActual.TabIndex = 5;
            this.rtxtDiagnosticoActual.Text = "";
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiagnostico.Location = new System.Drawing.Point(78, 176);
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(588, 20);
            this.txtDiagnostico.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtDiagnostico.TabIndex = 3;
            this.txtDiagnostico.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // rtxtDiagnosticoAnterior
            // 
            this.rtxtDiagnosticoAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtDiagnosticoAnterior.BackColor = System.Drawing.Color.AliceBlue;
            this.rtxtDiagnosticoAnterior.Location = new System.Drawing.Point(9, 19);
            this.rtxtDiagnosticoAnterior.Name = "rtxtDiagnosticoAnterior";
            this.rtxtDiagnosticoAnterior.ReadOnly = true;
            this.rtxtDiagnosticoAnterior.Size = new System.Drawing.Size(764, 145);
            this.rtxtDiagnosticoAnterior.Solo_Lectura = SistemaCentroSalud.Controles.cuRichTextBox.SoloLectura.verdadero;
            this.rtxtDiagnosticoAnterior.TabIndex = 1;
            this.rtxtDiagnosticoAnterior.Text = "";
            // 
            // frmHistorialClinica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 435);
            this.Controls.Add(this.tbcHistoriaClinica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHistorialClinica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historia Clínica";
            this.tbcHistoriaClinica.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).EndInit();
            this.tbpDetalle.ResumeLayout(false);
            this.tbcHistoriaClinicaPartes.ResumeLayout(false);
            this.tbpEctoscopia.ResumeLayout(false);
            this.tbpEctoscopia.PerformLayout();
            this.tbpAnamnesis.ResumeLayout(false);
            this.tbcAnamnesisPartes.ResumeLayout(false);
            this.tbpFiliacion.ResumeLayout(false);
            this.tbpEnfermedadActual.ResumeLayout(false);
            this.tbpEnfermedadActual.PerformLayout();
            this.tbpExamenFisico.ResumeLayout(false);
            this.tbpExamenFisico.PerformLayout();
            this.tbpDiagnostico.ResumeLayout(false);
            this.tbpDiagnostico.PerformLayout();
            this.gbxPersonal.ResumeLayout(false);
            this.gbxPersonal.PerformLayout();
            this.gbxDomicilio.ResumeLayout(false);
            this.gbxDomicilio.PerformLayout();
            this.gbxLugarNacimiento.ResumeLayout(false);
            this.gbxLugarNacimiento.PerformLayout();
            this.gbxSignosVitales.ResumeLayout(false);
            this.gbxSignosVitales.PerformLayout();
            this.gbxOtrosDatos.ResumeLayout(false);
            this.gbxOtrosDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcHistoriaClinica;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.TabControl tbcHistoriaClinicaPartes;
        private System.Windows.Forms.TabPage tbpEctoscopia;
        private System.Windows.Forms.TabPage tbpAnamnesis;
        private System.Windows.Forms.TabPage tbpExamenFisico;
        private System.Windows.Forms.TabPage tbpDiagnostico;
        private System.Windows.Forms.DataGridView dgvHistoriasClinicas;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtEctoscopiaActual;
        private System.Windows.Forms.Label lblEctoscopiaActual;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtEctoscopiaAnterior;
        private System.Windows.Forms.Label lblEctoscopiaAnterior;
        private System.Windows.Forms.TabControl tbcAnamnesisPartes;
        private System.Windows.Forms.TabPage tbpEnfermedadActual;
        private System.Windows.Forms.TabPage tbpAntecedentes;
        private System.Windows.Forms.TabPage tbpFiliacion;
        private System.Windows.Forms.Label lblDescripcionActual;
        private SistemaCentroSalud.Controles.cuTextBox txtDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtDiagnosticoAnterior;
        private System.Windows.Forms.Label lblDiagnosticoAnterior;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtDiagnosticoActual;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblInicioEnfermedad;
        private System.Windows.Forms.Label lblDias;
        private SistemaCentroSalud.Controles.cuTextBox txtTiempoEnfermedad;
        private System.Windows.Forms.Label lblTiempoEnfermedad;
        private System.Windows.Forms.Label lblRelatoCronologico;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtRelatoCronologico;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtSintomasEnfermedad;
        private System.Windows.Forms.Label lblSintomasEnfermedad;
        private System.Windows.Forms.Label lblCursoEnfermedad;
        private SistemaCentroSalud.Controles.cuTextBox txtCursoEnfermedad;
        private SistemaCentroSalud.Controles.cuTextBox txtInicioEnfermedad;
        private System.Windows.Forms.GroupBox gbxPersonal;
        private SistemaCentroSalud.Controles.cuTextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private SistemaCentroSalud.Controles.cuTextBox txtNombres;
        private SistemaCentroSalud.Controles.cuTextBox txtMaterno;
        private SistemaCentroSalud.Controles.cuTextBox txtPaterno;
        private System.Windows.Forms.ComboBox cboEstadoCivil;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.ComboBox cboReligion;
        private System.Windows.Forms.Label lblReligion;
        private System.Windows.Forms.ComboBox cboRaza;
        private System.Windows.Forms.Label lblRaza;
        private System.Windows.Forms.ComboBox cboOcupacion;
        private System.Windows.Forms.Label lblOcupacion;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblMaterno;
        private System.Windows.Forms.Label lblPaterno;
        private System.Windows.Forms.GroupBox gbxDomicilio;
        private SistemaCentroSalud.Controles.cuTextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ComboBox cboDistritoDomicilio;
        private System.Windows.Forms.ComboBox cboProvinciaDomicilio;
        private System.Windows.Forms.ComboBox cboDepartamentoDomicilio;
        private System.Windows.Forms.Label lblDistritoDomicilio;
        private System.Windows.Forms.Label lblProvinciaDomicilio;
        private System.Windows.Forms.Label lblDepartamentoDomicilio;
        private System.Windows.Forms.GroupBox gbxLugarNacimiento;
        private System.Windows.Forms.ComboBox cboDistrito;
        private System.Windows.Forms.ComboBox cboProvincia;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblDistrito;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cboPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox cboFactorSanguineo;
        private System.Windows.Forms.Label lblFactorSanguineo;
        private System.Windows.Forms.ComboBox cboGrupoSanguineo;
        private System.Windows.Forms.Label lblGrupoSanguineo;
        private System.Windows.Forms.Label lblOtrosExamenes;
        private System.Windows.Forms.GroupBox gbxOtrosDatos;
        private System.Windows.Forms.GroupBox gbxSignosVitales;
        private SistemaCentroSalud.Controles.cuTextBox txtFrecuenciaCardiaca;
        private System.Windows.Forms.Label label1;
        private SistemaCentroSalud.Controles.cuTextBox txtTemperatura;
        private System.Windows.Forms.Label lblTemperatura;
        private SistemaCentroSalud.Controles.cuTextBox txtPresionArterial;
        private SistemaCentroSalud.Controles.cuTextBox txtFrecuenciaRespiratoria;
        private System.Windows.Forms.Label lblPresionArterial;
        private System.Windows.Forms.Label lblFrecuenciaRespiratoria;
        private SistemaCentroSalud.Controles.cuTextBox txtPulso;
        private System.Windows.Forms.Label lblPulso;
        private SistemaCentroSalud.Controles.cuTextBox txtTalla;
        private SistemaCentroSalud.Controles.cuTextBox txtPeso;
        private System.Windows.Forms.Label lblTalla;
        private System.Windows.Forms.Label lblPeso;
        private SistemaCentroSalud.Controles.cuRichTextBox rtxtOtrosExamenes;
    }
}