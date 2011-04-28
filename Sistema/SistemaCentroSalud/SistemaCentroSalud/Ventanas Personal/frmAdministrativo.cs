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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsComun.tabSiguiente(tbcAdministrativo, tbpBuscar, tbpDetalle);

            txtPaterno.Focus();
            clsComun.redimensionarTabControl(tbcAdministrativo, 784, 416);
            clsComun.redimensionarVentana(this, 791, 443);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvAdministrativos.SelectedRows.Count > 0)
            {
                clsComun.redimensionarTabControl(tbcAdministrativo, 784, 416);
                clsComun.redimensionarVentana(this, 791, 443);
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
                clsComun.redimensionarTabControl(tbcAdministrativo, 784, 416);
                clsComun.redimensionarVentana(this, 791, 443);
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
            clsComun.tabAnterior(tbcAdministrativo, tbpBuscar, tbpDetalle);

            clsComun.redimensionarTabControl(tbcAdministrativo, 469, 416);
            clsComun.redimensionarVentana(this, 473, 443);
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
