using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmEnfermera : Form
    {
        public frmEnfermera()
        {
            InitializeComponent();
        }

        private void frmEnfermera_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
        }

        private void ampliarVentana()
        {
            tbcEnfermera.Width = 784;
            tbcEnfermera.Height = 416;
            this.Width = 791;
            this.Height = 443;
        }

        private void reducirVentana()
        {
            tbcEnfermera.Width = 566;
            tbcEnfermera.Height = 416;
            this.Width = 572;
            this.Height = 443;
        }

        private void tabSiguiente()
        {
            tbpDetalle.Enabled = true;
            tbpBuscar.Enabled = false;

            tbcEnfermera.SelectedTab = tbpDetalle;
        }

        private void tabAnterior()
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            tbcEnfermera.SelectedTab = tbpBuscar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabSiguiente();

            txtPaterno.Focus();
            ampliarVentana();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvEnfermeras.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvEnfermeras.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una enfermera", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void tbcEnfermera_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcEnfermera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcEnfermera.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }
    }
}
