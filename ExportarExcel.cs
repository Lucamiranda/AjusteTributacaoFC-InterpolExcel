using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace AjusteProdutos
{
    internal class ExportarExcel
    {

        public void ExportarParaExcel(DataGridView dg)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet = new Microsoft.Office.Interop.Excel.Worksheet();

                if (dg.Rows.Count == 0) return;

                //Seleciona todas linhas do datagridview e copia para o clipboard
                dg.RowHeadersVisible = false;
                dg.SelectAll();
                DataObject dataObj = dg.GetClipboardContent();
                if (dataObj != null) Clipboard.SetDataObject(dataObj);

                //Declara as variáveis para usar para referir aos elementos do excel 
                Microsoft.Office.Interop.Excel.Application xlexcel;
                Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
                FolderBrowserDialog pastaSalvar = new FolderBrowserDialog();
                if (pastaSalvar.ShowDialog() == DialogResult.OK)
                {
                    //Cria uma nova instancia do excel
                    xlexcel = new Excel.Application();
                    xlexcel.Visible = false;

                    //Adiciona um workbook
                    xlWorkBook = xlexcel.Workbooks.Add(System.Reflection.Missing.Value);

                    //Pega a primeira planilha do workbook
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                    if(dg.Name == "dgConsultaProd")
                    {
                        //mudando a formatação das celulas para texto
                        xlWorkSheet.Columns.NumberFormat = "@";
                        xlWorkSheet.Columns[5].Style.WrapText = true;
                        xlWorkSheet.Range["A1:N1"].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        xlWorkSheet.Range["A1:N1"].VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;
                        xlWorkSheet.Columns.ColumnWidth = 14;
                        xlWorkSheet.Columns[2].ColumnWidth = 50;
                        xlWorkSheet.Columns[14].ColumnWidth = 15;
                    }
                    else
                    {
                        //mudando a formatação das celulas para texto
                        xlWorkSheet.Columns.NumberFormat = "@";
                        xlWorkSheet.Columns.ColumnWidth = 15;
                    }

                    //Seleciona a primeira célula depois do cabeçalho
                    Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
                    CR.Select();

                    //Cola e Salva o arquivo
                    xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);

                    string path = @"" + pastaSalvar.SelectedPath;

                    switch (dg.Name)
                    {
                        case "dgConsultaProd":
                            xlWorkSheet.Name = "CST-PIS-COFINS";
                            xlexcel.ActiveWorkbook.SaveCopyAs(path + @"\CST-PIS-COFINS.xlsx");
                            break;
                        case "dgConsultaNCM":
                            xlWorkSheet.Name = "NCM-CST-PIS-COFINS";
                            xlexcel.ActiveWorkbook.SaveCopyAs(path + @"\NCM-CST-PIS-COFINS.xlsx");
                            break;
                        default:
                            break;
                    }
                    xlexcel.ActiveWorkbook.Saved = true;
                    MessageBox.Show("Exportação realizada com sucesso", "Exportação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    xlexcel.Quit();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Para a exportação deste arquivo de cotação é necessário ter instalado na máquina o programa Microsoft Excel.","Atenção!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
