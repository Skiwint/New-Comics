using iTextSharp.text;
using iTextSharp.text.pdf;
using Maroquio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace Admin.Froms
{
    public partial class SearchForm : Form
    {
        AllModel<Comics> comics = new AllModel<Comics>("Comics");
        AllModel<Sale> sales = new AllModel<Sale>("Sales");
        AllModel<Employee> employes = new AllModel<Employee>("Employees");
        AllModel<Supplier> supliers = new AllModel<Supplier>("Suppliers");
        public string[] SelTB =
        {
            "Комиксы",
            "Продажи",
            "Сотрудники",
            "Поставщики",
        };
        public int x;
        public string[] SelEx =
        {
            "Excel",
            "PDF",
            "CSV",
            "WORD",
        };
        public string[] VidSort =
        {
            "По возрастанию",
            "По убыванию",
        };
        public SearchForm()
        {
            InitializeComponent();
            DataExp.ForeColor = Color.Black;
            DataSort.ForeColor = Color.Black;
            DataSearchSh.ForeColor = Color.Black;   
            GetTB();
            GetEX();
            GetSort();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (x == 0)
            {
                Menu menu = new Menu();
                this.Hide();
                menu.Show();
            }
            else
            {
                RegistrationForms registrationForms = new RegistrationForms();
                this.Hide();
                registrationForms.Show();
            }
        }

        private void SearchForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SelectTabel_Click(object sender, EventArgs e)
        {
            switch (TablEx.SelectedIndex)
            {
                case 0:
                    {
                        DataExp.DataSource = comics.Objs;
                        DataExp.Refresh();
                    }
                    break;

                case 1:
                    {
                        DataExp.DataSource = sales.Objs;
                        DataExp.Refresh();
                    }
                    break;

                case 2:
                    {
                        DataExp.DataSource = employes.Objs;
                        DataExp.Refresh();
                    }
                    break;

                case 3:
                    {
                        DataExp.DataSource = supliers.Objs;
                        DataExp.Refresh();
                    }
                    break;
            }
        }

        private void ExBtn_Click(object sender, EventArgs e)
        {
            switch (SelectExp.SelectedIndex)
            {
                case 0:
                    {
                        ExcepExport(DataExp);
                    }
                    break;

                case 1:
                    {
                        PdfExport(DataExp);
                    }
                    break;

                case 2:
                    {
                        CsvExport(DataExp);
                    }
                    break;

                case 3:
                    {
                        SaveFileDialog sfd = new SaveFileDialog();

                        sfd.Filter = "Word Documents (.docx)|.docx";

                        sfd.FileName = "export.docx";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            WordExport(DataExp, sfd.FileName);
                        }
                    }
                    break;
            }
            
        }

        private void GetTB()
        {
            TablEx.Items.Add(SelTB[0]);
            TablEx.Items.Add(SelTB[1]);
            TablEx.Items.Add(SelTB[2]);
            TablEx.Items.Add(SelTB[3]);
            TablEx.SelectedIndex = 0;
        }

        private void GetEX()
        {
            SelectExp.Items.Add(SelEx[0]);
            SelectExp.Items.Add(SelEx[1]);
            SelectExp.Items.Add(SelEx[2]);
            SelectExp.Items.Add(SelEx[3]);
            SelectExp.SelectedIndex = 0;
        }

        private void GetSort()
        {
            SorTablBox.Items.Add(SelTB[0]);
            SorTablBox.Items.Add(SelTB[1]);
            SorTablBox.Items.Add(SelTB[2]);
            SorTablBox.Items.Add(SelTB[3]);
            SorTablBox.SelectedIndex = 0;

            SortirBox.Items.Add(VidSort[0]);
            SortirBox.Items.Add(VidSort[1]);
            SortirBox.SelectedIndex = 0;

            SortExport.Items.Add(SelEx[0]);
            SortExport.Items.Add(SelEx[1]);
            SortExport.Items.Add(SelEx[2]);
            SortExport.Items.Add(SelEx[3]);
            SortExport.SelectedIndex = 0;


            SelectVidSearch.Items.Add(SelTB[0]);
            SelectVidSearch.Items.Add(SelTB[1]);
            SelectVidSearch.Items.Add(SelTB[2]);
            SelectVidSearch.Items.Add(SelTB[3]);
            SelectVidSearch.SelectedIndex = 0;
        }

        public void ExcepExport(DataGridView dataGrid)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                app.Visible = false;
                Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
                Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
                ws.Name = "Exported from gridview";

                ws.Rows.HorizontalAlignment = HorizontalAlignment.Center;
                for (int i = 1; i < dataGrid.Columns.Count + 1; i++)
                {
                    ws.Cells[1, i] = dataGrid.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dataGrid.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGrid.Columns.Count; j++)
                    {
                        ws.Cells[i + 2, j + 1] = dataGrid.Rows[i].Cells[j].Value;
                    }
                }

                ws.Cells.EntireColumn.AutoFit();

                app.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CsvExport(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGrid.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGrid.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGrid.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGrid.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGrid.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }
        }

        public void WordExport(DataGridView dataGrid, string filename)
        {
            if (dataGrid.Rows.Count != 0)
            {
                int RowCount = dataGrid.Rows.Count;
                int ColumnCount = dataGrid.Columns.Count;
                Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

                //add rows
                int r = 0;
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    for (r = 0; r <= RowCount - 1; r++)
                    {
                        DataArray[r, c] = dataGrid.Rows[r].Cells[c].Value;
                    } //end row loop
                } //end column loop

                Microsoft.Office.Interop.Word.Document oDoc = new Microsoft.Office.Interop.Word.Document();
                oDoc.Application.Visible = true;

                //page orintation
                oDoc.PageSetup.Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientLandscape;


                dynamic oRange = oDoc.Content.Application.Selection.Range;
                string oTemp = "";
                for (r = 0; r <= RowCount - 1; r++)
                {
                    for (int c = 0; c <= ColumnCount - 1; c++)
                    {
                        oTemp = oTemp + DataArray[r, c] + "\t";

                    }
                }

                //table format
                oRange.Text = oTemp;

                object Separator = Microsoft.Office.Interop.Word.WdTableFieldSeparator.wdSeparateByTabs;
                object ApplyBorders = true;
                object AutoFit = true;
                object AutoFitBehavior = Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent;

                oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
                                      Type.Missing, Type.Missing, ref ApplyBorders,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, Type.Missing, Type.Missing,
                                      Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

                oRange.Select();

                oDoc.Application.Selection.Tables[1].Select();
                oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
                oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.InsertRowsAbove(1);
                oDoc.Application.Selection.Tables[1].Rows[1].Select();

                //header row style
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
                oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

                //add header row manually
                for (int c = 0; c <= ColumnCount - 1; c++)
                {
                    oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = dataGrid.Columns[c].HeaderText;
                }

                //table style 
                //oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
                oDoc.Application.Selection.Tables[1].Rows[1].Select();
                oDoc.Application.Selection.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;

                //header text
                foreach (Microsoft.Office.Interop.Word.Section section in oDoc.Application.ActiveDocument.Sections)
                {
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.Text = "";
                    headerRange.Font.Size = 16;
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                }

                //save the file
                oDoc.SaveAs2(filename);

                //NASSIM LOUCHANI
            }
        }

        public void PdfExport(DataGridView dataGrid)
        {
            if (dataGrid.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "PDF (*.pdf)|*.pdf";
                sfd.FileName = "PFDFile.pdf";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("Записать данные на диск не удалось." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            PdfPTable pdfTable = new PdfPTable(dataGrid.Columns.Count);
                            pdfTable.DefaultCell.Padding = 3;
                            pdfTable.WidthPercentage = 100;
                            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            foreach (DataGridViewColumn column in dataGrid.Columns)
                            {
                                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                                pdfTable.AddCell(cell);
                            }

                            foreach (DataGridViewRow row in dataGrid.Rows)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    pdfTable.AddCell(cell.Value.ToString());
                                }
                            }

                            using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
                            {
                                Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                                PdfWriter.GetInstance(pdfDoc, stream);
                                pdfDoc.Open();
                                pdfDoc.Add(pdfTable);
                                pdfDoc.Close();
                                stream.Close();
                            }

                            MessageBox.Show("Данные Успешно Экспортированы!!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void SelectTableSort_Click(object sender, EventArgs e)
        {
            switch (SorTablBox.SelectedIndex)
            {
                case 0:
                    {
                        DataSort.DataSource = new SortableBindingList<Comics>(comics.Objs);
                        DataSort.Refresh();
                    }
                    break;

                case 1:
                    {
                        DataSort.DataSource = new SortableBindingList<Sale>(sales.Objs);
                        DataSort.Refresh();
                    }
                    break;

                case 2:
                    {
                        DataSort.DataSource = new SortableBindingList<Employee>(employes.Objs);
                        DataSort.Refresh();
                    }
                    break;

                case 3:
                    {
                        DataSort.DataSource = new SortableBindingList<Supplier>(supliers.Objs);
                        DataSort.Refresh();
                    }
                    break;
            }
        }

        private void SortableBtn_Click(object sender, EventArgs e)
        {
            switch (SortirBox.SelectedIndex)
            {
                case 0:
                    {
                        DataSort.Sort(DataSort.Columns[SearchTB.Text], System.ComponentModel.ListSortDirection.Ascending);
                    }
                    break;

                case 1:
                        DataSort.Sort(DataSort.Columns[SearchTB.Text], System.ComponentModel.ListSortDirection.Descending);
                    break;
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTextBox.Text;
            int rowIndex = 1;

            DataSearchSh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                bool valueResulet = true;
                foreach (DataGridViewRow row in DataSearchSh.Rows)
                {
                    if (row.Cells[rowIndex].Value.ToString().Equals(searchValue))
                    {
                        rowIndex = row.Index;
                        DataSearchSh.Rows[rowIndex].Selected = true;
                        rowIndex++;
                        valueResulet = false;
                    }
                }
                if (valueResulet != false)
                {
                    MessageBox.Show("Нет такой записи " + DataSearchSh.Text, "Не найдено");
                    return;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void VidBtn_Click(object sender, EventArgs e)
        {
            switch (SelectVidSearch.SelectedIndex)
            {
                case 0:
                    {
                        DataSearchSh.DataSource = comics.Objs;
                        DataSearchSh.Refresh();
                    }
                    break;

                case 1:
                    {
                        DataSearchSh.DataSource = sales.Objs;
                        DataSearchSh.Refresh();
                    }
                    break;

                case 2:
                    {
                        DataSearchSh.DataSource = employes.Objs;
                        DataSearchSh.Refresh();
                    }
                    break;

                case 3:
                    {
                        DataSearchSh.DataSource = supliers.Objs;
                        DataSearchSh.Refresh();
                    }
                    break;
            }
        }

        private void ExportSort_Click(object sender, EventArgs e)
        {
            switch (SortExport.SelectedIndex)
            {
                case 0:
                    {
                        ExcepExport(DataSort);
                    }
                    break;

                case 1:
                    {
                        PdfExport(DataSort);
                    }
                    break;

                case 2:
                    {
                        CsvExport(DataSort);
                    }
                    break;

                case 3:
                    {
                        SaveFileDialog sfd = new SaveFileDialog();

                        sfd.Filter = "Word Documents (.docx)|.docx";

                        sfd.FileName = "export.docx";

                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            WordExport(DataSort, sfd.FileName);
                        }
                    }
                    break;
            }
        }
    }
}
