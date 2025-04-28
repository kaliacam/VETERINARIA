using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VETERINARIA.DAL;

namespace VETERINARIA
{
    public partial class BuscarCliente : Form
    {
        public Cliente ClienteSeleccionado { get; private set; }

        public BuscarCliente()
        {
            InitializeComponent();
            CargarTodosLosClientes();
        }

        private void CargarTodosLosClientes()
        {
            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    string query = @"SELECT Nombre, ApellidoPaterno, ApellidoMaterno, 
                                Telefono, CorreoElectronico, Genero, Edad, EstadoCivil 
                                FROM Clientes";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvClientes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar clientes: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string termino = txtBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(termino))
            {
                CargarTodosLosClientes();
                return;
            }

            try
            {
                using (SqlConnection conn = ConexionBD.GetConnection())
                {
                    string query = @"SELECT Nombre, ApellidoPaterno, ApellidoMaterno, 
                                Telefono, CorreoElectronico, Genero, Edad, EstadoCivil 
                                FROM Clientes 
                                WHERE Nombre LIKE @termino OR 
                                      ApellidoPaterno LIKE @termino OR 
                                      ApellidoMaterno LIKE @termino OR
                                      Telefono LIKE @termino OR
                                      CorreoElectronico LIKE @termino";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@termino", $"%{termino}%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvClientes.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar clientes: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

    }


}
