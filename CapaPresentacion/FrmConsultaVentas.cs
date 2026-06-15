using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmConsultaVentas : Form
    {
        public FrmConsultaVentas()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = CNVenta.ListarVentas(dtInicio.Value, dtFin.Value);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {

            if (dgvVentas.CurrentRow != null)
            {
                int idventa = Convert.ToInt32(dgvVentas.CurrentRow.Cells["idventa"].Value);

                FrmReporteFactura form = new FrmReporteFactura();
                form.idventa = idventa;

                FrmInicio principal = Application.OpenForms["FrmInicio"] as FrmInicio;

                if (principal != null)
                {
                    principal.AbrirFormulario(form);
                }
            }
        }
    }
}
