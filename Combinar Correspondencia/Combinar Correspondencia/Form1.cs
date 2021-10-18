using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combinar_Correspondencia
{
    public partial class Form1 : Form 
    {
        private string nombreEmpleado;


        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnImportarExcel_Click(object sender, EventArgs e)
        {
            new ImportarExportar().importarExcel(this.dataGridView1, "Sheet1");
        }

        private void BtnArmarWord_Click(object sender, EventArgs e)
        {
            this.nombreEmpleado = txtNombre.Text;
            new ImportarExportar().ExportarWord(this.dataGridView1, this.txtNombre.Text, this.nombreEmpleado);
        }
    }
}
