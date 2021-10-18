using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Unir_Excels
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarExcel_Click(object sender, EventArgs e)
        {
            ImportarExportar importar = new ImportarExportar();
            importar.importarExcel(this.dgvMuestra, "Horas");
        }

        private void BtCrearCombinado_Click(object sender, EventArgs e)
        {
            new ImportarExportar().exportarExcel(this.dgvMuestra);
        }
    }
}
