using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VETERINARIA.DAL
{
    class ConexionBD
    {
        private static string connectionString =
            "Server=DESKTOP-GLHDV2D\\JESUSNORIEGA;Database=Veterinaria;Integrated Security=True;" +
            "Encrypt =True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
