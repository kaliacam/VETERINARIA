namespace VETERINARIA
{
    partial class Usuarios
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
            panel2 = new Panel();
            label1 = new Label();
            btnAgregarUsuario = new Button();
            label2 = new Label();
            label3 = new Label();
            btnMenu = new Button();
            txtNombreUsuario = new TextBox();
            txtContraseñaUsuario = new TextBox();
            rbnEmpleadoUsuario = new RadioButton();
            label4 = new Label();
            rbnJefeUsuario = new RadioButton();
            label5 = new Label();
            txtConfirmarContraseña = new TextBox();
            lblErrorUsuario = new Label();
            lblErrorContraseña = new Label();
            lblErrorConfirmarContraseña = new Label();
            lblErrorTipoUsuario = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAgregarUsuario);
            panel2.Location = new Point(1, 1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 493);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(53, 34);
            label1.Name = "label1";
            label1.Size = new Size(108, 31);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(53, 381);
            btnAgregarUsuario.Margin = new Padding(3, 2, 3, 2);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(94, 58);
            btnAgregarUsuario.TabIndex = 4;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 188);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 258);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(584, 382);
            btnMenu.Margin = new Padding(3, 2, 3, 2);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(94, 58);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(421, 188);
            txtNombreUsuario.Margin = new Padding(3, 2, 3, 2);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(291, 23);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtContraseñaUsuario
            // 
            txtContraseñaUsuario.Location = new Point(421, 258);
            txtContraseñaUsuario.Margin = new Padding(3, 2, 3, 2);
            txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            txtContraseñaUsuario.PasswordChar = '+';
            txtContraseñaUsuario.Size = new Size(291, 23);
            txtContraseñaUsuario.TabIndex = 3;
            // 
            // rbnEmpleadoUsuario
            // 
            rbnEmpleadoUsuario.AutoSize = true;
            rbnEmpleadoUsuario.Location = new Point(443, 120);
            rbnEmpleadoUsuario.Margin = new Padding(3, 2, 3, 2);
            rbnEmpleadoUsuario.Name = "rbnEmpleadoUsuario";
            rbnEmpleadoUsuario.Size = new Size(78, 19);
            rbnEmpleadoUsuario.TabIndex = 0;
            rbnEmpleadoUsuario.TabStop = true;
            rbnEmpleadoUsuario.Text = "Empleado";
            rbnEmpleadoUsuario.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(502, 79);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 9;
            label4.Text = "Tipo de Usuario";
            // 
            // rbnJefeUsuario
            // 
            rbnJefeUsuario.AutoSize = true;
            rbnJefeUsuario.Location = new Point(584, 120);
            rbnJefeUsuario.Margin = new Padding(3, 2, 3, 2);
            rbnJefeUsuario.Name = "rbnJefeUsuario";
            rbnJefeUsuario.Size = new Size(45, 19);
            rbnJefeUsuario.TabIndex = 1;
            rbnJefeUsuario.TabStop = true;
            rbnJefeUsuario.Text = "Jefe";
            rbnJefeUsuario.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 313);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 10;
            label5.Text = "Confirmar Contraseña:";
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Location = new Point(421, 305);
            txtConfirmarContraseña.Margin = new Padding(3, 2, 3, 2);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.PasswordChar = '+';
            txtConfirmarContraseña.Size = new Size(291, 23);
            txtConfirmarContraseña.TabIndex = 11;
            // 
            // lblErrorUsuario
            // 
            lblErrorUsuario.AutoSize = true;
            lblErrorUsuario.Location = new Point(458, 171);
            lblErrorUsuario.Name = "lblErrorUsuario";
            lblErrorUsuario.Size = new Size(0, 15);
            lblErrorUsuario.TabIndex = 12;
            lblErrorUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblErrorContraseña
            // 
            lblErrorContraseña.AutoSize = true;
            lblErrorContraseña.Location = new Point(458, 241);
            lblErrorContraseña.Name = "lblErrorContraseña";
            lblErrorContraseña.Size = new Size(0, 15);
            lblErrorContraseña.TabIndex = 13;
            lblErrorContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblErrorConfirmarContraseña
            // 
            lblErrorConfirmarContraseña.AutoSize = true;
            lblErrorConfirmarContraseña.Location = new Point(458, 283);
            lblErrorConfirmarContraseña.Name = "lblErrorConfirmarContraseña";
            lblErrorConfirmarContraseña.Size = new Size(0, 15);
            lblErrorConfirmarContraseña.TabIndex = 14;
            lblErrorConfirmarContraseña.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblErrorTipoUsuario
            // 
            lblErrorTipoUsuario.AutoSize = true;
            lblErrorTipoUsuario.Location = new Point(546, 94);
            lblErrorTipoUsuario.Name = "lblErrorTipoUsuario";
            lblErrorTipoUsuario.Size = new Size(0, 15);
            lblErrorTipoUsuario.TabIndex = 15;
            lblErrorTipoUsuario.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 493);
            Controls.Add(lblErrorTipoUsuario);
            Controls.Add(lblErrorConfirmarContraseña);
            Controls.Add(lblErrorContraseña);
            Controls.Add(lblErrorUsuario);
            Controls.Add(txtConfirmarContraseña);
            Controls.Add(label5);
            Controls.Add(rbnJefeUsuario);
            Controls.Add(label4);
            Controls.Add(rbnEmpleadoUsuario);
            Controls.Add(txtContraseñaUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(btnMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Button btnAgregarUsuario;
        private Label label2;
        private Label label3;
        private Button btnMenu;
        private TextBox txtNombreUsuario;
        private TextBox txtContraseñaUsuario;
        private RadioButton rbnEmpleadoUsuario;
        private Label label4;
        private RadioButton rbnJefeUsuario;
        private Label label5;
        private TextBox textBox1;
        private TextBox txtConfirmarContraseña;
        private Label label6;
        private Label lblErrorUsuario;
        private Label lblErrorContraseña;
        private Label lblErrorConfirmarContraseña;
        private Label lblErrorTipoUsuario;
    }
}