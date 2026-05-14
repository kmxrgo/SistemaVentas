namespace CapaPresentacion
{
    partial class FrmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusuario.Location = new System.Drawing.Point(185, 95);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(208, 15);
            this.txtusuario.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Location = new System.Drawing.Point(185, 204);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(208, 15);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btningresar
            // 
            this.btningresar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btningresar.FlatAppearance.BorderSize = 0;
            this.btningresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btningresar.ForeColor = System.Drawing.SystemColors.Window;
            this.btningresar.Location = new System.Drawing.Point(242, 259);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(250, 40);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "INGRESAR";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click_1);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnsalir.FlatAppearance.BorderSize = 0;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.SystemColors.Window;
            this.btnsalir.Location = new System.Drawing.Point(539, 0);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(36, 28);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "X";
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 333);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 333);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Location = new System.Drawing.Point(180, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "INGRESO AL SISTEMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Location = new System.Drawing.Point(186, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 2);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Location = new System.Drawing.Point(186, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 2);
            this.panel3.TabIndex = 12;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 333);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLogin";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}