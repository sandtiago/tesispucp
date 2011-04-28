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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsComun.tabSiguiente(tbcEnfermera, tbpBuscar, tbpDetalle);

            txtPaterno.Focus();
            clsComun.redimensionarTabControl(tbcEnfermera, 784, 416);
            clsComun.redimensionarVentana(this, 791, 443);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvEnfermeras.SelectedRows.Count > 0)
            {
                clsComun.redimensionarTabControl(tbcEnfermera, 784, 416);
                clsComun.redimensionarVentana(this, 791, 443);
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
                clsComun.redimensionarTabControl(tbcEnfermera, 784, 416);
                clsComun.redimensionarVentana(this, 791, 443);
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
            clsComun.tabAnterior(tbcEnfermera, tbpBuscar, tbpDetalle);

            clsComun.redimensionarTabControl(tbcEnfermera, 566, 416);
            clsComun.redimensionarVentana(this, 572, 443);
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
