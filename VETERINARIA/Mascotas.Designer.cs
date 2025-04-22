namespace VETERINARIA
{
    partial class Mascotas
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
            label1 = new Label();
            groupBox2 = new GroupBox();
            checkBoxAlergiasNO = new CheckBox();
            checkBoxAlergiasSI = new CheckBox();
            label13 = new Label();
            txtNombreMascota = new TextBox();
            label4 = new Label();
            txtRAZAMASCOTA = new TextBox();
            txtTiposAlergias = new TextBox();
            txtEnfermedadesCronicas = new TextBox();
            CmbSexo = new ComboBox();
            checkBoxCovidMascotas = new CheckBox();
            checkBoxHepatitisMascotas = new CheckBox();
            checkBoxMoquilloMascotas = new CheckBox();
            checkBoxParvovirusMascotas = new CheckBox();
            checkBoxRabiaMascotas = new CheckBox();
            RbnVacunasNO = new RadioButton();
            RbnVacunasSI = new RadioButton();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            nudEdadMascota = new NumericUpDown();
            nudPesoMascota = new NumericUpDown();
            cmbTipoMascota = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnRegistrarCita = new Button();
            BtnMenu = new Button();
            btnCancelarMascota = new Button();
            btnEditarMascota = new Button();
            btnRegistrarMascota = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdadMascota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPesoMascota).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1266, 76);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(511, 23);
            label1.Name = "label1";
            label1.Size = new Size(158, 43);
            label1.TabIndex = 0;
            label1.Text = "Mascotas";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBoxAlergiasNO);
            groupBox2.Controls.Add(checkBoxAlergiasSI);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtNombreMascota);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtRAZAMASCOTA);
            groupBox2.Controls.Add(txtTiposAlergias);
            groupBox2.Controls.Add(txtEnfermedadesCronicas);
            groupBox2.Controls.Add(CmbSexo);
            groupBox2.Controls.Add(checkBoxCovidMascotas);
            groupBox2.Controls.Add(checkBoxHepatitisMascotas);
            groupBox2.Controls.Add(checkBoxMoquilloMascotas);
            groupBox2.Controls.Add(checkBoxParvovirusMascotas);
            groupBox2.Controls.Add(checkBoxRabiaMascotas);
            groupBox2.Controls.Add(RbnVacunasNO);
            groupBox2.Controls.Add(RbnVacunasSI);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(nudEdadMascota);
            groupBox2.Controls.Add(nudPesoMascota);
            groupBox2.Controls.Add(cmbTipoMascota);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(38, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1240, 531);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // checkBoxAlergiasNO
            // 
            checkBoxAlergiasNO.AutoSize = true;
            checkBoxAlergiasNO.Location = new Point(809, 444);
            checkBoxAlergiasNO.Name = "checkBoxAlergiasNO";
            checkBoxAlergiasNO.Size = new Size(51, 24);
            checkBoxAlergiasNO.TabIndex = 30;
            checkBoxAlergiasNO.Text = "No";
            checkBoxAlergiasNO.UseVisualStyleBackColor = true;
            checkBoxAlergiasNO.CheckedChanged += checkBoxAlergiasNO_CheckedChanged;
            // 
            // checkBoxAlergiasSI
            // 
            checkBoxAlergiasSI.AutoSize = true;
            checkBoxAlergiasSI.Location = new Point(752, 444);
            checkBoxAlergiasSI.Name = "checkBoxAlergiasSI";
            checkBoxAlergiasSI.Size = new Size(43, 24);
            checkBoxAlergiasSI.TabIndex = 29;
            checkBoxAlergiasSI.Text = "Si";
            checkBoxAlergiasSI.UseVisualStyleBackColor = true;
            checkBoxAlergiasSI.CheckedChanged += checkBoxAlergiasSI_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 74);
            label13.Name = "label13";
            label13.Size = new Size(164, 20);
            label13.TabIndex = 28;
            label13.Text = "Nombre de la Mascota:";
            // 
            // txtNombreMascota
            // 
            txtNombreMascota.Location = new Point(206, 67);
            txtNombreMascota.Name = "txtNombreMascota";
            txtNombreMascota.Size = new Size(167, 27);
            txtNombreMascota.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 265);
            label4.Name = "label4";
            label4.Size = new Size(27, 20);
            label4.TabIndex = 26;
            label4.Text = "Kg";
            // 
            // txtRAZAMASCOTA
            // 
            txtRAZAMASCOTA.Location = new Point(123, 260);
            txtRAZAMASCOTA.Name = "txtRAZAMASCOTA";
            txtRAZAMASCOTA.Size = new Size(175, 27);
            txtRAZAMASCOTA.TabIndex = 25;
            // 
            // txtTiposAlergias
            // 
            txtTiposAlergias.Location = new Point(918, 485);
            txtTiposAlergias.Name = "txtTiposAlergias";
            txtTiposAlergias.Size = new Size(264, 27);
            txtTiposAlergias.TabIndex = 24;
            // 
            // txtEnfermedadesCronicas
            // 
            txtEnfermedadesCronicas.Location = new Point(853, 260);
            txtEnfermedadesCronicas.Name = "txtEnfermedadesCronicas";
            txtEnfermedadesCronicas.Size = new Size(329, 27);
            txtEnfermedadesCronicas.TabIndex = 23;
            // 
            // CmbSexo
            // 
            CmbSexo.FormattingEnabled = true;
            CmbSexo.Items.AddRange(new object[] { "Macho", "Hembra" });
            CmbSexo.Location = new Point(461, 74);
            CmbSexo.Name = "CmbSexo";
            CmbSexo.Size = new Size(116, 28);
            CmbSexo.TabIndex = 22;
            // 
            // checkBoxCovidMascotas
            // 
            checkBoxCovidMascotas.AutoSize = true;
            checkBoxCovidMascotas.Location = new Point(1115, 171);
            checkBoxCovidMascotas.Name = "checkBoxCovidMascotas";
            checkBoxCovidMascotas.Size = new Size(91, 24);
            checkBoxCovidMascotas.TabIndex = 13;
            checkBoxCovidMascotas.Text = "Covid-19";
            checkBoxCovidMascotas.UseVisualStyleBackColor = true;
            // 
            // checkBoxHepatitisMascotas
            // 
            checkBoxHepatitisMascotas.AutoSize = true;
            checkBoxHepatitisMascotas.Location = new Point(1002, 171);
            checkBoxHepatitisMascotas.Name = "checkBoxHepatitisMascotas";
            checkBoxHepatitisMascotas.Size = new Size(91, 24);
            checkBoxHepatitisMascotas.TabIndex = 12;
            checkBoxHepatitisMascotas.Text = "Hepatitis";
            checkBoxHepatitisMascotas.UseVisualStyleBackColor = true;
            // 
            // checkBoxMoquilloMascotas
            // 
            checkBoxMoquilloMascotas.AutoSize = true;
            checkBoxMoquilloMascotas.Location = new Point(887, 171);
            checkBoxMoquilloMascotas.Name = "checkBoxMoquilloMascotas";
            checkBoxMoquilloMascotas.Size = new Size(91, 24);
            checkBoxMoquilloMascotas.TabIndex = 11;
            checkBoxMoquilloMascotas.Text = "Moquillo";
            checkBoxMoquilloMascotas.UseVisualStyleBackColor = true;
            // 
            // checkBoxParvovirusMascotas
            // 
            checkBoxParvovirusMascotas.AutoSize = true;
            checkBoxParvovirusMascotas.Location = new Point(752, 171);
            checkBoxParvovirusMascotas.Name = "checkBoxParvovirusMascotas";
            checkBoxParvovirusMascotas.Size = new Size(97, 24);
            checkBoxParvovirusMascotas.TabIndex = 10;
            checkBoxParvovirusMascotas.Text = "Parvovirus";
            checkBoxParvovirusMascotas.UseVisualStyleBackColor = true;
            // 
            // checkBoxRabiaMascotas
            // 
            checkBoxRabiaMascotas.AutoSize = true;
            checkBoxRabiaMascotas.Location = new Point(662, 171);
            checkBoxRabiaMascotas.Name = "checkBoxRabiaMascotas";
            checkBoxRabiaMascotas.Size = new Size(69, 24);
            checkBoxRabiaMascotas.TabIndex = 9;
            checkBoxRabiaMascotas.Text = "Rabia";
            checkBoxRabiaMascotas.UseVisualStyleBackColor = true;
            // 
            // RbnVacunasNO
            // 
            RbnVacunasNO.AutoSize = true;
            RbnVacunasNO.Location = new Point(898, 80);
            RbnVacunasNO.Name = "RbnVacunasNO";
            RbnVacunasNO.Size = new Size(50, 24);
            RbnVacunasNO.TabIndex = 8;
            RbnVacunasNO.TabStop = true;
            RbnVacunasNO.Text = "No";
            RbnVacunasNO.UseVisualStyleBackColor = true;
            RbnVacunasNO.CheckedChanged += RbnVacunasNO_CheckedChanged;
            // 
            // RbnVacunasSI
            // 
            RbnVacunasSI.AutoSize = true;
            RbnVacunasSI.Location = new Point(835, 80);
            RbnVacunasSI.Name = "RbnVacunasSI";
            RbnVacunasSI.Size = new Size(42, 24);
            RbnVacunasSI.TabIndex = 7;
            RbnVacunasSI.TabStop = true;
            RbnVacunasSI.Text = "Si";
            RbnVacunasSI.UseVisualStyleBackColor = true;
            RbnVacunasSI.CheckedChanged += RbnVacunasSI_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(662, 492);
            label12.Name = "label12";
            label12.Size = new Size(245, 20);
            label12.TabIndex = 17;
            label12.Text = "En caso de que si, seleccione a cual:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(662, 448);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 16;
            label11.Text = "Alergias ?";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(662, 263);
            label10.Name = "label10";
            label10.Size = new Size(165, 20);
            label10.TabIndex = 15;
            label10.Text = "Enfermedades cronicas:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(662, 125);
            label9.Name = "label9";
            label9.Size = new Size(245, 20);
            label9.TabIndex = 14;
            label9.Text = "En caso de que si, seleccione a cual:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(662, 82);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 13;
            label8.Text = "Cuenta con Vacunas?";
            // 
            // nudEdadMascota
            // 
            nudEdadMascota.Location = new Point(123, 454);
            nudEdadMascota.Name = "nudEdadMascota";
            nudEdadMascota.Size = new Size(96, 27);
            nudEdadMascota.TabIndex = 2;
            // 
            // nudPesoMascota
            // 
            nudPesoMascota.Location = new Point(372, 261);
            nudPesoMascota.Name = "nudPesoMascota";
            nudPesoMascota.Size = new Size(123, 27);
            nudPesoMascota.TabIndex = 5;
            // 
            // cmbTipoMascota
            // 
            cmbTipoMascota.FormattingEnabled = true;
            cmbTipoMascota.Items.AddRange(new object[] { "Perro", "Gato", "Gallo", "Gallina", "Tortuga" });
            cmbTipoMascota.Location = new Point(195, 152);
            cmbTipoMascota.Name = "cmbTipoMascota";
            cmbTipoMascota.Size = new Size(151, 28);
            cmbTipoMascota.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 456);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 5;
            label7.Text = "Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 263);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 4;
            label6.Text = "Raza:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 77);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 3;
            label5.Text = "Sexo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 265);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 1;
            label3.Text = "Peso:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 160);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 0;
            label2.Text = "Tipo de Mascota:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRegistrarCita);
            groupBox3.Controls.Add(BtnMenu);
            groupBox3.Controls.Add(btnCancelarMascota);
            groupBox3.Controls.Add(btnEditarMascota);
            groupBox3.Controls.Add(btnRegistrarMascota);
            groupBox3.Location = new Point(133, 679);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(998, 91);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // btnRegistrarCita
            // 
            btnRegistrarCita.Location = new Point(821, 26);
            btnRegistrarCita.Name = "btnRegistrarCita";
            btnRegistrarCita.Size = new Size(124, 51);
            btnRegistrarCita.TabIndex = 20;
            btnRegistrarCita.Text = "Registrar Cita";
            btnRegistrarCita.UseVisualStyleBackColor = true;
            btnRegistrarCita.Click += btnRegistrarCita_Click;
            // 
            // BtnMenu
            // 
            BtnMenu.Location = new Point(641, 26);
            BtnMenu.Name = "BtnMenu";
            BtnMenu.Size = new Size(124, 51);
            BtnMenu.TabIndex = 19;
            BtnMenu.Text = "Menu";
            BtnMenu.UseVisualStyleBackColor = true;
            BtnMenu.Click += button4_Click;
            // 
            // btnCancelarMascota
            // 
            btnCancelarMascota.Location = new Point(466, 26);
            btnCancelarMascota.Name = "btnCancelarMascota";
            btnCancelarMascota.Size = new Size(124, 51);
            btnCancelarMascota.TabIndex = 18;
            btnCancelarMascota.Text = "Cancelar";
            btnCancelarMascota.UseVisualStyleBackColor = true;
            // 
            // btnEditarMascota
            // 
            btnEditarMascota.Location = new Point(276, 26);
            btnEditarMascota.Name = "btnEditarMascota";
            btnEditarMascota.Size = new Size(124, 51);
            btnEditarMascota.TabIndex = 17;
            btnEditarMascota.Text = "Editar";
            btnEditarMascota.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarMascota
            // 
            btnRegistrarMascota.Location = new Point(79, 26);
            btnRegistrarMascota.Name = "btnRegistrarMascota";
            btnRegistrarMascota.Size = new Size(124, 51);
            btnRegistrarMascota.TabIndex = 16;
            btnRegistrarMascota.Text = "Registrar mascota";
            btnRegistrarMascota.UseVisualStyleBackColor = true;
            btnRegistrarMascota.Click += btnRegistrarMascota_Click;
            // 
            // Mascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 797);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Mascotas";
            Text = "Mascotas";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudEdadMascota).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPesoMascota).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private NumericUpDown nudEdadMascota;
        private NumericUpDown nudPesoMascota;
        private ComboBox cmbTipoMascota;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private RadioButton RbnVacunasNO;
        private RadioButton RbnVacunasSI;
        private GroupBox groupBox3;
        private Button BtnMenu;
        private Button btnCancelarMascota;
        private Button btnEditarMascota;
        private Button btnRegistrarMascota;
        private CheckBox checkBoxCovidMascotas;
        private CheckBox checkBoxHepatitisMascotas;
        private CheckBox checkBoxMoquilloMascotas;
        private CheckBox checkBoxParvovirusMascotas;
        private CheckBox checkBoxRabiaMascotas;
        private Button btnRegistrarCita;
        private ComboBox CmbSexo;
        private TextBox txtEnfermedadesCronicas;
        private TextBox txtTiposAlergias;
        private TextBox txtRAZAMASCOTA;
        private Label label4;
        private Label label13;
        private TextBox txtNombreMascota;
        private CheckBox checkBoxAlergiasNO;
        private CheckBox checkBoxAlergiasSI;
    }
}