namespace SistemaCentroSalud
{
    partial class frmCambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContrasena));
            this.lblIngresarContrasena = new System.Windows.Forms.Label();
            this.txtIngresarContrasena = new SistemaCentroSalud.Controles.cuTextBox();
            this.gbxAcceso = new System.Windows.Forms.GroupBox();
            this.txtRepetirContrasena = new SistemaCentroSalud.Controles.cuTextBox();
            this.txtNuevaContrasena = new SistemaCentroSalud.Controles.cuTextBox();
            this.lblRepetirContrasena = new System.Windows.Forms.Label();
            this.lblNuevaContrasena = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxAcceso.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresarContrasena
            // 
            this.lblIngresarContrasena.AutoSize = true;
            this.lblIngresarContrasena.Location = new System.Drawing.Point(42, 13);
            this.lblIngresarContrasena.Name = "lblIngresarContrasena";
            this.lblIngresarContrasena.Size = new System.Drawing.Size(101, 13);
            this.lblIngresarContrasena.TabIndex = 0;
            this.lblIngresarContrasena.Text = "Ingrese contraseña:";
            // 
            // txtIngresarContrasena
            // 
            this.txtIngresarContrasena.Location = new System.Drawing.Point(149, 10);
            this.txtIngresarContrasena.Name = "txtIngresarContrasena";
            this.txtIngresarContrasena.PasswordChar = '*';
            this.txtIngresarContrasena.Size = new System.Drawing.Size(130, 20);
            this.txtIngresarContrasena.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtIngresarContrasena.TabIndex = 1;
            this.txtIngresarContrasena.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // gbxAcceso
            // 
            this.gbxAcceso.Controls.Add(this.txtRepetirContrasena);
            this.gbxAcceso.Controls.Add(this.txtNuevaContrasena);
            this.gbxAcceso.Controls.Add(this.lblRepetirContrasena);
            this.gbxAcceso.Controls.Add(this.lblNuevaContrasena);
            this.gbxAcceso.Enabled = false;
            this.gbxAcceso.Location = new System.Drawing.Point(12, 36);
            this.gbxAcceso.Name = "gbxAcceso";
            this.gbxAcceso.Size = new System.Drawing.Size(324, 119);
            this.gbxAcceso.TabIndex = 2;
            this.gbxAcceso.TabStop = false;
            this.gbxAcceso.Text = "Acceso";
            // 
            // txtRepetirContrasena
            // 
            this.txtRepetirContrasena.Location = new System.Drawing.Point(137, 72);
            this.txtRepetirContrasena.Name = "txtRepetirContrasena";
            this.txtRepetirContrasena.PasswordChar = '*';
            this.txtRepetirContrasena.Size = new System.Drawing.Size(130, 20);
            this.txtRepetirContrasena.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtRepetirContrasena.TabIndex = 3;
            this.txtRepetirContrasena.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(137, 27);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '*';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(130, 20);
            this.txtNuevaContrasena.Solo_Lectura = SistemaCentroSalud.Controles.cuTextBox.SoloLectura.falso;
            this.txtNuevaContrasena.TabIndex = 2;
            this.txtNuevaContrasena.TipoCajaTexto = SistemaCentroSalud.Controles.cuTextBox.TipoTextBox.Mixto;
            // 
            // lblRepetirContrasena
            // 
            this.lblRepetirContrasena.AutoSize = true;
            this.lblRepetirContrasena.Location = new System.Drawing.Point(30, 75);
            this.lblRepetirContrasena.Name = "lblRepetirContrasena";
            this.lblRepetirContrasena.Size = new System.Drawing.Size(98, 13);
            this.lblRepetirContrasena.TabIndex = 1;
            this.lblRepetirContrasena.Text = "Repita Contraseña:";
            // 
            // lblNuevaContrasena
            // 
            this.lblNuevaContrasena.AutoSize = true;
            this.lblNuevaContrasena.Location = new System.Drawing.Point(30, 30);
            this.lblNuevaContrasena.Name = "lblNuevaContrasena";
            this.lblNuevaContrasena.Size = new System.Drawing.Size(99, 13);
            this.lblNuevaContrasena.TabIndex = 0;
            this.lblNuevaContrasena.Text = "Nueva Contraseña:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(252, 161);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 31;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(136, 161);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 189);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.gbxAcceso);
            this.Controls.Add(this.txtIngresarContrasena);
            this.Controls.Add(this.lblIngresarContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCambiarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contrasena";
            this.gbxAcceso.ResumeLayout(false);
            this.gbxAcceso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngresarContrasena;
        private SistemaCentroSalud.Controles.cuTextBox txtIngresarContrasena;
        private System.Windows.Forms.GroupBox gbxAcceso;
        private System.Windows.Forms.Label lblNuevaContrasena;
        private SistemaCentroSalud.Controles.cuTextBox txtRepetirContrasena;
        private SistemaCentroSalud.Controles.cuTextBox txtNuevaContrasena;
        private System.Windows.Forms.Label lblRepetirContrasena;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}