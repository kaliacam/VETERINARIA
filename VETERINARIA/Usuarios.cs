using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VETERINARIA
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            string usuario = txtNombreUsuario.Text.Trim();
            string contraseña = txtContraseñaUsuario.Text.Trim();
            string confirmarContraseña = txtConfirmarContraseña.Text.Trim();
            string tipoUsuario = "";
            bool hayErrores = false;

            lblErrorUsuario.Text = "";
            lblErrorContraseña.Text = "";
            lblErrorConfirmarContraseña.Text = "";
            lblErrorTipoUsuario.Text = "";

            // Validación de tipo de usuario
            if (rbnEmpleadoUsuario.Checked)
            {
                tipoUsuario = "Empleado";
            }
            else if (rbnJefeUsuario.Checked)
            {
                tipoUsuario = "Jefe";
            }
            else
            {
                lblErrorTipoUsuario.Text = "Seleccione un tipo de usuario.";
                lblErrorTipoUsuario.ForeColor = Color.Red;
                hayErrores = true;
            }

            // Validación de nombre de usuario
            if (string.IsNullOrWhiteSpace(usuario))
            {
                lblErrorUsuario.Text = "Por favor, ingrese un nombre de usuario.";
                lblErrorUsuario.ForeColor = Color.Red;
                hayErrores = true;
            }
            else if (usuario.Length < 3) // Ejemplo de validación de longitud mínima
            {
                lblErrorUsuario.Text = "El nombre de usuario debe tener al menos 3 caracteres.";
                lblErrorUsuario.ForeColor = Color.Red;
                hayErrores = true;
            }

            // Validación de contraseña
            if (string.IsNullOrWhiteSpace(contraseña))
            {
                lblErrorContraseña.Text = "Por favor, ingrese una contraseña.";
                lblErrorContraseña.ForeColor = Color.Red;
                hayErrores = true;
            }
            else if (contraseña.Length < 6) // Ejemplo de validación de longitud mínima
            {
                lblErrorContraseña.Text = "La contraseña debe tener al menos 6 caracteres.";
                lblErrorContraseña.ForeColor = Color.Red;
                hayErrores = true;
            }

            // Validación de confirmar contraseña
            if (string.IsNullOrWhiteSpace(confirmarContraseña))
            {
                lblErrorConfirmarContraseña.Text = "Por favor, confirme la contraseña.";
                lblErrorConfirmarContraseña.ForeColor = Color.Red;
                hayErrores = true;
            }
            else if (contraseña != confirmarContraseña)
            {
                lblErrorConfirmarContraseña.Text = "Las contraseñas no coinciden.";
                lblErrorConfirmarContraseña.ForeColor = Color.Red;

                hayErrores = true;
            }

            if (hayErrores)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-GLHDV2D\\JESUSNORIEGA;Database=VETERINARIA;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = "INSERT INTO USUARIOS (Usuario, Contraseña, TipoUsuario) VALUES (@Usuario, @Contraseña, @TipoUsuario)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario registrado exitosamente.");
                            txtNombreUsuario.Clear();
                            txtContraseñaUsuario.Clear();
                            txtConfirmarContraseña.Clear();
                            rbnEmpleadoUsuario.Checked = false;
                            rbnJefeUsuario.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar usuario. Vuelva a intentarlo.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2601 || ex.Number == 2627) 
                {
                    MessageBox.Show("El nombre de usuario ya existe. Por favor, elija otro.");
                    lblErrorUsuario.Text = "El nombre de usuario ya existe.";
                    lblErrorUsuario.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuVentana principal = new MenuVentana();
            principal.Show();
            this.Hide();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

        }
    }
}