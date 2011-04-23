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
    public partial class frmAdministrativo : Form
    {
        public frmAdministrativo()
        {
            InitializeComponent();
        }

        private void frmAdministrativo_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
        }

        private void ampliarVentana()
        {
            tbcAdministrativo.Width = 784;
            tbcAdministrativo.Height = 416;
            this.Width = 791;
            this.Height = 443;
        }

        private void reducirVentana()
        {
            tbcAdministrativo.Width = 469;
            tbcAdministrativo.Height = 416;
            this.Width = 473;
            this.Height = 443;
        }

        private void tabSiguiente()
        {
            tbpDetalle.Enabled = true;
            tbpBuscar.Enabled = false;

            tbcAdministrativo.SelectedTab = tbpDetalle;
        }

        private void tabAnterior()
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            tbcAdministrativo.SelectedTab = tbpBuscar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabSiguiente();

            txtPaterno.Focus();
            ampliarVentana();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un empleado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void tbcAdministrativo_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcAdministrativo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcAdministrativo.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }
    }
}
