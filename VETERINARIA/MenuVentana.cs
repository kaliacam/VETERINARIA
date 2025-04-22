using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VETERINARIA
{
    public partial class MenuVentana : Form
    {
        public MenuVentana()
        {
            InitializeComponent();
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            cliente.Show();
            this.Hide();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void BtnCitas_Click(object sender, EventArgs e)
        {
            Citas cita = new Citas();
            cita.Show();
            this.Hide();
        }

        private void BtnMascotas_Click(object sender, EventArgs e)
        {
            Mascotas mascotas = new Mascotas();
            mascotas.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Show();
            this.Hide();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Show();
            this.Hide();
        }
    }
}
