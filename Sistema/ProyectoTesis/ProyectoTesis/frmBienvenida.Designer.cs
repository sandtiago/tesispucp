namespace ProyectoTesis
{
    partial class frmBienvenida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenida));
            this.sstrContrasena = new System.Windows.Forms.StatusStrip();
            this.lnkContrasena = new System.Windows.Forms.LinkLabel();
            this.pbxBienvenida = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBienvenida)).BeginInit();
            this.SuspendLayout();
            // 
            // sstrContrasena
            // 
            this.sstrContrasena.Location = new System.Drawing.Point(0, 436);
            this.sstrContrasena.Name = "sstrContrasena";
            this.sstrContrasena.Size = new System.Drawing.Size(388, 22);
            this.sstrContrasena.SizingGrip = false;
            this.sstrContrasena.TabIndex = 6;
            this.sstrContrasena.Text = "statusStrip1";
            // 
            // lnkContrasena
            // 
            this.lnkContrasena.AutoSize = true;
            this.lnkContrasena.Location = new System.Drawing.Point(278, 441);
            this.lnkContrasena.Name = "lnkContrasena";
            this.lnkContrasena.Size = new System.Drawing.Size(106, 13);
            this.lnkContrasena.TabIndex = 7;
            this.lnkContrasena.TabStop = true;
            this.lnkContrasena.Text = "Olvidé mi contraseña";
            // 
            // pbxBienvenida
            // 
            this.pbxBienvenida.Image = ((System.Drawing.Image)(resources.GetObject("pbxBienvenida.Image")));
            this.pbxBienvenida.Location = new System.Drawing.Point(0, 0);
            this.pbxBienvenida.Name = "pbxBienvenida";
            this.pbxBienvenida.Size = new System.Drawing.Size(388, 436);
            this.pbxBienvenida.TabIndex = 8;
            this.pbxBienvenida.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(201, 339);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(88, 339);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 13;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(149, 253);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '•';
            this.txtContrasena.Size = new System.Drawing.Size(127, 20);
            this.txtContrasena.TabIndex = 12;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(149, 214);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(127, 20);
            this.txtUsuario.TabIndex = 11;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Image = ((System.Drawing.Image)(resources.GetObject("lblContrasena.Image")));
            this.lblContrasena.Location = new System.Drawing.Point(70, 256);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(61, 13);
            this.lblContrasena.TabIndex = 10;
            this.lblContrasena.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Image = ((System.Drawing.Image)(resources.GetObject("lblUsuario.Image")));
            this.lblUsuario.Location = new System.Drawing.Point(85, 217);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 9;
            this.lblUsuario.Text = "Usuario:";
            // 
            // frmBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 458);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblContrasena);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pbxBienvenida);
            this.Controls.Add(this.lnkContrasena);
            this.Controls.Add(this.sstrContrasena);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            ((System.ComponentModel.ISupportInitialize)(this.pbxBienvenida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip sstrContrasena;
        private System.Windows.Forms.LinkLabel lnkContrasena;
        private System.Windows.Forms.PictureBox pbxBienvenida;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label lblUsuario;
    }
}