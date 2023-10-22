using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {   // validate input of the user
            if (nameTextBox.Text.ToUpper() == "TIGER" && passwordTextBox.Text.ToUpper() == "PCC")
            {
                imageLabel.Visible = true;
                LoginCheckBox.Visible = true;
                nextPageButton.Visible = true;
                loginImage.ImageUrl = "~/images/" + "TIGER.png";
                imageLabel.Text = "Welcome Tiger";

                string MyMessage = "Hi Tiger Sucessful Login-Press the next button to visit the second page";
                MessageBox.Show(MyMessage, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (nameTextBox.Text.ToUpper() == "LION" && passwordTextBox.Text.ToUpper() == "PCC")
            {
                imageLabel.Visible = true;
                LoginCheckBox.Visible = true;
                nextPageButton.Visible = true;
                loginImage.ImageUrl = "~/images/" + "LION.png";
                imageLabel.Text = "Welcome Lion";

                string MyMessage = "Hi Lion Sucessful Login-Press the next button to visit the second page";
                MessageBox.Show(MyMessage, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if (nameTextBox.Text.ToUpper() == "DOG" && passwordTextBox.Text.ToUpper() == "PCC")
            {
                imageLabel.Visible = true;
                LoginCheckBox.Visible = true;
                nextPageButton.Visible = true;
                loginImage.ImageUrl = "~/images/" + "DOG.png";
                imageLabel.Text = "Welcome Dog";

                string MyMessage = "Hi Dog Sucessful Login-Press the next button to visit the second page";
                MessageBox.Show(MyMessage, "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {  // invalid use
                string MyMessage = "Wrong User";
                MessageBox.Show(MyMessage, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        protected void LoginCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxLabel.Visible = true;
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {  // turn off and clear the boxes
            imageLabel.Visible = false;
            LoginCheckBox.Visible = false;
            nextPageButton.Visible = false;
            checkBoxLabel.Visible = false;

            loginImage.ImageUrl = null; 
            imageLabel.Text = null;

            nameTextBox.Text = null;
            passwordTextBox.Text = null;
            
        }

        protected void nextPageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/States.aspx");
        }
    }
}