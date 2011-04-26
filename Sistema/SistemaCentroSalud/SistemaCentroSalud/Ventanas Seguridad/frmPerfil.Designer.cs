namespace SistemaCentroSalud.Ventanas_Seguridad
{
    partial class frmPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPerfil));
            this.tbcPerfil = new System.Windows.Forms.TabControl();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.tbpDetalle = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxPermisos = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnTodoDerecha = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.btnIzquierda = new System.Windows.Forms.Button();
            this.btnTodoIzquierda = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.cboArea = new System.Windows.Forms.ComboBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxCriterios = new System.Windows.Forms.GroupBox();
            this.dgvPerfiles = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActivar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombre = new SistemaCentroSalud.Controles.cuTextBox();
            this.tbcPerfil.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            this.tbpDetalle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcPerfil
            // 
            this.tbcPerfil.Controls.Add(this.tbpBuscar);
            this.tbcPerfil.Controls.Add(this.tbpDetalle);
            this.tbcPerfil.Location = new System.Drawing.Point(0, 0);
            this.tbcPerfil.Name = "tbcPerfil";
            this.tbcPerfil.SelectedIndex = 0;
            this.tbcPerfil.Size = new System.Drawing.Size(459, 318);
            this.tbcPerfil.TabIndex = 0;
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnSalir);
            this.tbpBuscar.Controls.Add(this.btnInactivar);
            this.tbpBuscar.Controls.Add(this.btnActivar);
            this.tbpBuscar.Controls.Add(this.btnVer);
            this.tbpBuscar.Controls.Add(this.btnModificar);
            this.tbpBuscar.Controls.Add(this.btnNuevo);
            this.tbpBuscar.Controls.Add(this.dgvPerfiles);
            this.tbpBuscar.Controls.Add(this.gbxCriterios);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(451, 292);
            this.tbpBuscar.TabIndex = 0;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // tbpDetalle
            // 
            this.tbpDetalle.Controls.Add(this.btnGuardar);
            this.tbpDetalle.Controls.Add(this.btnCancelar);
            this.tbpDetalle.Controls.Add(this.gbxPermisos);
            this.tbpDetalle.Controls.Add(this.groupBox1);
            this.tbpDetalle.Location = new System.Drawing.Point(4, 22);
            this.tbpDetalle.Name = "tbpDetalle";
            this.tbpDetalle.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetalle.Size = new System.Drawing.Size(451, 292);
            this.tbpDetalle.TabIndex = 1;
            this.tbpDetalle.Text = "Detalle";
            this.tbpDetalle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.cboArea);
            this.groupBox1.Controls.Add(this.lblArea);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // gbxPermisos
            // 
            this.gbxPermisos.Controls.Add(this.btnTodoIzquierda);
            this.gbxPermisos.Controls.Add(this.btnIzquierda);
            this.gbxPermisos.Controls.Add(this.btnDerecha);
            this.gbxPermisos.Controls.Add(this.btnTodoDerecha);
            this.gbxPermisos.Controls.Add(this.listBox1);
            this.gbxPermisos.Controls.Add(this.treeView1);
            this.gbxPermisos.Location = new System.Drawing.Point(8, 81);
            this.gbxPermisos.Name = "gbxPermisos";
            this.gbxPermisos.Size = new System.Drawing.Size(545, 171);
            this.gbxPermisos.TabIndex = 3;
            this.gbxPermisos.TabStop = false;
            this.gbxPermisos.Text = "Permisos";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(9, 19);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(212, 134);
            this.treeView1.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(322, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 134);
            this.listBox1.TabIndex = 9;
            // 
            // btnTodoDerecha
            // 
            this.btnTodoDerecha.Location = new System.Drawing.Point(234, 24);
            this.btnTodoDerecha.Name = "btnTodoDerecha";
            this.btnTodoDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnTodoDerecha.TabIndex = 5;
            this.btnTodoDerecha.Text = ">>";
            this.btnTodoDerecha.UseVisualStyleBackColor = true;
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(234, 57);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 6;
            this.btnDerecha.Text = ">";
            this.btnDerecha.UseVisualStyleBackColor = true;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Location = new System.Drawing.Point(234, 90);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnIzquierda.TabIndex = 7;
            this.btnIzquierda.Text = "<";
            this.btnIzquierda.UseVisualStyleBackColor = true;
            // 
            // btnTodoIzquierda
            // 
            this.btnTodoIzquierda.Location = new System.Drawing.Point(234, 123);
            this.btnTodoIzquierda.Name = "btnTodoIzquierda";
            this.btnTodoIzquierda.Size = new System.Drawing.Size(75, 23);
            this.btnTodoIzquierda.TabIndex = 8;
            this.btnTodoIzquierda.Text = "<<";
            this.btnTodoIzquierda.UseVisualStyleBackColor = true;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(6, 16);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 0;
            this.lblArea.Text = "Área:";
            // 
            // cboArea
            // 
            this.cboArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArea.FormattingEnabled = true;
            this.cboArea.Location = new System.Drawing.Point(9, 32);
            this.cboArea.Name = "cboArea";
            this.cboArea.Size = new System.Drawing.Size(150, 21);
            this.cboArea.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(231, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(467, 258);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(351, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gbxCriterios
            // 
            this.gbxCriterios.Location = new System.Drawing.Point(8, 6);
            this.gbxCriterios.Name = "gbxCriterios";
            this.gbxCriterios.Size = new System.Drawing.Size(435, 100);
            this.gbxCriterios.TabIndex = 0;
            this.gbxCriterios.TabStop = false;
            this.gbxCriterios.Text = "Criterios de Búsqueda";
            // 
            // dgvPerfiles
            // 
            this.dgvPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPerfiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colArea,
            this.colEstado});
            this.dgvPerfiles.Location = new System.Drawing.Point(8, 112);
            this.dgvPerfiles.Name = "dgvPerfiles";
            this.dgvPerfiles.Size = new System.Drawing.Size(435, 144);
            this.dgvPerfiles.TabIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colArea
            // 
            this.colArea.HeaderText = "Área";
            this.colArea.Name = "colArea";
            this.colArea.ReadOnly = true;
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Visible = false;
            // 
            // btnActivar
            // 
            this.btnActivar.Image = ((System.Drawing.Image)(resources.GetObject("btnActivar.Image")));
            this.btnActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivar.Location = new System.Drawing.Point(279, 262);
            this.btnActivar.Name = "btnActivar";
            this.btnActivar.Size = new System.Drawing.Size(75, 23);
            this.btnActivar.TabIndex = 17;
            this.btnActivar.Text = "Activar";
            this.btnActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActivar.UseVisualStyleBackColor = true;
            this.btnActivar.Visible = false;
            // 
            // btnVer
            // 
            this.btnVer.Image = ((System.Drawing.Image)(resources.GetObject("btnVer.Image")));
            this.btnVer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVer.Location = new System.Drawing.Point(99, 262);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 16;
            this.btnVer.Text = "Ver";
            this.btnVer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.Location = new System.Drawing.Point(190, 262);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevo.Location = new System.Drawing.Point(8, 262);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 14;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnInactivar
            // 
            this.btnInactivar.Image = ((System.Drawing.Image)(resources.GetObject("btnInactivar.Image")));
            this.btnInactivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInactivar.Location = new System.Drawing.Point(279, 262);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 23);
            this.btnInactivar.TabIndex = 18;
            this.btnInactivar.Text = "Inactivar";
            this.btnInactivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInactivar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(368, 262);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNombre.TabIndex = 2;
            this.txtNombre.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // frmPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 317);
            this.Controls.Add(this.tbcPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.frmPerfil_Load);
            this.tbcPerfil.ResumeLayout(false);
            this.tbpBuscar.ResumeLayout(false);
            this.tbpDetalle.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPerfiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcPerfil;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.TabPage tbpDetalle;
        private System.Windows.Forms.GroupBox gbxPermisos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTodoIzquierda;
        private System.Windows.Forms.Button btnIzquierda;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button btnTodoDerecha;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ComboBox cboArea;
        private System.Windows.Forms.Label lblArea;
        private SistemaCentroSalud.Controles.cuTextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvPerfiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.GroupBox gbxCriterios;
        private System.Windows.Forms.Button btnActivar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnSalir;
    }
}