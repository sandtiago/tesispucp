using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comun;

namespace SistemaCentroSalud.Ventanas_Personal
{
    public partial class frmTecnico : Form
    {
        public frmTecnico()
        {
            InitializeComponent();
        }

        private void frmTecnico_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
        }

        private void ampliarVentana()
        {
            tbcTecnico.Width = 784;
            tbcTecnico.Height = 416;
            this.Width = 791;
            this.Height = 443;
        }

        private void reducirVentana()
        {
            tbcTecnico.Width = 469;
            tbcTecnico.Height = 416;
            this.Width = 473;
            this.Height = 443;
        }

        private void tabSiguiente()
        {
            tbpDetalle.Enabled = true;
            tbpBuscar.Enabled = false;

            tbcTecnico.SelectedTab = tbpDetalle;
        }

        private void tabAnterior()
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            tbcTecnico.SelectedTab = tbpBuscar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabSiguiente();

            txtPaterno.Focus();
            ampliarVentana();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvTecnicos.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un técnico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvTecnicos.SelectedRows.Count > 0)
            {
                ampliarVentana();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un técnico", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void tbcTecnico_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcTecnico.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }
    }
}
