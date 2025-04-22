namespace VETERINARIA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            BtnSalirPrograma = new Button();
            BtnIniciarSesion = new Button();
            groupBox2 = new GroupBox();
            LblErrorContraseña = new Label();
            CmbTipodeUsuario = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            TxtUsuario = new TextBox();
            label1 = new Label();
            TxtContraseña = new TextBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            LblErrorUsuario = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Black;
            groupBox1.Controls.Add(BtnSalirPrograma);
            groupBox1.Controls.Add(BtnIniciarSesion);
            groupBox1.Location = new Point(350, 328);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(382, 94);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // BtnSalirPrograma
            // 
            BtnSalirPrograma.BackgroundImage = (Image)resources.GetObject("BtnSalirPrograma.BackgroundImage");
            BtnSalirPrograma.BackgroundImageLayout = ImageLayout.Zoom;
            BtnSalirPrograma.FlatAppearance.BorderSize = 0;
            BtnSalirPrograma.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 255);
            BtnSalirPrograma.FlatAppearance.MouseOverBackColor = Color.Plum;
            BtnSalirPrograma.FlatStyle = FlatStyle.Flat;
            BtnSalirPrograma.Location = new Point(219, 28);
            BtnSalirPrograma.Margin = new Padding(3, 2, 3, 2);
            BtnSalirPrograma.Name = "BtnSalirPrograma";
            BtnSalirPrograma.Size = new Size(108, 48);
            BtnSalirPrograma.TabIndex = 4;
            BtnSalirPrograma.Text = "Salir";
            BtnSalirPrograma.UseVisualStyleBackColor = true;
            BtnSalirPrograma.Click += BtnSalirPrograma_Click;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.BackgroundImage = (Image)resources.GetObject("BtnIniciarSesion.BackgroundImage");
            BtnIniciarSesion.BackgroundImageLayout = ImageLayout.Zoom;
            BtnIniciarSesion.FlatAppearance.BorderSize = 0;
            BtnIniciarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            BtnIniciarSesion.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            BtnIniciarSesion.FlatStyle = FlatStyle.Flat;
            BtnIniciarSesion.ImageAlign = ContentAlignment.TopCenter;
            BtnIniciarSesion.Location = new Point(47, 28);
            BtnIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(108, 48);
            BtnIniciarSesion.TabIndex = 3;
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            BtnIniciarSesion.Click += BtnIniciarSesion_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.RosyBrown;
            groupBox2.Controls.Add(LblErrorUsuario);
            groupBox2.Controls.Add(LblErrorContraseña);
            groupBox2.Controls.Add(CmbTipodeUsuario);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(TxtUsuario);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(TxtContraseña);
            groupBox2.Location = new Point(350, 111);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(382, 185);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // LblErrorContraseña
            // 
            LblErrorContraseña.AutoSize = true;
            LblErrorContraseña.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorContraseña.Location = new Point(149, 68);
            LblErrorContraseña.Name = "LblErrorContraseña";
            LblErrorContraseña.Size = new Size(0, 15);
            LblErrorContraseña.TabIndex = 15;
            // 
            // CmbTipodeUsuario
            // 
            CmbTipodeUsuario.FormattingEnabled = true;
            CmbTipodeUsuario.Location = new Point(149, 130);
            CmbTipodeUsuario.Margin = new Padding(3, 2, 3, 2);
            CmbTipodeUsuario.Name = "CmbTipodeUsuario";
            CmbTipodeUsuario.Size = new Size(203, 23);
            CmbTipodeUsuario.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 137);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 14;
            label3.Text = "Tipo de Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 88);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 13;
            label2.Text = "Contraseña:";
            // 
            // TxtUsuario
            // 
            TxtUsuario.Location = new Point(149, 34);
            TxtUsuario.Margin = new Padding(3, 2, 3, 2);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(203, 23);
            TxtUsuario.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 12;
            label1.Text = "Usuario:";
            // 
            // TxtContraseña
            // 
            TxtContraseña.Location = new Point(149, 85);
            TxtContraseña.Margin = new Padding(3, 2, 3, 2);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.PasswordChar = '-';
            TxtContraseña.Size = new Size(203, 23);
            TxtContraseña.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.RosyBrown;
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(10, 9);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(277, 494);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 43);
            label4.Name = "label4";
            label4.Size = new Size(235, 146);
            label4.TabIndex = 9;
            label4.Text = "Iniciar \r\nSesion";
            // 
            // LblErrorUsuario
            // 
            LblErrorUsuario.AutoSize = true;
            LblErrorUsuario.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblErrorUsuario.Location = new Point(129, 17);
            LblErrorUsuario.Name = "LblErrorUsuario";
            LblErrorUsuario.Size = new Size(0, 15);
            LblErrorUsuario.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(766, 512);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Furry Friends Clinic";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox TxtUsuario;
        private Label label1;
        private TextBox TxtContraseña;
        private GroupBox groupBox3;
        private Label label4;
        private Button BtnSalirPrograma;
        private Button BtnIniciarSesion;
        private Label label3;
        private ComboBox CmbTipodeUsuario;
        private Label LblErrorInicioSesion;
        private Label LblErrorContraseña;
        private Label LblErrorUsuario;
    }
}
