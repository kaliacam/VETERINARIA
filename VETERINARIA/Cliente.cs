using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VETERINARIA.DAL;
using VETERINARIA.Modelos;

namespace VETERINARIA
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuVentana principal = new MenuVentana();
            principal.Show();
            this.Hide();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            txtIngresarNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtIngresarNombre.Text = "";
            txtCorreoElectronico.Text = "";
            rbnGeneroMasculino.Checked = false;
            rbnGeneroFemenino.Checked = false;
            nupEdadCliente.Value = 0;
            cmbEstadoCivilCliente.SelectedIndex = -1; // Deseleccionar el elemento en el ComboBox
        }
        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            // limpiar las cajas de textos y los radios botone
            txtIngresarNombre.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefonoCliente.Text = "";
            txtCorreoElectronico.Text = "";

            // Botones del genero se limpian
            rbnGeneroFemenino.Checked = false;
            rbnGeneroMasculino.Checked = false;

            // Restablecer el NumericUpDown a 0
            nupEdadCliente.Value = 0;

            // Restablecer el ComboBox al primer elemento (o a un valor cualquier)
            cmbEstadoCivilCliente.SelectedIndex = -1; // -1 para no seleccionar nada

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mascotas mascotas = new Mascotas();
            mascotas.Show();
            this.Hide();
        }

        private void btnRegistrarRegistro_Click(object sender, EventArgs e)
        {
            {

                if (string.IsNullOrWhiteSpace(txtIngresarNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoPaterno.Text) ||
                    string.IsNullOrWhiteSpace(txtApellidoMaterno.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefonoCliente.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreoElectronico.Text) ||
                    nupEdadCliente.Value == 0 || // Asumiendo que tienes numericUpDown
                    cmbEstadoCivilCliente.SelectedItem == null // Verificar si hay un elemento seleccionado
                    )
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                }

                int edad = (int)nupEdadCliente.Value;


                // Creación del objeto Cliente y asignación de valores
                clientes nuevoCliente = new clientes();
                nuevoCliente.Nombre = txtIngresarNombre.Text;
                nuevoCliente.ApellidoPaterno = txtApellidoPaterno.Text;
                nuevoCliente.ApellidoMaterno = txtApellidoMaterno.Text;
                nuevoCliente.Telefono = txtTelefonoCliente.Text;
                nuevoCliente.CorreoElectronico = txtCorreoElectronico.Text;
                nuevoCliente.Edad = (int)nupEdadCliente.Value; // Asumiendo que tienes numericUpDownEdad
                nuevoCliente.EstadoCivil = cmbEstadoCivilCliente.Text;
                string genero = ""; // Valor predeterminado

                // Depuración: Verificar el estado de los Radio Buttons
                Console.WriteLine("radioButtonMasculino.Checked: " + rbnGeneroMasculino.Checked);
                Console.WriteLine("radioButtonFemenino.Checked: " + rbnGeneroFemenino.Checked);

                if (rbnGeneroMasculino.Checked)
                {
                    genero = "Masculino";
                }
                else if (rbnGeneroFemenino.Checked)
                {
                    genero = "Femenino";
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un género.");
                    return; // Detener el registro si no se selecciona un género
                }

                // Código para guardar el cliente en la base de datos
                try
                {
                    using (SqlConnection connection = ConexionBD.GetConnection())
                    {
                        connection.Open();

                        string query = "INSERT INTO Clientes (Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, CorreoElectronico, Edad, EstadoCivil, Genero) " +
                                            "VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Telefono, @CorreoElectronico, @Edad, @EstadoCivil, @Genero)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", nuevoCliente.Nombre);
                            command.Parameters.AddWithValue("@ApellidoPaterno", nuevoCliente.ApellidoPaterno);
                            command.Parameters.AddWithValue("@ApellidoMaterno", nuevoCliente.ApellidoMaterno);
                            command.Parameters.AddWithValue("@Telefono", nuevoCliente.Telefono);
                            command.Parameters.AddWithValue("@CorreoElectronico", nuevoCliente.CorreoElectronico);
                            command.Parameters.AddWithValue("@Edad", edad);
                            command.Parameters.AddWithValue("@EstadoCivil", cmbEstadoCivilCliente.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@Genero", genero);




                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Cliente registrado correctamente.");
                    LimpiarCampos(); // se limpian los campos

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar el cliente: " + ex.Message);
                }
            }
        }
    }
}

