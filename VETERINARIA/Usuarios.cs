using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            // Verifica si se seleccionó un tipo de usuario
            string tipoUsuario = "";

            if (rbnEmpleadoUsuario.Checked)
                tipoUsuario = "Empleado"; 

            else if (rbnJefeUsuario.Checked)
                tipoUsuario = "Jefe";

            else
            {
                MessageBox.Show("Seleccione un tipo de usuario.");
                return;
            }

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, ingresa un usuario y una contraseña.");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection("Server=DESKTOP-GLHDV2D\\JESUSNORIEGA;Database=VETERINARIA;Integrated Security=True;"))
                {
                    conn.Open();
                    string query = "INSERT INTO USUARIOS (Usuario, Contraseña, TipoUsuario) VALUES (@Usuario, HASHBYTES('SHA2_256', @Contraseña), @TipoUsuario)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", usuario);
                        cmd.Parameters.AddWithValue("@Contraseña", contraseña);
                        cmd.Parameters.AddWithValue("@TipoUsuario", tipoUsuario);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuario registrado exitosamente.");
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar usuario. Vuelva a intentarlo.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuVentana principal = new MenuVentana();
            principal.Show();
            this.Hide();
        }
    }
}
