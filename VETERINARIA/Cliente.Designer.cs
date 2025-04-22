namespace VETERINARIA
{
    partial class Cliente
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtCorreoElectronico = new TextBox();
            txtTelefonoCliente = new TextBox();
            txtApellidoMaterno = new TextBox();
            txtApellidoPaterno = new TextBox();
            txtIngresarNombre = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox3 = new GroupBox();
            cmbEstadoCivilCliente = new ComboBox();
            label9 = new Label();
            nupEdadCliente = new NumericUpDown();
            label8 = new Label();
            rbnGeneroFemenino = new RadioButton();
            rbnGeneroMasculino = new RadioButton();
            label7 = new Label();
            label6 = new Label();
            groupBox4 = new GroupBox();
            BtnRegistrarMascotas = new Button();
            btnSalirCliente = new Button();
            btnCancelarRegistro = new Button();
            btnRegistrarRegistro = new Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupEdadCliente).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 255, 192);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(904, 59);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Clientes";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(txtCorreoElectronico);
            groupBox2.Controls.Add(txtTelefonoCliente);
            groupBox2.Controls.Add(txtApellidoMaterno);
            groupBox2.Controls.Add(txtApellidoPaterno);
            groupBox2.Controls.Add(txtIngresarNombre);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(12, 97);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(416, 454);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(30, 399);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(318, 27);
            txtCorreoElectronico.TabIndex = 4;
            txtCorreoElectronico.Text = "Ingresar correo electronico";
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(30, 317);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(165, 27);
            txtTelefonoCliente.TabIndex = 3;
            txtTelefonoCliente.Text = "Ingresar telefono";
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(30, 229);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(318, 27);
            txtApellidoMaterno.TabIndex = 2;
            txtApellidoMaterno.Text = "Ingresar apellido materno";
            txtApellidoMaterno.TextChanged += textBox3_TextChanged;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(30, 153);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(318, 27);
            txtApellidoPaterno.TabIndex = 1;
            txtApellidoPaterno.Text = "Ingresar apellido paterno";
            // 
            // txtIngresarNombre
            // 
            txtIngresarNombre.Location = new Point(30, 79);
            txtIngresarNombre.Name = "txtIngresarNombre";
            txtIngresarNombre.Size = new Size(318, 27);
            txtIngresarNombre.TabIndex = 0;
            txtIngresarNombre.Text = "Ingresar Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label5.Location = new Point(30, 376);
            label5.Name = "label5";
            label5.Size = new Size(181, 21);
            label5.TabIndex = 4;
            label5.Text = "Correo Electronico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label4.Location = new Point(30, 294);
            label4.Name = "label4";
            label4.Size = new Size(93, 21);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label3.Location = new Point(30, 209);
            label3.Name = "label3";
            label3.Size = new Size(158, 21);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label2.Location = new Point(30, 130);
            label2.Name = "label2";
            label2.Size = new Size(162, 21);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 56);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 255, 192);
            groupBox3.Controls.Add(cmbEstadoCivilCliente);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(nupEdadCliente);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(rbnGeneroFemenino);
            groupBox3.Controls.Add(rbnGeneroMasculino);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(500, 176);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(416, 314);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // cmbEstadoCivilCliente
            // 
            cmbEstadoCivilCliente.FormattingEnabled = true;
            cmbEstadoCivilCliente.Items.AddRange(new object[] { "Soltero/Soltera", "Viudo/Viuda", "Casado/Casada", "Separado/Separada", "Union civil o de hecho", "Divorciado/Divorciada" });
            cmbEstadoCivilCliente.Location = new Point(186, 219);
            cmbEstadoCivilCliente.Name = "cmbEstadoCivilCliente";
            cmbEstadoCivilCliente.Size = new Size(151, 28);
            cmbEstadoCivilCliente.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label9.Location = new Point(23, 226);
            label9.Name = "label9";
            label9.Size = new Size(121, 21);
            label9.TabIndex = 6;
            label9.Text = "Estado Civil:";
            // 
            // nupEdadCliente
            // 
            nupEdadCliente.Location = new Point(133, 153);
            nupEdadCliente.Name = "nupEdadCliente";
            nupEdadCliente.Size = new Size(97, 27);
            nupEdadCliente.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label8.Location = new Point(33, 153);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 4;
            label8.Text = "Edad:";
            // 
            // rbnGeneroFemenino
            // 
            rbnGeneroFemenino.AutoSize = true;
            rbnGeneroFemenino.Location = new Point(284, 77);
            rbnGeneroFemenino.Name = "rbnGeneroFemenino";
            rbnGeneroFemenino.Size = new Size(95, 24);
            rbnGeneroFemenino.TabIndex = 6;
            rbnGeneroFemenino.TabStop = true;
            rbnGeneroFemenino.Text = "Femenino";
            rbnGeneroFemenino.UseVisualStyleBackColor = true;
            // 
            // rbnGeneroMasculino
            // 
            rbnGeneroMasculino.AutoSize = true;
            rbnGeneroMasculino.Location = new Point(133, 75);
            rbnGeneroMasculino.Name = "rbnGeneroMasculino";
            rbnGeneroMasculino.Size = new Size(97, 24);
            rbnGeneroMasculino.TabIndex = 5;
            rbnGeneroMasculino.TabStop = true;
            rbnGeneroMasculino.Text = "Masculino";
            rbnGeneroMasculino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label7.Location = new Point(33, 79);
            label7.Name = "label7";
            label7.Size = new Size(82, 21);
            label7.TabIndex = 1;
            label7.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(81, 23);
            label6.Name = "label6";
            label6.Size = new Size(256, 27);
            label6.TabIndex = 0;
            label6.Text = "Informacion Adicional";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(192, 255, 192);
            groupBox4.Controls.Add(BtnRegistrarMascotas);
            groupBox4.Controls.Add(btnSalirCliente);
            groupBox4.Controls.Add(btnCancelarRegistro);
            groupBox4.Controls.Add(btnRegistrarRegistro);
            groupBox4.Location = new Point(42, 610);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(821, 104);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // BtnRegistrarMascotas
            // 
            BtnRegistrarMascotas.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrarMascotas.Location = new Point(644, 26);
            BtnRegistrarMascotas.Name = "BtnRegistrarMascotas";
            BtnRegistrarMascotas.Size = new Size(112, 59);
            BtnRegistrarMascotas.TabIndex = 12;
            BtnRegistrarMascotas.Text = "Registrar Mascota";
            BtnRegistrarMascotas.UseVisualStyleBackColor = true;
            BtnRegistrarMascotas.Click += button1_Click;
            // 
            // btnSalirCliente
            // 
            btnSalirCliente.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirCliente.Location = new Point(481, 26);
            btnSalirCliente.Name = "btnSalirCliente";
            btnSalirCliente.Size = new Size(112, 59);
            btnSalirCliente.TabIndex = 11;
            btnSalirCliente.Text = "Menu ";
            btnSalirCliente.UseVisualStyleBackColor = true;
            btnSalirCliente.Click += button2_Click;
            // 
            // btnCancelarRegistro
            // 
            btnCancelarRegistro.FlatAppearance.BorderSize = 4;
            btnCancelarRegistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnCancelarRegistro.FlatAppearance.MouseOverBackColor = Color.Lime;
            btnCancelarRegistro.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarRegistro.Location = new Point(206, 26);
            btnCancelarRegistro.Name = "btnCancelarRegistro";
            btnCancelarRegistro.Size = new Size(112, 59);
            btnCancelarRegistro.TabIndex = 10;
            btnCancelarRegistro.Text = "Cancelar";
            btnCancelarRegistro.UseVisualStyleBackColor = true;
            btnCancelarRegistro.Click += btnCancelarRegistro_Click;
            // 
            // btnRegistrarRegistro
            // 
            btnRegistrarRegistro.FlatAppearance.BorderSize = 4;
            btnRegistrarRegistro.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 255, 128);
            btnRegistrarRegistro.FlatAppearance.MouseOverBackColor = Color.Yellow;
            btnRegistrarRegistro.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarRegistro.Location = new Point(34, 26);
            btnRegistrarRegistro.Name = "btnRegistrarRegistro";
            btnRegistrarRegistro.Size = new Size(112, 59);
            btnRegistrarRegistro.TabIndex = 9;
            btnRegistrarRegistro.Text = "Registrar";
            btnRegistrarRegistro.UseVisualStyleBackColor = true;
            btnRegistrarRegistro.Click += btnRegistrarRegistro_Click;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 739);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupEdadCliente).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtCorreoElectronico;
        private TextBox txtTelefonoCliente;
        private TextBox txtApellidoMaterno;
        private TextBox txtApellidoPaterno;
        private TextBox txtIngresarNombre;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox3;
        private Label label6;
        private NumericUpDown nupEdadCliente;
        private Label label8;
        private RadioButton rbnGeneroFemenino;
        private RadioButton rbnGeneroMasculino;
        private Label label7;
        private Label label9;
        private GroupBox groupBox4;
        private Button btnCancelarRegistro;
        private Button btnRegistrarRegistro;
        private ComboBox cmbEstadoCivilCliente;
        private Button btnSalirCliente;
        private Button BtnRegistrarMascotas;
    }
}