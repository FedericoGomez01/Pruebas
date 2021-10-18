using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formulario1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            txtConvertido.Text = "";
            string s = "";
            CaracteresConsecutivos c = new CaracteresConsecutivos();
            int cantidad;
            int.TryParse(cmbCantidad.Text, out cantidad);
            s = c.Consecutivos(txtString.Text, cantidad);

            txtConvertido.Text = s;

        }
    }
}
