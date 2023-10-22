using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3a
{
    public partial class WebBrowser : Form
    {
        public WebBrowser()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void navbutton_Click(object sender, EventArgs e)
        {
            //will access PCC website
            mywebBrowser.Navigate("http://pcc.edu");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            mywebBrowser.Refresh();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            mywebBrowser.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            mywebBrowser.GoForward();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            mywebBrowser.Navigate(new System.Uri(@"file:///" + Application.StartupPath + "/mike.htm"));
        }

        private void mywebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = AutoCompleteSource.AllUrl;
        }
    }
}
