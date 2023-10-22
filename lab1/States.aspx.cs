using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Lab1
{
    public partial class States : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void firstpageButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void OregonRadioButton_CheckedChanged(object sender, EventArgs e)
        {  // display information for each state
            stateImage.ImageUrl = "~/images/" + "Oregon.png";
            stateImage.ToolTip = "State of Oregon";
            StatePanel.BackColor     = Color.LightGreen;
            stateTextBox.BackColor = Color.LightGreen;

            stateTextBox.Text = "State of Oregon is a state in the Pacific Northwest Region on the west coast of the United States. " +
                "The Columbia river dilineates much of Oregon's northern boundary along Washington state, while the Snake River delinates " +
                "much of it eastern boundary with Idaho";
        }

        protected void WashingtonRadioButton_CheckedChanged(object sender, EventArgs e)
        { // display information for each state
            stateImage.ImageUrl = "~/images/" + "Washington.png";
            stateImage.ToolTip = "State of Washington";
            StatePanel.BackColor = Color.LightBlue ;
            stateTextBox.BackColor = Color.LightBlue;

            stateTextBox.Text = "Washington is a state in the Pacific Northwest Region of the United States. Named after George Washington," +
                "the first president of the United States, the state was made out of western part of the Washington Territory, which was ceded" +
                " by Britian in accordance with the Oregon Treaty in the Settlement of the Oregon Boudary Dispute";
        }

        protected void CaliforniaRadioButton_CheckedChanged(object sender, EventArgs e)
        { // display information for each state
            stateImage.ImageUrl = "~/images/" + "California.jpg";
            stateImage.ToolTip = "State of California";
            StatePanel.BackColor = Color.LightPink;
            stateTextBox.BackColor = Color.LightPink;

            stateTextBox.Text = "California is a state in the Pacific Region of the United States. California is the most populous US state " +
                "and the third largest by area. The state capital is Sacremento";
        }

        protected void clearRadioButton_CheckedChanged(object sender, EventArgs e)
        {   // clear everything
            stateImage.ImageUrl = null;
            stateImage.ToolTip = "";
            StatePanel.BackColor = Color.White;
            stateTextBox.BackColor = Color.White;
            stateTextBox.Text = "";

        }

        protected void StateDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (StateDropDownList.SelectedItem.Text)
            {  // display state population
                case "Oregon":
                    string MyMessage = "The population of the State of Oregon is 4,246,000";
                    MessageBox.Show(MyMessage, "Oregon Population", MessageBoxButtons.OK);
                    break;

                case "Washington":
                    MyMessage = "The population of the State of Washington is 7,739,000";
                    MessageBox.Show(MyMessage, "Washington Population", MessageBoxButtons.OK);
                    break;

                case "California":
                    MyMessage = "The population of the State of California is 39,024,000";
                    MessageBox.Show(MyMessage, "California Population", MessageBoxButtons.OK);
                    break;

            }
        }
    }
}