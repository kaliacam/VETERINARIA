using System.Data.SqlClient;
using VETERINARIA.DAL;

namespace VETERINARIA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CargarTiposUsuario();
        }
        private void CargarTiposUsuario()
        {
            CmbTipodeUsuario.Items.Add("Empleado");
            CmbTipodeUsuario.Items.Add("Jefe");
            CmbTipodeUsuario.SelectedIndex = 0; 
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            LblErrorUsuario.Text = "";
            LblErrorUsuario.ForeColor = System.Drawing.Color.Black;
            LblErrorContraseña.Text = "";
            LblErrorContraseña.ForeColor = System.Drawing.Color.Black;

            bool hayErrores = false; 

            // Validaciones
            if (string.IsNullOrWhiteSpace(TxtUsuario.Text))
            {
                LblErrorUsuario.Text = "Por favor, introduce tu nombre de usuario.";
                LblErrorUsuario.ForeColor = System.Drawing.Color.Red;
                hayErrores = true;
            }

            if (string.IsNullOrWhiteSpace(TxtContraseña.Text))
            {
                LblErrorContraseña.Text = "Por favor, introduce tu contraseña.";
                LblErrorContraseña.ForeColor = System.Drawing.Color.Red;
                hayErrores = true;
            }

            if (hayErrores)
            {
                return;
            }

            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    conn.Open();

                    string consulta = "SELECT TipoUsuario FROM USUARIOS WHERE Usuario=@Usuario AND Contraseña=HASHBYTES('SHA2_256', @Contraseña)";

                    Console.WriteLine(consulta);

                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@Usuario", TxtUsuario.Text.Trim());
                        cmd.Parameters.AddWithValue("@Contraseña", TxtContraseña.Text.Trim());

                        using (SqlDataReader lector = cmd.ExecuteReader())
                        {
                            if (lector.HasRows)
                            {
                                lector.Read();
                                string tipoUsuario = lector["TipoUsuario"].ToString();

                                // ... (Código para mensajes de bienvenida) ...

                                MenuVentana Guaf = new MenuVentana();
                                Guaf.Show();
                                this.Hide();
                            }
                            else
                            {
                                LblErrorUsuario.Text = "Usuario o contraseña incorrectos.";
                                LblErrorUsuario.ForeColor = System.Drawing.Color.Red;
                                LblErrorContraseña.Text = ""; 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LblErrorUsuario.Text = "Error al conectar a la base de datos: " + ex.Message;
                LblErrorUsuario.ForeColor = System.Drawing.Color.Red;
                LblErrorContraseña.Text = "";
            }
        }

        private void BtnSalirPrograma_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
