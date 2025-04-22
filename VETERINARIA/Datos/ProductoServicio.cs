using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using VETERINARIA.Modelos;

namespace VETERINARIA.Datos
{
    class ProductoServicio
    {
        private string connectionString = "Server=DESKTOP-GLHDV2D\\JESUSNORIEGA;Database=Veterinaria;Integrated Security=True; " +
            "Encrypt =True;TrustServerCertificate=True;";

        public void RegistrarProductoServicio(ProductoServicios productoServicio)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                    INSERT INTO ProductosServicios (CorteCabello, RecorteUnas, Alimentacion, DetalleAlimentacion, AseoSaludable, MasajeCorporal)
                    VALUES (@CorteCabello, @RecorteUnas, @Alimentacion, @DetalleAlimentacion, @AseoSaludable, @MasajeCorporal);
                ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CorteCabello", productoServicio.CorteCabello);
                        command.Parameters.AddWithValue("@RecorteUnas", productoServicio.RecorteUnas);
                        command.Parameters.AddWithValue("@Alimentacion", productoServicio.Alimentacion);
                        command.Parameters.AddWithValue("@DetalleAlimentacion", productoServicio.DetalleAlimentacion ?? (object)DBNull.Value); // Manejo de valores NULL
                        command.Parameters.AddWithValue("@AseoSaludable", productoServicio.AseoSaludable);
                        command.Parameters.AddWithValue("@MasajeCorporal", productoServicio.MasajeCorporal);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar el servicio, vuelva a intentarlo nuevamente. " + ex.Message);
            }
        }
    }
}
