using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;//needed for the operation
using System.Windows.Forms;

namespace Lab5
{
    public partial class NewUser : System.Web.UI.Page
    {
        // from: WebApplication4

        //connection string is defined
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode =
               UnobtrusiveValidationMode.None;
            connect.Open();
        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
  
            try
            {
                //insert parameters are set
                SqlCommand command = new SqlCommand("insert into [Table] (userName, email, password, state) values ('" + userNameTextBox.Text + "','" + emailTextBox.Text + "','" + passwordTextBox.Text + "','" + stateDropDownList.Text + "')", connect);

                //perform inserting the data into the database
                command.ExecuteNonQuery();

                //Close the connection

                connect.Close();
            }
            catch
            {
                //If operation is not successful, display error message
                ClientScript.RegisterStartupScript(this.GetType(), "", "alert('" + "not succsefull" + "');", true);
            }
            //goes to the display page
            Server.Transfer("Display.aspx", true);
        }
    }
}