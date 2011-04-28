using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comun;

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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsComun.tabSiguiente(tbcPerfil, tbpBuscar, tbpDetalle);

            cboArea.Focus();
            clsComun.redimensionarTabControl(tbcPerfil, 570, 318);
            clsComun.redimensionarVentana(this, 575, 345);
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                clsComun.redimensionarTabControl(tbcPerfil, 570, 318);
                clsComun.redimensionarVentana(this, 575, 345);
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
                clsComun.redimensionarTabControl(tbcPerfil, 570, 318);
                clsComun.redimensionarVentana(this, 575, 345);
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
            clsComun.tabAnterior(tbcPerfil, tbpBuscar, tbpDetalle);

            clsComun.redimensionarTabControl(tbcPerfil, 459, 318);
            clsComun.redimensionarVentana(this, 463, 345);
        }
    }
}
