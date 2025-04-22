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
using VETERINARIA.Modelos;
using VETERINARIA.DAL;
using VETERINARIA.Datos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VETERINARIA
{
    public partial class Mascotas : Form
    {
        public Mascotas()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuVentana principal = new MenuVentana();
            principal.Show();
            this.Hide();
        }

        private void btnRegistrarCita_Click(object sender, EventArgs e)
        {
            Citas citas = new Citas();
            citas.Show();
            this.Hide();
        }

        private void btnRegistrarMascota_Click(object sender, EventArgs e)
        {
            try
            {
                Mascotass mascota = new Mascotass();
                mascota.NombreMascota = txtNombreMascota.Text;
                mascota.TipoMascota = cmbTipoMascota.SelectedItem.ToString();
                mascota.Sexo = CmbSexo.SelectedItem.ToString();
                mascota.Raza = txtRAZAMASCOTA.Text;
                mascota.Peso = nudPesoMascota.Value;
                mascota.Edad = (int)nudEdadMascota.Value;
                mascota.Vacunas = RbnVacunasSI.Checked;

                // Construir la cadena de tipos de vacunas
                List<string> vacunasSeleccionadas = new List<string>();
                if (checkBoxRabiaMascotas.Checked) vacunasSeleccionadas.Add("Rabia");
                if (checkBoxParvovirusMascotas.Checked) vacunasSeleccionadas.Add("Parvovirus");
                if (checkBoxMoquilloMascotas.Checked) vacunasSeleccionadas.Add("Moquillo");
                if (checkBoxHepatitisMascotas.Checked) vacunasSeleccionadas.Add("Hepatitis");
                if (checkBoxCovidMascotas.Checked) vacunasSeleccionadas.Add("Covid-19");
                mascota.TiposVacunas = string.Join(", ", vacunasSeleccionadas);

                mascota.EnfermedadesCronicas = txtEnfermedadesCronicas.Text;
                mascota.Alergias = checkBoxAlergiasSI.Checked;
                mascota.Alergias = checkBoxAlergiasNO.Checked;
                mascota.TiposAlergias = txtTiposAlergias.Text;

                MascotasDAO mascotasDAO = new MascotasDAO();
                mascotasDAO.RegistrarMascota(mascota);

                MessageBox.Show("Mascota registrada correctamente.");
            }

            catch (Exception ex)
            {

                MessageBox.Show("Error al registrar la mascota: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RbnVacunasSI_CheckedChanged(object sender, EventArgs e)
        {
            //Habilitar los botones cuando le ponen que si
            checkBoxRabiaMascotas.Enabled = RbnVacunasSI.Checked;
            checkBoxCovidMascotas.Enabled = RbnVacunasSI.Checked;
            checkBoxHepatitisMascotas.Enabled = RbnVacunasSI.Checked;
            checkBoxMoquilloMascotas.Enabled = RbnVacunasSI.Checked;
            checkBoxParvovirusMascotas.Enabled = RbnVacunasSI.Checked;

            // si se cambia a que la respuesta es un "NO" se va desesmarcar todos los checkbox de alergias
            if (RbnVacunasNO.Checked)
            {
                checkBoxRabiaMascotas.Checked = false;
                checkBoxCovidMascotas.Checked = false;
                checkBoxHepatitisMascotas.Checked = false;
                checkBoxMoquilloMascotas.Checked = false;
                checkBoxParvovirusMascotas.Checked = false;
            }
        }

        private void RbnVacunasNO_CheckedChanged(object sender, EventArgs e)
        {
            // se van a desabilitar y desmarcar todos los CheckBoxes cuando se selecciona "No"
            if (RbnVacunasNO.Checked)
            {
                checkBoxRabiaMascotas.Enabled = false;
                checkBoxParvovirusMascotas.Enabled = false;
                checkBoxMoquilloMascotas.Enabled = false;
                checkBoxHepatitisMascotas.Enabled = false;
                checkBoxCovidMascotas.Enabled = false;

                checkBoxRabiaMascotas.Checked = false;
                checkBoxParvovirusMascotas.Checked = false;
                checkBoxMoquilloMascotas.Checked = false;
                checkBoxHepatitisMascotas.Checked = false;
                checkBoxCovidMascotas.Checked = false;
            }
        }

        private void checkBoxAlergiasSI_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlergiasSI.Checked)
            {
                // Si "Si" está marcado, habilita el TextBox para escribir
                txtTiposAlergias.Enabled = true;
            }
            else
            {
                // Si "Si" no está marcado, deshabilita el TextBox y borra su contenido
                txtTiposAlergias.Enabled = false;
                txtTiposAlergias.Text = "";
            }
        }

        private void checkBoxAlergiasNO_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAlergiasNO.Checked)
            {
                // Si "No" está marcado, deshabilita el TextBox y borra su contenido
                txtTiposAlergias.Enabled = false;
                txtTiposAlergias.Text = "";
            }
            else
            {
                // Si "No" no está marcado, habilita el TextBox (si "Si" está marcado)
                if (checkBoxAlergiasNO.Checked)
                {
                    txtTiposAlergias.Enabled = true;
                }
            }
        }
    }
}
