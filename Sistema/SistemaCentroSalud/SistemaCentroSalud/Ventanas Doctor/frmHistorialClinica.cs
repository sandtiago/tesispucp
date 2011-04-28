using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Comun;

namespace SistemaCentroSalud.Ventanas_Doctor
{
    public partial class frmHistorialClinica : Form
    {
        public frmHistorialClinica(bool blnHistoriaClinicaCompleta)
        {
            InitializeComponent();

            if (!blnHistoriaClinicaCompleta)
            {
                tbcHistoriaClinicaPartes.TabPages.Remove(tbpAnamnesis);
                tbcHistoriaClinicaPartes.TabPages.Remove(tbpExamenFisico);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clsComun.tabSiguiente(tbcHistoriaClinica, tbpBuscar, tbpDetalle);
            
            rtxtEctoscopiaActual.Focus();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (dgvHistoriasClinicas.SelectedRows.Count > 0)
            {
            }
            else
            {
                MessageBox.Show("Debe seleccionar una historia clínica", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvHistoriasClinicas.SelectedRows.Count > 0)
            {
            }
            else
            {
                MessageBox.Show("Debe seleccionar una historia clínica", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void tbcHistoriaClinica_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage.Enabled == false)
            {
                e.Cancel = true;
            }
        }

        private void tbcHistoriaClinica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbcHistoriaClinica.SelectedIndex == 1)
            {
                tbpBuscar.Enabled = false;
            }
        }
    }
}
