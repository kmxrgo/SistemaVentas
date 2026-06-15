using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class FrmReporteFactura : Form
    {
        public int idventa;

        public FrmReporteFactura()
        {
            InitializeComponent();
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "CapaPresentacion.RptFactura.rdlc";

            DataTable dtProductos = CNVenta.DetalleFactura(idventa);

            ReportDataSource rds1 = new ReportDataSource("DataSet1", dtProductos);

            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds1);

            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
