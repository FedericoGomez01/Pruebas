using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace Unir_Excels
{
    class ImportarExportar
    {
        OleDbConnection conector;
        OleDbDataAdapter adaptador;
        DataTable dt;

        public void importarExcel(DataGridView dgv, string nombreHoja)
        {
            string ruta = "";
            OpenFileDialog archivo = null;
            try
            {
                archivo = new OpenFileDialog();
                archivo.Filter = "Excel Files |*.xlsx";
                archivo.Title = "Seleccione el archivo de Excel";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    if (!archivo.FileName.Equals(""))   
                    {
                        ruta = archivo.FileName;
                    }
                }

                conector = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = " + ruta + "; Extended Properties = \"Excel 8.0;HDR = Yes\"");
                adaptador = new OleDbDataAdapter("select * from [" + nombreHoja + "$]", conector);
                dt = new DataTable();
                adaptador.Fill(dt);
                //dt.Merge(conector.GetSchema("Tablas", null));
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void exportarExcel(DataGridView dataListado)
        {
            Excel.Application exportarExcel = new Excel.Application();
            exportarExcel.Application.Workbooks.Add(true);

            int indiceColumna = 0;
            foreach (DataGridViewColumn columna in dataListado.Columns)
            {
                indiceColumna++;
                exportarExcel.Cells[1, indiceColumna] = columna.Name;
            }

            int indiceFila = 0;
            foreach (DataGridViewRow fila in dataListado.Rows)
            {
                indiceFila++;
                indiceColumna = 0;
                foreach (DataGridViewColumn columna in dataListado.Columns)
                {
                    indiceColumna++;
                    exportarExcel.Cells[indiceFila + 1, indiceColumna] = fila.Cells[columna.Name].Value;
                }
            }
            exportarExcel.Visible = true;
        }
    }
}
