using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VETERINARIA.Datos;
using VETERINARIA.Modelos;

namespace VETERINARIA
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuVentana principal = new MenuVentana();
            principal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoServicios productoServicio = new ProductoServicios();
            productoServicio.CorteCabello = checkBoxSICorte.Checked;
            productoServicio.RecorteUnas = checkBoxSIRecorte.Checked;
            productoServicio.Alimentacion = checkBoxSIAlimentacion.Checked;
            productoServicio.DetalleAlimentacion = comboBoxAlimentacion.SelectedItem?.ToString(); // Obtener el valor seleccionado del ComboBox
            productoServicio.AseoSaludable = checkBoxSIAseo.Checked;
            productoServicio.MasajeCorporal = checkBoxSIMasaje.Checked;

            ProductoServicio servicio = new ProductoServicio();
            servicio.RegistrarProductoServicio(productoServicio);

            MessageBox.Show("Producto/servicio registrado correctamente.");
        }
    }
}
