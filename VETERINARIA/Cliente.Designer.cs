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
            lblErrorNombre = new Label();
            lblErrorCorreoElectronico = new Label();
            lblErrorTelefono = new Label();
            lblErrorApellidoMaterno = new Label();
            lblErrorApellidoPaterno = new Label();
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
            lblErrorGenero = new Label();
            lblErrorEstadoCivil = new Label();
            lblErrorEdad = new Label();
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
            label10 = new Label();
            button2 = new Button();
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
            groupBox1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(791, 44);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Clientes";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 255, 192);
            groupBox2.Controls.Add(lblErrorNombre);
            groupBox2.Controls.Add(lblErrorCorreoElectronico);
            groupBox2.Controls.Add(lblErrorTelefono);
            groupBox2.Controls.Add(lblErrorApellidoMaterno);
            groupBox2.Controls.Add(lblErrorApellidoPaterno);
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
            groupBox2.Location = new Point(10, 73);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(364, 340);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // lblErrorNombre
            // 
            lblErrorNombre.AutoSize = true;
            lblErrorNombre.Location = new Point(101, 42);
            lblErrorNombre.Name = "lblErrorNombre";
            lblErrorNombre.Size = new Size(0, 15);
            lblErrorNombre.TabIndex = 5;
            // 
            // lblErrorCorreoElectronico
            // 
            lblErrorCorreoElectronico.AutoSize = true;
            lblErrorCorreoElectronico.Location = new Point(178, 281);
            lblErrorCorreoElectronico.Name = "lblErrorCorreoElectronico";
            lblErrorCorreoElectronico.Size = new Size(0, 15);
            lblErrorCorreoElectronico.TabIndex = 10;
            // 
            // lblErrorTelefono
            // 
            lblErrorTelefono.AutoSize = true;
            lblErrorTelefono.Location = new Point(111, 221);
            lblErrorTelefono.Name = "lblErrorTelefono";
            lblErrorTelefono.Size = new Size(0, 15);
            lblErrorTelefono.TabIndex = 9;
            // 
            // lblErrorApellidoMaterno
            // 
            lblErrorApellidoMaterno.AutoSize = true;
            lblErrorApellidoMaterno.Location = new Point(157, 155);
            lblErrorApellidoMaterno.Name = "lblErrorApellidoMaterno";
            lblErrorApellidoMaterno.Size = new Size(0, 15);
            lblErrorApellidoMaterno.TabIndex = 8;
            // 
            // lblErrorApellidoPaterno
            // 
            lblErrorApellidoPaterno.AutoSize = true;
            lblErrorApellidoPaterno.Location = new Point(157, 99);
            lblErrorApellidoPaterno.Name = "lblErrorApellidoPaterno";
            lblErrorApellidoPaterno.Size = new Size(0, 15);
            lblErrorApellidoPaterno.TabIndex = 7;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(26, 299);
            txtCorreoElectronico.Margin = new Padding(3, 2, 3, 2);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(279, 23);
            txtCorreoElectronico.TabIndex = 4;
            // 
            // txtTelefonoCliente
            // 
            txtTelefonoCliente.Location = new Point(26, 238);
            txtTelefonoCliente.Margin = new Padding(3, 2, 3, 2);
            txtTelefonoCliente.Name = "txtTelefonoCliente";
            txtTelefonoCliente.Size = new Size(145, 23);
            txtTelefonoCliente.TabIndex = 3;
            // 
            // txtApellidoMaterno
            // 
            txtApellidoMaterno.Location = new Point(26, 172);
            txtApellidoMaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoMaterno.Name = "txtApellidoMaterno";
            txtApellidoMaterno.Size = new Size(279, 23);
            txtApellidoMaterno.TabIndex = 2;
            txtApellidoMaterno.TextChanged += textBox3_TextChanged;
            // 
            // txtApellidoPaterno
            // 
            txtApellidoPaterno.Location = new Point(26, 115);
            txtApellidoPaterno.Margin = new Padding(3, 2, 3, 2);
            txtApellidoPaterno.Name = "txtApellidoPaterno";
            txtApellidoPaterno.Size = new Size(279, 23);
            txtApellidoPaterno.TabIndex = 1;
            // 
            // txtIngresarNombre
            // 
            txtIngresarNombre.Location = new Point(26, 59);
            txtIngresarNombre.Margin = new Padding(3, 2, 3, 2);
            txtIngresarNombre.Name = "txtIngresarNombre";
            txtIngresarNombre.Size = new Size(279, 23);
            txtIngresarNombre.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label5.Location = new Point(26, 282);
            label5.Name = "label5";
            label5.Size = new Size(147, 18);
            label5.TabIndex = 4;
            label5.Text = "Correo Electronico:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label4.Location = new Point(26, 220);
            label4.Name = "label4";
            label4.Size = new Size(75, 18);
            label4.TabIndex = 3;
            label4.Text = "Telefono:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label3.Location = new Point(26, 157);
            label3.Name = "label3";
            label3.Size = new Size(128, 18);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label2.Location = new Point(26, 98);
            label2.Name = "label2";
            label2.Size = new Size(129, 18);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 42);
            label1.Name = "label1";
            label1.Size = new Size(68, 18);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 255, 192);
            groupBox3.Controls.Add(lblErrorGenero);
            groupBox3.Controls.Add(lblErrorEstadoCivil);
            groupBox3.Controls.Add(lblErrorEdad);
            groupBox3.Controls.Add(cmbEstadoCivilCliente);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(nupEdadCliente);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(rbnGeneroFemenino);
            groupBox3.Controls.Add(rbnGeneroMasculino);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Location = new Point(438, 132);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(364, 236);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // lblErrorGenero
            // 
            lblErrorGenero.AutoSize = true;
            lblErrorGenero.Location = new Point(163, 39);
            lblErrorGenero.Name = "lblErrorGenero";
            lblErrorGenero.Size = new Size(0, 15);
            lblErrorGenero.TabIndex = 11;
            // 
            // lblErrorEstadoCivil
            // 
            lblErrorEstadoCivil.AutoSize = true;
            lblErrorEstadoCivil.Location = new Point(162, 144);
            lblErrorEstadoCivil.Name = "lblErrorEstadoCivil";
            lblErrorEstadoCivil.Size = new Size(0, 15);
            lblErrorEstadoCivil.TabIndex = 10;
            lblErrorEstadoCivil.Click += lblErrorEstadoCivil_Click;
            // 
            // lblErrorEdad
            // 
            lblErrorEdad.AutoSize = true;
            lblErrorEdad.Location = new Point(116, 98);
            lblErrorEdad.Name = "lblErrorEdad";
            lblErrorEdad.Size = new Size(0, 15);
            lblErrorEdad.TabIndex = 9;
            // 
            // cmbEstadoCivilCliente
            // 
            cmbEstadoCivilCliente.FormattingEnabled = true;
            cmbEstadoCivilCliente.Items.AddRange(new object[] { "Soltero/Soltera", "Viudo/Viuda", "Casado/Casada", "Separado/Separada", "Union civil o de hecho", "Divorciado/Divorciada" });
            cmbEstadoCivilCliente.Location = new Point(163, 164);
            cmbEstadoCivilCliente.Margin = new Padding(3, 2, 3, 2);
            cmbEstadoCivilCliente.Name = "cmbEstadoCivilCliente";
            cmbEstadoCivilCliente.Size = new Size(133, 23);
            cmbEstadoCivilCliente.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label9.Location = new Point(20, 170);
            label9.Name = "label9";
            label9.Size = new Size(97, 18);
            label9.TabIndex = 6;
            label9.Text = "Estado Civil:";
            // 
            // nupEdadCliente
            // 
            nupEdadCliente.Location = new Point(116, 115);
            nupEdadCliente.Margin = new Padding(3, 2, 3, 2);
            nupEdadCliente.Name = "nupEdadCliente";
            nupEdadCliente.Size = new Size(85, 23);
            nupEdadCliente.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label8.Location = new Point(29, 115);
            label8.Name = "label8";
            label8.Size = new Size(48, 18);
            label8.TabIndex = 4;
            label8.Text = "Edad:";
            // 
            // rbnGeneroFemenino
            // 
            rbnGeneroFemenino.AutoSize = true;
            rbnGeneroFemenino.Location = new Point(248, 58);
            rbnGeneroFemenino.Margin = new Padding(3, 2, 3, 2);
            rbnGeneroFemenino.Name = "rbnGeneroFemenino";
            rbnGeneroFemenino.Size = new Size(78, 19);
            rbnGeneroFemenino.TabIndex = 6;
            rbnGeneroFemenino.TabStop = true;
            rbnGeneroFemenino.Text = "Femenino";
            rbnGeneroFemenino.UseVisualStyleBackColor = true;
            // 
            // rbnGeneroMasculino
            // 
            rbnGeneroMasculino.AutoSize = true;
            rbnGeneroMasculino.Location = new Point(116, 56);
            rbnGeneroMasculino.Margin = new Padding(3, 2, 3, 2);
            rbnGeneroMasculino.Name = "rbnGeneroMasculino";
            rbnGeneroMasculino.Size = new Size(80, 19);
            rbnGeneroMasculino.TabIndex = 5;
            rbnGeneroMasculino.TabStop = true;
            rbnGeneroMasculino.Text = "Masculino";
            rbnGeneroMasculino.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label7.Location = new Point(29, 59);
            label7.Name = "label7";
            label7.Size = new Size(66, 18);
            label7.TabIndex = 1;
            label7.Text = "Genero:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(71, 17);
            label6.Name = "label6";
            label6.Size = new Size(211, 22);
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
            groupBox4.Location = new Point(37, 458);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(718, 78);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // BtnRegistrarMascotas
            // 
            BtnRegistrarMascotas.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrarMascotas.Location = new Point(564, 20);
            BtnRegistrarMascotas.Margin = new Padding(3, 2, 3, 2);
            BtnRegistrarMascotas.Name = "BtnRegistrarMascotas";
            BtnRegistrarMascotas.Size = new Size(98, 44);
            BtnRegistrarMascotas.TabIndex = 12;
            BtnRegistrarMascotas.Text = "Registrar Mascota";
            BtnRegistrarMascotas.UseVisualStyleBackColor = true;
            BtnRegistrarMascotas.Click += button1_Click;
            // 
            // btnSalirCliente
            // 
            btnSalirCliente.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalirCliente.Location = new Point(421, 20);
            btnSalirCliente.Margin = new Padding(3, 2, 3, 2);
            btnSalirCliente.Name = "btnSalirCliente";
            btnSalirCliente.Size = new Size(98, 44);
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
            btnCancelarRegistro.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelarRegistro.Location = new Point(180, 20);
            btnCancelarRegistro.Margin = new Padding(3, 2, 3, 2);
            btnCancelarRegistro.Name = "btnCancelarRegistro";
            btnCancelarRegistro.Size = new Size(98, 44);
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
            btnRegistrarRegistro.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarRegistro.Location = new Point(30, 20);
            btnRegistrarRegistro.Margin = new Padding(3, 2, 3, 2);
            btnRegistrarRegistro.Name = "btnRegistrarRegistro";
            btnRegistrarRegistro.Size = new Size(98, 44);
            btnRegistrarRegistro.TabIndex = 9;
            btnRegistrarRegistro.Text = "Registrar";
            btnRegistrarRegistro.UseVisualStyleBackColor = true;
            btnRegistrarRegistro.Click += btnRegistrarRegistro_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(438, 83);
            label10.Name = "label10";
            label10.Size = new Size(109, 18);
            label10.TabIndex = 4;
            label10.Text = "Editar Cliente:";
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(554, 73);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(98, 44);
            button2.TabIndex = 14;
            button2.Text = "Buscar Cliente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 554);
            Controls.Add(button2);
            Controls.Add(label10);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Cliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Load += Cliente_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupEdadCliente).EndInit();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblErrorNombre;
        private Label lblErrorApellidoPaterno;
        private Label lblErrorApellidoMaterno;
        private Label lblErrorTelefono;
        private Label lblErrorCorreoElectronico;
        private Label lblErrorEdad;
        private Label lblErrorEstadoCivil;
        private Label lblErrorGenero;
        private Label label10;
        private Button button2;
    }
}