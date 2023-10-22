using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab4
{
    public partial class Travelers : Form
    {
        public Travelers()
        {
            InitializeComponent();
        }

        private void traveltimer_Tick(object sender, EventArgs e)
        {
            // start the traveltimer to display current date&time
            traveltimer.Start();
            dateTimeLabel.Text = DateTime.Now.ToString();
         
        }
        private void Travelers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDataSet.TravelRequests' table. You can move, or remove it, as needed.
            this.travelRequestsTableAdapter.Fill(this.travelDataSet.TravelRequests);

        }


        private void TraveltoolStripSaveButton_Click(object sender, EventArgs e)
        {   // save the data 
            try
            {
                this.Validate();
                this.travelRequestsBindingSource.EndEdit();
                this.travelRequestsTableAdapter.Update(this.travelDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void Exitbutton_Click(object sender, EventArgs e)
        {   // exit the application
            DialogResult = MessageBox.Show("Do you want to exit the program", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Hope you enjoyed using this program!", "Exit");
                this.Close();
            }
            else if (DialogResult == DialogResult.No)
            { MessageBox.Show("Keep enjoying the program!", "Exit"); }
        }

        private void Displaybutton_Click(object sender, EventArgs e)
        {  // load each item in the row into list view

            // turn on the listview and cost box
            travellistView.Visible = true;
            CostgroupBox.Visible= true;

            if (travelCosttextBox.Text == "")
            {
                MessageBox.Show("Empty cost");
            }
            else
            {
                ListViewItem lst = new ListViewItem(TravelerIDtextBox.Text);
                lst.SubItems.Add(travelCosttextBox.Text);
                lst.SubItems.Add(desttextBox.Text);
                lst.SubItems.Add(datestextBox.Text);
                lst.SubItems.Add(FNametextBox.Text);
                lst.SubItems.Add(LNametextBox.Text);
                travellistView.Items.Add(lst);

                //sum up the total
                double total = 0;
                foreach (ListViewItem lstItem in travellistView.Items)
                {
                    if (lstItem.SubItems[1].Text != "")
                    {
                        total += double.Parse(lstItem.SubItems[1].Text);
                    }
                    
                }

                // output the total
                totalcostlabel.Text = total.ToString("C");

            }

        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {   // clear out list view and 0 the cost total
            travellistView.Items.Clear();
            //foreach (ListViewItem lst in travellistView.Items)
            //{

            //    lst.SubItems[0].Text = "";
            //    lst.SubItems[1].Text = "";
            //    lst.SubItems[2].Text = "";
            //    lst.SubItems[3].Text = "";
            //    lst.SubItems[4].Text = "";
            //    lst.SubItems[5].Text = "";

            //}
            //  double total = 0;
            //  totalcostlabel.Text = total.ToString("C");

            // turn off the listview and cost box
            travellistView.Visible = false;
            CostgroupBox.Visible = false;
            searchgroupBox.Visible = false;

            // clear out the data boxes
            TravelerIDtextBox.Text = string.Empty;
            travelCosttextBox.Text= string.Empty;
            desttextBox.Text = string.Empty;
            datestextBox.Text = string.Empty;
            LNametextBox.Text = string.Empty;
            FNametextBox.Text= string.Empty;
            purposetextBox.Text = string.Empty;

            seachtextBox.Text = string.Empty;

        }

        private void fillByNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.travelRequestsTableAdapter.FillByName(this.travelDataSet.TravelRequests, lastNameToolStripTextBox.Text, firstNameToolStripTextBox.Text, purposeforTravelToolStripTextBox.Text, locationToolStripTextBox.Text, tripDatesToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            try
            {
                this.travelRequestsTableAdapter.FillByName(this.travelDataSet.TravelRequests, seachtextBox.Text, seachtextBox.Text, seachtextBox.Text, seachtextBox.Text, seachtextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void MenuSearchbutton_Click(object sender, EventArgs e)
        {
            searchgroupBox.Visible = true;
        }

        private void Reportbutton_Click(object sender, EventArgs e)
        {
            ReportForm newform = new ReportForm();
            newform.Show();
        }

        void printing(object sender, PrintPageEventArgs e)             //defines what is to be printed
        {
            Bitmap anyname = new Bitmap(travellistView.Width, travellistView.Height);
            travellistView.DrawToBitmap(anyname, travellistView.ClientRectangle);
            e.Graphics.DrawImage(anyname, new Point(50, 50));

        }
        private void Printbutton_Click(object sender, EventArgs e)
        { // print the contents of the list view
   

                MessageBox.Show("Please make the printer Ready", "Warning");
                printDialog1.AllowSomePages = true;
                printDialog1.ShowHelp = true;



                PrintDocument pd = new PrintDocument();
                pd.PrintPage += new PrintPageEventHandler(printing);
                PrintDialog printdlg = new PrintDialog();
                printdlg.Document = pd;
                if (printdlg.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }
            
        }

        private void dateTimeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
