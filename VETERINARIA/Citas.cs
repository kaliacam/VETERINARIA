using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VETERINARIA
{
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuVentana principal = new MenuVentana ();
            principal.Show();
            this.Hide();
        }
    }
}
