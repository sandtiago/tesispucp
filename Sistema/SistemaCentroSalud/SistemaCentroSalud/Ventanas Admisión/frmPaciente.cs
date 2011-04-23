using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaCentroSalud
{
    public partial class frmPaciente : Form
    {
        public frmPaciente()
        {
            InitializeComponent();
        }

        private void frmPaciente_Load(object sender, EventArgs e)
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;
        }

        private void tabSiguiente()
        {
            tbpDetalle.Enabled = true;
            tbpBuscar.Enabled = false;

            tbcPacientes.SelectedTab = tbpDetalle;
        }

        private void tabAnterior()
        {
            tbpBuscar.Enabled = true;
            tbpDetalle.Enabled = false;

            tbcPacientes.SelectedTab = tbpBuscar;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            tabSiguiente();
            
            txtPaterno.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {

            }
            else
            {
                MessageBox.Show("Debe seleccionar un paciente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tabAnterior();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnTomarFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarFoto_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitarFoto_Click(object sender, EventArgs e)
        {

        }

        private void tbcPacientes_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcPacientes.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }
    }
}
