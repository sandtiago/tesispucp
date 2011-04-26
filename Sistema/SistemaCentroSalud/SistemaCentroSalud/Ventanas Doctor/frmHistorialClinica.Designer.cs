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
            this.rtxtEctoscopiaActual = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.lblEctoscopiaActual = new System.Windows.Forms.Label();
            this.rtxtEctoscopiaAnterior = new SistemaCentroSalud.Controles.cuRichTextBox();
            this.lblEctoscopiaAnterior = new System.Windows.Forms.Label();
            this.tbpAnamnesis = new System.Windows.Forms.TabPage();
            this.tbcAnamnesisPartes = new System.Windows.Forms.TabControl();
            this.tbpFiliacion = new System.Windows.Forms.TabPage();
            this.tbpEnfermedadActual = new System.Windows.Forms.TabPage();
            this.tbpAntecedentes = new System.Windows.Forms.TabPage();
            this.tbpExamenFisico = new System.Windows.Forms.TabPage();
            this.tbpDiagnostico = new System.Windows.Forms.TabPage();
            this.tbcHistoriaClinica.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistoriasClinicas)).BeginInit();
            this.tbpDetalle.SuspendLayout();
            this.tbcHistoriaClinicaPartes.SuspendLayout();
            this.tbpEctoscopia.SuspendLayout();
            this.tbpAnamnesis.SuspendLayout();
            this.tbcAnamnesisPartes.SuspendLayout();
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
            this.tbpEnfermedadActual.Location = new System.Drawing.Point(4, 22);
            this.tbpEnfermedadActual.Name = "tbpEnfermedadActual";
            this.tbpEnfermedadActual.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEnfermedadActual.Size = new System.Drawing.Size(765, 363);
            this.tbpEnfermedadActual.TabIndex = 1;
            this.tbpEnfermedadActual.Text = "Enfermedad Actual";
            this.tbpEnfermedadActual.UseVisualStyleBackColor = true;
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
            this.tbpExamenFisico.Location = new System.Drawing.Point(4, 4);
            this.tbpExamenFisico.Name = "tbpExamenFisico";
            this.tbpExamenFisico.Size = new System.Drawing.Size(779, 395);
            this.tbpExamenFisico.TabIndex = 2;
            this.tbpExamenFisico.Text = "Examen Físico";
            this.tbpExamenFisico.UseVisualStyleBackColor = true;
            // 
            // tbpDiagnostico
            // 
            this.tbpDiagnostico.Location = new System.Drawing.Point(4, 4);
            this.tbpDiagnostico.Name = "tbpDiagnostico";
            this.tbpDiagnostico.Size = new System.Drawing.Size(779, 395);
            this.tbpDiagnostico.TabIndex = 3;
            this.tbpDiagnostico.Text = "Diagnóstico";
            this.tbpDiagnostico.UseVisualStyleBackColor = true;
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
    }
}