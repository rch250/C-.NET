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
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void menuForm_Load(object sender, EventArgs e)
        {  // load the menu picture
            try
            {
                menuPictureBox.Image = Image.FromFile("images/vanilla.png");
            }
            catch
            {
                MessageBox.Show
                    ("The image couldn't be found in that folder.", "Warning!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }



        private void okButton_Click(object sender, EventArgs e)
        {   // validate user input
      //      shopForm newform = new shopForm(usertextBox.Text, phoneTextBox.Text);
      //      newform.Show();
            if ( // succesful login
                (usertextBox.Text.ToUpper() == "MIKE" && 
                passwordtextBox.Text.ToUpper() == "ICECREAM")
                || (usertextBox.Text.ToUpper() == "BOB" &&
                passwordtextBox.Text.ToUpper() == "PCC")
                || (usertextBox.Text.ToUpper() == "ACE" &&
                passwordtextBox.Text.ToUpper() == "PCC")
               )
                
            {
                // show sucessful login
                string MyMessage = "Hi " + usertextBox.Text + ": Sucessful Login-Press the next button to visit the second page";
                MessageBox.Show(MyMessage, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                shopForm newform = new shopForm(usertextBox.Text, phoneTextBox.Text);
                newform.Show();

            }
            else
            {   // ask user to try again.
                string MyMessage = "Incorrect Username, Password, or invalid phone number, Please try again!";
               MessageBox.Show(MyMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void websiteButton_Click(object sender, EventArgs e)
        {
            WebBrowser newform = new WebBrowser();
            newform.Show();
        }

        private void videoButton_Click(object sender, EventArgs e)
        {
            Video newform = new Video();
            newform.Show();
        }
    }
}
