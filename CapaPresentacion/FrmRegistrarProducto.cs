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

using ZXing;
using System.Drawing.Printing;

namespace CapaPresentacion
{
    public partial class FrmRegistrarProducto : Form
    {
        public bool Insert = false;
        public bool Edit = false;
        public FrmRegistrarProducto()
        {
            InitializeComponent();
        }

        private void FrmRegistrarProducto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.CargarCategoria();

            documento.PrintPage += Documento_PrintPage;
        }

        PrintDocument documento = new PrintDocument();

        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (picBarcode.Image != null)
            {
                int ancho = 600;
                int alto = 200;

                int x = (e.PageBounds.Width - ancho) / 2;
                int y = (e.PageBounds.Height - alto) / 3;

                e.Graphics.DrawImage(picBarcode.Image, x, y, ancho, alto);

                SizeF tamañoTexto = e.Graphics.MeasureString(txtcodigo.Text, new Font("Arial", 20, FontStyle.Bold));

                float xTexto = (e.PageBounds.Width - tamañoTexto.Width) / 2;
                float yTexto = y + alto + 20;

                e.Graphics.DrawString(txtcodigo.Text,
                    new Font("Arial", 20, FontStyle.Bold),
                    Brushes.Black,
                    xTexto,
                    yTexto);
            }
        }

        private void CargarCategoria()
        {
            cboidcategoria.DataSource = CNCategoria.Listar();
            cboidcategoria.ValueMember = "idcategoria";
            cboidcategoria.DisplayMember = "descripcion";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string estado = "";

            if (rbactivo.Checked == true)
            {
                estado = "ACTIVO";
            }
            else
            {
                estado = "INACTIVO";
            }

            try
            {
                if (this.txtnombre.Text == string.Empty || this.txtcodigo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese los datos del producto",
                        "Sistema de Ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {

                    this.Insert = true;

                    if (this.Insert == true)
                    {
                        CNProducto.Guardar(
                            this.txtcodigo.Text,
                            this.txtnombre.Text,
                            this.txtdescripcion.Text,
                            this.dtfechaingreso.Value,
                            this.dtfechavencimiento.Value,
                            Convert.ToDouble(this.txtpreciocompra.Text),
                            Convert.ToDouble(this.txtprecioventa.Text),
                            Convert.ToInt32(this.txtcantidad.Text),
                            estado,
                            Convert.ToInt32(this.cboidcategoria.SelectedValue)
                        );

                        MessageBox.Show("Producto registrado correctamente",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    
                    else if (this.Edit == true)
                    {
                        CNProducto.Editar(
                            Convert.ToInt32(this.txtidproducto.Text),
                            this.txtcodigo.Text,
                            this.txtnombre.Text,
                            this.txtdescripcion.Text,
                            this.dtfechaingreso.Value,
                            this.dtfechavencimiento.Value,
                            Convert.ToDouble(this.txtpreciocompra.Text),
                            Convert.ToDouble(this.txtprecioventa.Text),
                            Convert.ToInt32(this.txtcantidad.Text),
                            estado,
                            Convert.ToInt32(this.cboidcategoria.SelectedValue)
                        );

                        MessageBox.Show("Producto editado correctamente",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    
                    this.Insert = false;
                    this.Edit = false;

                    FrmInicio principal = Application.OpenForms["FrmInicio"] as FrmInicio;

                    if (principal != null)
                    {
                        principal.AbrirFormulario(new FrmListadoProducto());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtapellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdni_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void rbtnactivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            FrmInicio principal = Application.OpenForms["FrmInicio"] as FrmInicio;

            if (principal != null)
            {
                principal.AbrirFormulario(new FrmListadoProducto());
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btngenerar_Click(object sender, EventArgs e)
        {

            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Ingrese un código");
                return;
            }

            BarcodeWriter writer = new BarcodeWriter();

            writer.Format = BarcodeFormat.CODE_128;

            writer.Options = new ZXing.Common.EncodingOptions
            {
                Width = picBarcode.Width,
                Height = picBarcode.Height,
                Margin = 20
            };

            picBarcode.Image = writer.Write(txtcodigo.Text);

        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            if (picBarcode.Image == null)
            {
                MessageBox.Show("Primero genera el código de barras");
                return;
            }

            PrintPreviewDialog vista = new PrintPreviewDialog();
            vista.Document = documento;
            vista.ShowDialog();
        }
    }
}
