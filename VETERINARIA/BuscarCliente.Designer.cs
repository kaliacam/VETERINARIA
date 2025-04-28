namespace VETERINARIA
{
    partial class BuscarCliente
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
            dgvClientes = new DataGridView();
            txtBusqueda = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // dgvClientes
            // 
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Location = new Point(12, 77);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(869, 361);
            dgvClientes.TabIndex = 0;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(116, 42);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(765, 23);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += textBox1_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(98, 23);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // BuscarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 450);
            Controls.Add(btnBuscar);
            Controls.Add(txtBusqueda);
            Controls.Add(dgvClientes);
            Name = "BuscarCliente";
            Text = "BuscarCliente";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClientes;
        private TextBox txtBusqueda;
        private Button btnBuscar;
    }
}