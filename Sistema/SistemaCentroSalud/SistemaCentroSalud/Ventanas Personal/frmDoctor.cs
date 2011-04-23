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
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
        }

        private void ampliarVentana()
        {
            tbcDoctor.Width = 784;
            tbcDoctor.Height = 416;
            this.Width = 791;
            this.Height = 444;
        }

        private void reducirVentana()
        {
            tbcDoctor.Width = 572;
            tbcDoctor.Height = 416;
            this.Width = 578;
            this.Height = 444;
        }

        private void tabSiguiente()
        {
            tbpDetalle.Enabled = true;
            tbpBuscar.Enabled = false;

            tbcDoctor.SelectedTab = tbpDetalle;
        }

        private void tabAnterior()
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            tbcDoctor.SelectedTab = tbpBuscar;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabAnterior();

            reducirVentana();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabSiguiente();

            txtPaterno.Focus();
            ampliarVentana();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvDoctores.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un doctor", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbcDoctor_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcDoctor.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }
    }
}
