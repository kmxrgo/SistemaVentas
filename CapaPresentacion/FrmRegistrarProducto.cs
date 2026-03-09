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

            if (rbtnactivo.Checked == true)
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
                    if (this.Insert == true)
                    {
                        CNProducto.Guardar(
                            this.txtcodigo.Text,
                            this.txtnombre.Text,
                            this.txtdescripcion.Text,
                            this.dtingreso.Value,
                            this.dtvencimiento.Value,
                            Convert.ToDouble(this.txtpreciocompra.Text),
                            Convert.ToDouble(this.txtprecioventa.Text),
                            Convert.ToInt32(this.txtstock.Text),
                            estado,
                            Convert.ToInt32(this.cbcategoria.SelectedValue)
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
                            this.dtingreso.Value,
                            this.dtvencimiento.Value,
                            Convert.ToDecimal(this.txtpreciocompra.Text),
                            Convert.ToDecimal(this.txtprecioventa.Text),
                            Convert.ToInt32(this.txtstock.Text),
                            estado,
                            Convert.ToInt32(this.cbcategoria.SelectedValue)
                        );

                        MessageBox.Show("Producto editado correctamente",
                            "Sistema de ventas",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }

                    this.Insert = false;
                    this.Edit = false;

                    FrmListadoProducto form = new FrmListadoProducto();
                    form.Show();
                    this.Hide();
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
    }
}
