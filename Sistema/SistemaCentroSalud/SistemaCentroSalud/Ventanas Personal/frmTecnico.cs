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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsComun.tabSiguiente(tbcTecnico, tbpBuscar, tbpDetalle);

            txtPaterno.Focus();
            clsComun.redimensionarTabControl(tbcTecnico, 784, 416);
            clsComun.redimensionarVentana(this, 791, 443);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvTecnicos.SelectedRows.Count > 0)
            {
                clsComun.redimensionarTabControl(tbcTecnico, 784, 416);
                clsComun.redimensionarVentana(this, 791, 443);
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
                clsComun.redimensionarTabControl(tbcTecnico, 784, 416);
                clsComun.redimensionarVentana(this, 791, 443);
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
            clsComun.tabAnterior(tbcTecnico, tbpBuscar, tbpDetalle);

            clsComun.redimensionarTabControl(tbcTecnico, 469, 416);
            clsComun.redimensionarVentana(this, 473, 443);
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
