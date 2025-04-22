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
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnAgregarUsuario);
            panel2.Location = new Point(1, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 657);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(61, 45);
            label1.Name = "label1";
            label1.Size = new Size(114, 40);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // btnAgregarUsuario
            // 
            btnAgregarUsuario.Location = new Point(61, 508);
            btnAgregarUsuario.Name = "btnAgregarUsuario";
            btnAgregarUsuario.Size = new Size(108, 78);
            btnAgregarUsuario.TabIndex = 4;
            btnAgregarUsuario.Text = "Agregar Usuario";
            btnAgregarUsuario.UseVisualStyleBackColor = true;
            btnAgregarUsuario.Click += btnAgregarUsuario_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 251);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 334);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(667, 509);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(108, 78);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(424, 248);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(332, 27);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtContraseñaUsuario
            // 
            txtContraseñaUsuario.Location = new Point(424, 334);
            txtContraseñaUsuario.Name = "txtContraseñaUsuario";
            txtContraseñaUsuario.PasswordChar = '+';
            txtContraseñaUsuario.Size = new Size(332, 27);
            txtContraseñaUsuario.TabIndex = 3;
            // 
            // rbnEmpleadoUsuario
            // 
            rbnEmpleadoUsuario.AutoSize = true;
            rbnEmpleadoUsuario.Location = new Point(424, 133);
            rbnEmpleadoUsuario.Name = "rbnEmpleadoUsuario";
            rbnEmpleadoUsuario.Size = new Size(98, 24);
            rbnEmpleadoUsuario.TabIndex = 0;
            rbnEmpleadoUsuario.TabStop = true;
            rbnEmpleadoUsuario.Text = "Empleado";
            rbnEmpleadoUsuario.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(512, 58);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 9;
            label4.Text = "Tipo de Usuario";
            // 
            // rbnJefeUsuario
            // 
            rbnJefeUsuario.AutoSize = true;
            rbnJefeUsuario.Location = new Point(639, 133);
            rbnJefeUsuario.Name = "rbnJefeUsuario";
            rbnJefeUsuario.Size = new Size(56, 24);
            rbnJefeUsuario.TabIndex = 1;
            rbnJefeUsuario.TabStop = true;
            rbnJefeUsuario.Text = "Jefe";
            rbnJefeUsuario.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(827, 657);
            Controls.Add(rbnJefeUsuario);
            Controls.Add(label4);
            Controls.Add(rbnEmpleadoUsuario);
            Controls.Add(txtContraseñaUsuario);
            Controls.Add(txtNombreUsuario);
            Controls.Add(btnMenu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "Usuarios";
            Text = "Usuarios";
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
    }
}