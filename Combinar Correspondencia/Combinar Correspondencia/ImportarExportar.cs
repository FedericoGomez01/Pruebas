using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using Word = Microsoft.Office.Interop.Word;


namespace Combinar_Correspondencia
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
                dgv.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ExportarWord(DataGridView dgv,string txtNombre, string nombre)
        {
            try
            {
                if(txtNombre!= "")
                {
                    string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

                    Word.Application objAplicacion = new Word.Application();
                    Word.Document objDocumento = objAplicacion.Documents.Add();

                    Word.Paragraph objTitulo = objDocumento.Content.Paragraphs.Add(Type.Missing);
                    objTitulo.Range.Font.Size = 30;
                    objTitulo.Range.Font.Color = Word.WdColor.wdColorBlack;
                    objTitulo.Range.Font.Bold = 3;
                    objTitulo.Range.Text = "\t\t\t\t\tBANCO ABC";
                    objTitulo.Range.InsertParagraphAfter();

                    Word.Paragraph objParrafo = objDocumento.Content.Paragraphs.Add(Type.Missing);
                    objParrafo.Range.Font.Size = 14;
                    objParrafo.Range.Font.Color = Word.WdColor.wdColorBlack;
                    objParrafo.Range.Text = string.Format("Sr/a: {0} \n\n\t" +
                        "Buenas tardes; nos comunicamos con usted para informarle los saldos que posee al dia" +
                        " de la fecha en nuestro banco. A continuación la lista de cuentas que usted" +
                        " tiene en nuestro banco con su respectivo saldo", txtNombre);
                    objParrafo.Range.InsertParagraphAfter();

                    Word.Paragraph objEncabezado = objDocumento.Content.Paragraphs.Add(Type.Missing);
                    objEncabezado.Range.Font.Size = 14;
                    objEncabezado.Range.Font.Bold = 2;
                    objEncabezado.Range.Font.Color = Word.WdColor.wdColorBlack;
                    objEncabezado.Range.Text = " Número de Cuenta \t\t Saldo ";
                    objEncabezado.Range.InsertParagraphAfter();


                    Word.Paragraph objDatos = objDocumento.Content.Paragraphs.Add(Type.Missing);

                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (row.Cells[0].Value.ToString() == txtNombre)
                            {
                                objDatos.Range.Font.Size = 14;
                                objDatos.Range.Font.Color = Word.WdColor.wdColorBlack;
                                nombre = row.Cells[0].Value.ToString();
                                objDatos.Range.Text = string.Format("\t {0} \t\t {1} \n", row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString());
                            }
                        }
                        else
                        {
                            break;
                        }

                    }
                    objDatos.Range.InsertParagraphAfter();


                    Word.Paragraph objPie = objDocumento.Content.Paragraphs.Add(Type.Missing);
                    objPie.Range.Font.Size = 14;
                    objPie.Range.Font.Color = Word.WdColor.wdColorBlack;
                    objPie.Range.Text = " Muchas gracias, no dude en comunicarse ante cualquier consulta. ";
                    objPie.Range.InsertParagraphAfter();


                    objDocumento.SaveAs2(ruta + $"\\Informe de {nombre}");
                    objDocumento.Close();
                    objAplicacion.Quit();
                }else
                {
                    MessageBox.Show("Ingrese un nombre para el archivo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            
        }
    }
}
