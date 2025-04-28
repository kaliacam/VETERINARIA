using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VETERINARIA.DAL;
using VETERINARIA.Modelos;
using System.Text.RegularExpressions; //
using System.Drawing; //

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
            txtTelefonoCliente.Text = "";
            txtCorreoElectronico.Text = "";
            rbnGeneroMasculino.Checked = false;
            rbnGeneroFemenino.Checked = false;
            nupEdadCliente.Value = 0;
            cmbEstadoCivilCliente.SelectedIndex = -1;

            lblErrorNombre.Text = "";
            lblErrorNombre.ForeColor = Color.Black; //
            lblErrorApellidoPaterno.Text = "";
            lblErrorApellidoPaterno.ForeColor = Color.Black;
            lblErrorApellidoMaterno.Text = "";
            lblErrorApellidoMaterno.ForeColor = Color.Black;
            lblErrorTelefono.Text = "";
            lblErrorTelefono.ForeColor = Color.Black;
            lblErrorCorreoElectronico.Text = "";
            lblErrorCorreoElectronico.ForeColor = Color.Black;
            lblErrorEdad.Text = "";
            lblErrorEdad.ForeColor = Color.Black;
            lblErrorEstadoCivil.Text = "";
            lblErrorEstadoCivil.ForeColor = Color.Black;
            lblErrorGenero.Text = "";
            lblErrorGenero.ForeColor = Color.Black;
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mascotas mascotas = new Mascotas();
            mascotas.Show();
            this.Hide();
        }

        private void btnRegistrarRegistro_Click(object sender, EventArgs e)
        {
            bool hayErrores = false;


            lblErrorNombre.Text = "";
            lblErrorNombre.ForeColor = Color.Black;
            lblErrorApellidoPaterno.Text = "";
            lblErrorApellidoPaterno.ForeColor = Color.Black;
            lblErrorApellidoMaterno.Text = "";
            lblErrorApellidoMaterno.ForeColor = Color.Black;
            lblErrorTelefono.Text = "";
            lblErrorTelefono.ForeColor = Color.Black;
            lblErrorCorreoElectronico.Text = "";
            lblErrorCorreoElectronico.ForeColor = Color.Black;
            lblErrorEdad.Text = "";
            lblErrorEdad.ForeColor = Color.Black;
            lblErrorEstadoCivil.Text = "";
            lblErrorEstadoCivil.ForeColor = Color.Black;
            lblErrorGenero.Text = "";
            lblErrorGenero.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(txtIngresarNombre.Text))
            {
                lblErrorNombre.Text = "Ingrese el nombre del cliente.";
                lblErrorNombre.ForeColor = Color.Red; //
                hayErrores = true;
            }
            else if (txtIngresarNombre.Text.Length > 50) //
            {
                lblErrorNombre.Text = "El nombre no puede tener más de 50 caracteres.";
                lblErrorNombre.ForeColor = Color.Red;
                hayErrores = true;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoPaterno.Text))
            {
                lblErrorApellidoPaterno.Text = "Ingrese el apellido paterno.";
                lblErrorApellidoPaterno.ForeColor = Color.Red;
                hayErrores = true;
            }
            else if (txtApellidoPaterno.Text.Length > 50)
            {
                lblErrorApellidoPaterno.Text = "El apellido paterno no puede tener más de 50 caracteres.";
                lblErrorApellidoPaterno.ForeColor = Color.Red;
                hayErrores = true;
            }

            if (string.IsNullOrWhiteSpace(txtApellidoMaterno.Text))
            {
                lblErrorApellidoMaterno.Text = "Ingrese el apellido materno.";
                lblErrorApellidoMaterno.ForeColor = Color.Red;
                hayErrores = true;
            }
            else if (txtApellidoMaterno.Text.Length > 50)
            {
                lblErrorApellidoMaterno.Text = "El apellido materno no puede tener más de 50 caracteres.";
                lblErrorApellidoMaterno.ForeColor = Color.Red;
                hayErrores = true;
            }

            if (string.IsNullOrWhiteSpace(txtTelefonoCliente.Text))
            {
                lblErrorTelefono.Text = "Ingrese el número de teléfono.";
                lblErrorTelefono.ForeColor = Color.Red;
                hayErrores = true;
            }
            else if (!Regex.IsMatch(txtTelefonoCliente.Text, @"^\d{8,15}$")) //
            {
                lblErrorTelefono.Text = "Ingrese un número de teléfono válido (solo números, 8-15 dígitos).";
                lblErrorTelefono.ForeColor = Color.Red;
                hayErrores = true;
            }

            if (string.IsNullOrWhiteSpace(txtCorreoElectronico.Text))
            {
                lblErrorCorreoElectronico.Text = "Ingrese el correo electrónico.";
                lblErrorCorreoElectronico.ForeColor = Color.Red;
                hayErrores = true;
            }
            else if (!Regex.IsMatch(txtCorreoElectronico.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                lblErrorCorreoElectronico.Text = "Ingrese un correo electrónico válido.";
                lblErrorCorreoElectronico.ForeColor = Color.Red;
                hayErrores = true;
            }
            else if (txtCorreoElectronico.Text.Length > 100)
            {
                lblErrorCorreoElectronico.Text = "El correo electrónico no puede tener más de 100 caracteres.";
                lblErrorCorreoElectronico.ForeColor = Color.Red;
                hayErrores = true;
            }

            // Validación de Edad
            if (nupEdadCliente.Value == 0)
            {
                lblErrorEdad.Text = "Ingrese la edad del cliente.";
                lblErrorEdad.ForeColor = Color.Red;
                hayErrores = true;
            }
            else if (nupEdadCliente.Value > 150) 
            {
                lblErrorEdad.Text = "La edad no puede ser mayor a 150 años.";
                lblErrorEdad.ForeColor = Color.Red;
                hayErrores = true;
            }


            if (cmbEstadoCivilCliente.SelectedItem == null)
            {
                lblErrorEstadoCivil.Text = "Seleccione el estado civil.";
                lblErrorEstadoCivil.ForeColor = Color.Red;
                hayErrores = true;
            }

            string genero = "";
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
                lblErrorGenero.Text = "Seleccione el género.";
                lblErrorGenero.ForeColor = Color.Red;
                hayErrores = true;
            }

            if (hayErrores)
            {
                
                return; // Detener el proceso si hay errores
            }

            try
            {
                using (SqlConnection connection = ConexionBD.GetConnection())
                {
                    connection.Open();

                    string query = "INSERT INTO Clientes (Nombre, ApellidoPaterno, ApellidoMaterno, Telefono, CorreoElectronico, Edad, EstadoCivil, Genero) " +
                                   "VALUES (@Nombre, @ApellidoPaterno, @ApellidoMaterno, @Telefono, @CorreoElectronico, @Edad, @EstadoCivil, @Genero)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", txtIngresarNombre.Text);
                        command.Parameters.AddWithValue("@ApellidoPaterno", txtApellidoPaterno.Text);
                        command.Parameters.AddWithValue("@ApellidoMaterno", txtApellidoMaterno.Text);
                        command.Parameters.AddWithValue("@Telefono", txtTelefonoCliente.Text);
                        command.Parameters.AddWithValue("@CorreoElectronico", txtCorreoElectronico.Text);
                        command.Parameters.AddWithValue("@Edad", (int)nupEdadCliente.Value);
                        command.Parameters.AddWithValue("@EstadoCivil", cmbEstadoCivilCliente.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Genero", genero);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Cliente registrado correctamente.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarCampos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error de base de datos al registrar el cliente: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general al registrar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private void lblErrorEstadoCivil_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            BuscarCliente buscar = new BuscarCliente();
            buscar.Show();
        }
    }
}