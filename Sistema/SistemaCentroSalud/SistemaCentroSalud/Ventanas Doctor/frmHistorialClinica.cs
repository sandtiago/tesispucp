using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            tbcHistoriaClinica.SelectedTab = tbpDetalle;
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
    }
}
