using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            SqlServerTypes.Utilities.LoadNativeAssemblies(AppDomain.CurrentDomain.BaseDirectory);
          
        }
        int login_attempts = 3; 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadprogressBar.Increment(1);
            percentagelabel.Text =
                loadprogressBar.Value.ToString() + "%";

            //if (loadprogressBar.Value == 100)
            //{
            //  // time is up; close the program
            //    this.Close();
            //}
        }
   
        private void loadprogressBar_Click(object sender, EventArgs e)
        {

        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {  // validate password
            if (usertextBox.Text == "")
            {
                MessageBox.Show("User Name Needed");
            }
            else if (passwordtextBox.Text == "")
            {
                MessageBox.Show("Password  Needed");
            }
            else
            {
                MessageBox.Show("Logged in");

                //string connection to access table
                //connect to the database
                //bug: database cannot connect
                string connection = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'loginBase.mdb'";
                MessageBox.Show(connection);
                string queryString =
                    "SELECT Username, Password FROM login WHERE (Username) = '" +
                    usertextBox.Text.ToUpper() + "'";
                MessageBox.Show(queryString);

                try

                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter(queryString, connection);

                    //populate username and password to the dataset
                    DataSet user = new DataSet();
                    adapter.Fill(user, "login");
                    //validate the user name

                    if (user.Tables["login"].Rows.Count == 0)
                    {
                        //if user not found

                        MessageBox.Show("Invalid Username or Password", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    //validate password

                    foreach (DataRow row in user.Tables["login"].Rows)
                    {
                        if (row["Password"].ToString() == passwordtextBox.Text)
                        {
                            //If successful,  display next form and hide the form
                            this.Hide();
                            MessageBox.Show("Found");
                            this.Close();
                        }
                        else

                        {
                            //if log in failed
                            // reduce login attempts
                            MessageBox.Show("Check user name or password", "Login Failed",
                                MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            login_attempts--;
                            if (login_attempts == 0)
                            {   // disable passwordtextBox
                                passwordtextBox.Enabled = false;
                            }
                        }
                    }
                }
                catch
                {
                    //catch exceptions
                    MessageBox.Show("Error in accessing the table");
                }

                MessageBox.Show("about to load Display");
                this.Hide();
                Display2 newform = new Display2();
                newform.Show();
                
            }
        }
    }
}
