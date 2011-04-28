using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCentroSalud.Ventanas_Seguridad
{
    public partial class frmPerfil : Form
    {
        public frmPerfil()
        {
            InitializeComponent();
        }

        private void frmPerfil_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
        }

        private void ampliarVentana()
        {
            tbcPerfil.Width = 570;
            tbcPerfil.Height = 318;
            this.Width = 575;
            this.Height = 345;
        }

        private void reducirVentana()
        {
            tbcPerfil.Width = 459;
            tbcPerfil.Height = 318;
            this.Width = 463;
            this.Height = 345;
        }

        private void tabSiguiente()
        {
            tbpDetalle.Enabled = true;
            tbpBuscar.Enabled = false;

            tbcPerfil.SelectedTab = tbpDetalle;
        }

        private void tabAnterior()
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            tbcPerfil.SelectedTab = tbpBuscar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabSiguiente();

            cboArea.Focus();
            ampliarVentana();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un perfil", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabAnterior();

            reducirVentana();
        }
    }
}
