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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Datos = CNUsuario.Logeo(
                    txtusuario.Text,
                    txtpassword.Text
                );

                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos",
                        "Sistema de ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    FrmInicio frm = new FrmInicio();
                    frm.usuario = Datos.Rows[0]["usuario"].ToString();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btningresar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable Datos = CNUsuario.Logeo(
                    txtusuario.Text,
                    txtpassword.Text
                );

                if (Datos.Rows.Count == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos",
                        "Sistema de ventas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    FrmInicio frm = new FrmInicio();
                    frm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
