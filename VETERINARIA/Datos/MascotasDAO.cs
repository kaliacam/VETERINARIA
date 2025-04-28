using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VETERINARIA.Modelos;

namespace VETERINARIA.Datos
{
    class MascotasDAO
    {
        private string connectionString = "Server=DESKTOP-GLHDV2D\\JESUSNORIEGA;Database=Veterinaria;Integrated Security=True;" +
            "Encrypt =True;TrustServerCertificate=True;";

        public void RegistrarMascota(Mascotass mascota)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    INSERT INTO Mascotas (NombreMascota, TipoMascota, Sexo, Raza, Peso, Edad, Vacunas, TiposVacunas, EnfermedadesCronicas, Alergias, TiposAlergias)
                    VALUES (@NombreMascota, @TipoMascota, @Sexo, @Raza, @Peso, @Edad, @Vacunas, @TiposVacunas, @EnfermedadesCronicas, @Alergias, @TiposAlergias);
                ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NombreMascota", mascota.NombreMascota);
                        command.Parameters.AddWithValue("@TipoMascota", mascota.TipoMascota);
                        command.Parameters.AddWithValue("@Sexo", mascota.Sexo);
                        command.Parameters.AddWithValue("@Raza", mascota.Raza);
                        command.Parameters.AddWithValue("@Peso", mascota.Peso);
                        command.Parameters.AddWithValue("@Edad", mascota.Edad);
                        command.Parameters.AddWithValue("@Vacunas", mascota.Vacunas);
                        command.Parameters.AddWithValue("@TiposVacunas", mascota.TiposVacunas ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@EnfermedadesCronicas", mascota.EnfermedadesCronicas ?? (object)DBNull.Value);
                        command.Parameters.AddWithValue("@Alergias", mascota.Alergias);
                        command.Parameters.AddWithValue("@TiposAlergias", mascota.TiposAlergias ?? (object)DBNull.Value);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes lanzar una excepción personalizada o mostrar un mensaje)
                Console.WriteLine("Lamentamos que haya un error al registrar la mascota, Vuelva intentarlo: " + ex.Message);
            }
        }
    }
}
