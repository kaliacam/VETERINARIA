namespace VETERINARIA
{
    partial class MenuVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuVentana));
            BtnCliente = new Button();
            BtnMascotas = new Button();
            BtnCitas = new Button();
            BtnReporte = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnCambiar = new Button();
            label6 = new Label();
            label5 = new Label();
            btnUsuarios = new Button();
            btnServicios = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCliente
            // 
            BtnCliente.BackgroundImage = (Image)resources.GetObject("BtnCliente.BackgroundImage");
            BtnCliente.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCliente.Location = new Point(54, 86);
            BtnCliente.Name = "BtnCliente";
            BtnCliente.Size = new Size(111, 103);
            BtnCliente.TabIndex = 0;
            BtnCliente.UseVisualStyleBackColor = true;
            BtnCliente.Click += BtnCliente_Click;
            // 
            // BtnMascotas
            // 
            BtnMascotas.BackgroundImage = (Image)resources.GetObject("BtnMascotas.BackgroundImage");
            BtnMascotas.BackgroundImageLayout = ImageLayout.Zoom;
            BtnMascotas.Location = new Point(217, 86);
            BtnMascotas.Name = "BtnMascotas";
            BtnMascotas.Size = new Size(111, 103);
            BtnMascotas.TabIndex = 1;
            BtnMascotas.UseVisualStyleBackColor = true;
            BtnMascotas.Click += BtnMascotas_Click;
            // 
            // BtnCitas
            // 
            BtnCitas.BackgroundImage = (Image)resources.GetObject("BtnCitas.BackgroundImage");
            BtnCitas.BackgroundImageLayout = ImageLayout.Zoom;
            BtnCitas.Location = new Point(54, 209);
            BtnCitas.Name = "BtnCitas";
            BtnCitas.Size = new Size(111, 103);
            BtnCitas.TabIndex = 2;
            BtnCitas.UseVisualStyleBackColor = true;
            BtnCitas.Click += BtnCitas_Click;
            // 
            // BtnReporte
            // 
            BtnReporte.BackgroundImage = (Image)resources.GetObject("BtnReporte.BackgroundImage");
            BtnReporte.BackgroundImageLayout = ImageLayout.Zoom;
            BtnReporte.Location = new Point(217, 209);
            BtnReporte.Name = "BtnReporte";
            BtnReporte.Size = new Size(111, 103);
            BtnReporte.TabIndex = 3;
            BtnReporte.UseVisualStyleBackColor = true;
            BtnReporte.Click += BtnReporte_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnCambiar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnUsuarios);
            groupBox1.Controls.Add(btnServicios);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(BtnCliente);
            groupBox1.Controls.Add(BtnReporte);
            groupBox1.Controls.Add(BtnCitas);
            groupBox1.Controls.Add(BtnMascotas);
            groupBox1.Location = new Point(49, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(680, 394);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(507, 263);
            label7.Name = "label7";
            label7.Size = new Size(146, 22);
            label7.TabIndex = 13;
            label7.Text = "Cambiar de usuario";
            // 
            // btnCambiar
            // 
            btnCambiar.BackgroundImage = (Image)resources.GetObject("btnCambiar.BackgroundImage");
            btnCambiar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCambiar.Location = new Point(507, 141);
            btnCambiar.Name = "btnCambiar";
            btnCambiar.Size = new Size(115, 103);
            btnCambiar.TabIndex = 12;
            btnCambiar.UseVisualStyleBackColor = true;
            btnCambiar.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(397, 328);
            label6.Name = "label6";
            label6.Size = new Size(73, 22);
            label6.TabIndex = 11;
            label6.Text = "Usuarios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(397, 42);
            label5.Name = "label5";
            label5.Size = new Size(74, 22);
            label5.TabIndex = 10;
            label5.Text = "Servicios";
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackgroundImage = (Image)resources.GetObject("btnUsuarios.BackgroundImage");
            btnUsuarios.BackgroundImageLayout = ImageLayout.Zoom;
            btnUsuarios.Location = new Point(374, 209);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(114, 103);
            btnUsuarios.TabIndex = 9;
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += button2_Click;
            // 
            // btnServicios
            // 
            btnServicios.BackgroundImage = (Image)resources.GetObject("btnServicios.BackgroundImage");
            btnServicios.BackgroundImageLayout = ImageLayout.Zoom;
            btnServicios.Location = new Point(374, 86);
            btnServicios.Name = "btnServicios";
            btnServicios.Size = new Size(114, 103);
            btnServicios.TabIndex = 8;
            btnServicios.UseVisualStyleBackColor = true;
            btnServicios.Click += btnServicios_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(234, 42);
            label4.Name = "label4";
            label4.Size = new Size(77, 22);
            label4.TabIndex = 7;
            label4.Text = "Mascotas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 328);
            label3.Name = "label3";
            label3.Size = new Size(38, 22);
            label3.TabIndex = 6;
            label3.Text = "Cita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(234, 328);
            label2.Name = "label2";
            label2.Size = new Size(66, 22);
            label2.TabIndex = 5;
            label2.Text = "Reporte";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 42);
            label1.Name = "label1";
            label1.Size = new Size(59, 22);
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            // 
            // MenuVentana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(761, 481);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "MenuVentana";
            Text = "MenuVentana";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button BtnCliente;
        private Button BtnMascotas;
        private Button BtnCitas;
        private Button BtnReporte;
        private GroupBox groupBox1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnUsuarios;
        private Button btnServicios;
        private Label label6;
        private Label label5;
        private Label label7;
        private Button btnCambiar;
    }
}