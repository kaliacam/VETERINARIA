namespace VETERINARIA
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            label1 = new Label();
            label2 = new Label();
            BtnAcceder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(429, 110);
            label1.Name = "label1";
            label1.Size = new Size(598, 35);
            label1.TabIndex = 0;
            label1.Text = "Les daramos la bienvenida a Furry Friends Clinic\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(491, 145);
            label2.Name = "label2";
            label2.Size = new Size(464, 27);
            label2.TabIndex = 1;
            label2.Text = "\"Because they are more than pets, they are family.\"";
            // 
            // BtnAcceder
            // 
            BtnAcceder.BackColor = Color.Transparent;
            BtnAcceder.Font = new Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnAcceder.Location = new Point(90, 605);
            BtnAcceder.Name = "BtnAcceder";
            BtnAcceder.Size = new Size(123, 63);
            BtnAcceder.TabIndex = 2;
            BtnAcceder.Text = "Acceder";
            BtnAcceder.UseVisualStyleBackColor = false;
            BtnAcceder.Click += BtnAcceder_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 721);
            Controls.Add(BtnAcceder);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VentanaPrincipal";
            Text = "Furry Friends Clinic";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnAcceder;
    }
}