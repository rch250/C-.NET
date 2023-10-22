using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//needed for the operation
using System.Windows.Forms;




namespace Lab5
{
    public partial class Login : System.Web.UI.Page
    {

        //Webapplication4: connection string is defined
        SqlConnection connect = 
            new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;
AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        { // this gets rid of this bug!
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            
            // load the remember image
            rememberImage.ImageUrl = "~/images/" + "secure.png";
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Sets up the search parameters 
                string myquery = "select count(*) from [Table] where email='" + 
               emailTextBox.Text + "' and password='" + passwordTextBox.Text + "'";

            //   MessageBox.Show(myquery);
                //opens the connection
                connect.Open();

                SqlCommand command = new SqlCommand(myquery, connect);

                //if the data is found, displays the third form
                string end = command.ExecuteScalar().ToString();
                if (end == "1")
                {
                    Server.Transfer("Display.aspx", true);
                }
                else
                {
                    //if data is not found, displays a warning
                    ClientScript.RegisterStartupScript(this.GetType(), "", 
                        "alert('" + "Invalid Credentials - Please Try Again" + "');", true);
                }
                //closes the sql connection
                connect.Close();
            }
            catch
            {
                //If an exception is detected, a warning will be issued
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + "Wrong Input" + "');", true);
            }
        }


        protected void rememberCheckBox_CheckedChanged(object sender, EventArgs e)
        {  // if checked, store the login username and password in a brower cookie
            if (rememberCheckBox.Checked)
            {
                MessageBox.Show("checked");

                Response.Cookies["userName"].Value = emailTextBox.Text;
                Response.Cookies["passcode"].Value = passwordTextBox.Text;

                // put a 30 day time limit for the cookies
                Response.Cookies["userName"].Expires = DateTime.Now.AddDays(30);
                Response.Cookies["passcode"].Expires = DateTime.Now.AddDays(30);

            }
        }
    }
}