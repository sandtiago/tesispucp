using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comun;

namespace SistemaCentroSalud
{
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void validarAcceso(string strUsuario, string strContrasena)
        {
            if ((strUsuario.CompareTo("admin") == 0) && (strContrasena.CompareTo("admin") == 0))
            {
                frmPrincipal ventanaPrincipal = new frmPrincipal(this);
                this.Visible = false;
                ventanaPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void limpiarCampos()
        {
            txtContrasena.Clear();
            txtUsuario.Clear();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            validarAcceso(txtUsuario.Text, txtContrasena.Text);
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                validarAcceso(txtUsuario.Text, txtContrasena.Text);
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                validarAcceso(txtUsuario.Text, txtContrasena.Text);
            }
        }
    }
}
