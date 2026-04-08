namespace CapaPresentacion
{
    partial class FrmRegistrarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtidempleado = new System.Windows.Forms.TextBox();
            this.btnbuscarempleado = new System.Windows.Forms.Button();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboacceso = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbactivo = new System.Windows.Forms.RadioButton();
            this.rbinactivo = new System.Windows.Forms.RadioButton();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registar Nuevo Usuario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(12, 73);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(142, 22);
            this.txtnombre.TabIndex = 8;
            // 
            // txtidempleado
            // 
            this.txtidempleado.Location = new System.Drawing.Point(88, 45);
            this.txtidempleado.Name = "txtidempleado";
            this.txtidempleado.Size = new System.Drawing.Size(66, 22);
            this.txtidempleado.TabIndex = 17;
            this.txtidempleado.Visible = false;
            // 
            // btnbuscarempleado
            // 
            this.btnbuscarempleado.Location = new System.Drawing.Point(160, 73);
            this.btnbuscarempleado.Name = "btnbuscarempleado";
            this.btnbuscarempleado.Size = new System.Drawing.Size(75, 23);
            this.btnbuscarempleado.TabIndex = 18;
            this.btnbuscarempleado.Text = "Buscar";
            this.btnbuscarempleado.UseVisualStyleBackColor = true;
            this.btnbuscarempleado.Click += new System.EventHandler(this.btnbuscarempleado_Click);
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(160, 45);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(75, 22);
            this.txtidusuario.TabIndex = 19;
            this.txtidusuario.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellidos";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(12, 169);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(142, 22);
            this.txtapellidos.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ingrese Usuario";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(12, 267);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(142, 22);
            this.txtusuario.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ingrese Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(328, 74);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(142, 22);
            this.txtpassword.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(325, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Tipo Acceso";
            // 
            // cboacceso
            // 
            this.cboacceso.FormattingEnabled = true;
            this.cboacceso.Items.AddRange(new object[] {
            "Administrador",
            "Vendedor",
            "Almacen"});
            this.cboacceso.Location = new System.Drawing.Point(328, 167);
            this.cboacceso.Name = "cboacceso";
            this.cboacceso.Size = new System.Drawing.Size(142, 24);
            this.cboacceso.TabIndex = 27;
            this.cboacceso.Text = "Administrador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(325, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Seleccione estado";
            // 
            // rbactivo
            // 
            this.rbactivo.AutoSize = true;
            this.rbactivo.Location = new System.Drawing.Point(328, 269);
            this.rbactivo.Name = "rbactivo";
            this.rbactivo.Size = new System.Drawing.Size(65, 20);
            this.rbactivo.TabIndex = 29;
            this.rbactivo.TabStop = true;
            this.rbactivo.Text = "Activo";
            this.rbactivo.UseVisualStyleBackColor = true;
            // 
            // rbinactivo
            // 
            this.rbinactivo.AutoSize = true;
            this.rbinactivo.Location = new System.Drawing.Point(399, 267);
            this.rbinactivo.Name = "rbinactivo";
            this.rbinactivo.Size = new System.Drawing.Size(74, 20);
            this.rbinactivo.TabIndex = 30;
            this.rbinactivo.TabStop = true;
            this.rbinactivo.Text = "Inactivo";
            this.rbinactivo.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(426, 349);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 31;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(507, 349);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 23);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // FrmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 384);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbinactivo);
            this.Controls.Add(this.rbactivo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboacceso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtidusuario);
            this.Controls.Add(this.btnbuscarempleado);
            this.Controls.Add(this.txtidempleado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarUsuario";
            this.Text = "FrmRegistrarUsuario";
            this.Load += new System.EventHandler(this.FrmRegistrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txtidempleado;
        public System.Windows.Forms.Button btnbuscarempleado;
        public System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.RadioButton rbactivo;
        public System.Windows.Forms.RadioButton rbinactivo;
        public System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.ComboBox cboacceso;
    }
}