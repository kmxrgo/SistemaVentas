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
    public partial class FrmGenerarVenta : Form
    {
        public FrmGenerarVenta()
        {
            InitializeComponent();
        }

        private void txtVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {

            FrmListadoProducto frm = new FrmListadoProducto();
            frm.ShowDialog();

            txtProducto.Text = frm.NombreProducto;
            txtProducto.Tag = frm.IdProducto;
            txtPrecio.Text = frm.Precio.ToString();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtProducto.Text == "")
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            if (txtPrecio.Text == "")
            {
                MessageBox.Show("Precio inválido");
                return;
            }

            int fila = dataGridView1.Rows.Add();

            dataGridView1.Rows[fila].Cells["IdProducto"].Value = txtProducto.Tag;
            dataGridView1.Rows[fila].Cells["Descripcion"].Value = txtProducto.Text;
            dataGridView1.Rows[fila].Cells["Precio"].Value = txtPrecio.Text;
            dataGridView1.Rows[fila].Cells["Cantidad"].Value = numCantidad.Value;

            decimal total = Convert.ToDecimal(txtPrecio.Text) * numCantidad.Value;
            dataGridView1.Rows[fila].Cells["Total"].Value = total;

            CalcularTotal();

            // limpiar campos
            txtProducto.Clear();
            txtPrecio.Clear();
            numCantidad.Value = 0;
        }

        private void CalcularTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Total"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }

            lblTotal.Text = total.ToString("0.00");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Tag == null)
            {
                MessageBox.Show("Seleccione un cliente");
                return;
            }

            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Agregue productos");
                return;
            }

            int idcliente = Convert.ToInt32(txtCliente.Tag);
            int idusuario = 1; // después lo haces dinámico
            decimal total = Convert.ToDecimal(lblTotal.Text);

            DataTable dt = new DataTable();

            dt.Columns.Add("IdProducto");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Precio");
            dt.Columns.Add("Total");

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["IdProducto"].Value != null)
                {
                    dt.Rows.Add(
                        row.Cells["IdProducto"].Value,
                        row.Cells["Cantidad"].Value,
                        row.Cells["Precio"].Value,
                        row.Cells["Total"].Value
                    );
                }
            }

            CNVenta.InsertarVenta(idcliente, idusuario, total, dt);

            MessageBox.Show("Venta guardada correctamente");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmGenerarVenta_Load(object sender, EventArgs e)
        {
            txtCliente.Text = "CLIENTE GENERAL";
            txtCliente.Tag = 1;
        }
    }
}
