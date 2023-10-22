using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void reporttimer_Tick(object sender, EventArgs e)
        {
            // start the traveltimer to display current date&time
            reporttimer.Start();
            dateTimeLabel.Text = DateTime.Now.ToString();

        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet.TravelRequests' table. You can move, or remove it, as needed.
            this.travelRequestsTableAdapter.Fill(this.travelDataSet.TravelRequests);

        }

        private void Exitbutton_Click(object sender, EventArgs e)
        { //exit application
            DialogResult = MessageBox.Show("Do you want to exit the program", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Hope you enjoyed using this program!", "Exit");
                this.Close();
            }
            else if (DialogResult == DialogResult.No)
            { MessageBox.Show("Keep enjoying the program!", "Exit"); }
        }

        private void firstformbutton_Click(object sender, EventArgs e)
        {  // close this form
            this.Close();
        }

        private void Excelbutton_Click(object sender, EventArgs e)
        {   // https://www.c-sharpcorner.com/UploadFile/hrojasara/export-datagridview-to-excel-in-C-Sharp/#:~:text=Right%20click%20on%20your%20project,and%20columns%20to%20the%20document
            // export reportgridview to an excel spreadsheet

            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < ReportdataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = ReportdataGridView.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < ReportdataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < ReportdataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = ReportdataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();

        }
    }
}
