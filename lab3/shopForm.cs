using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab3a
{
    public partial class shopForm : Form
    {
        public shopForm(string cname, string cnumber)
        {
            InitializeComponent();
            customertextBox.Text = cname;
            numbertextBox.Text = cnumber;
        }

        private void shopForm_Load(object sender, EventArgs e)
        {
            resetbutton.PerformClick();
        }

        // ice cream price
        double price = 0;
        // toppings price
        double topprice = 0;
        // total price
        double totprice = 0;
        int toppings = 0;
        double total = 0;

        //initialize ice cream size and flavor
        string size = "";
        string flavor = "";

        private bool Icecreamselected()
        { // find out if ice cream radio buttons are checked

            return (strawberryradioButton.Checked)
                || (chocolateradioButton.Checked)
                 || (vanillaradioButton.Checked);
        }

        private bool Icecreamsizeselected()
        { // find out if ice cream size has been selected

            return (smallradioButton.Checked)
                || (mediumradioButton.Checked)
                 || (largeradioButton.Checked);
        }

        private void smallradioButton_CheckedChanged(object sender, EventArgs e)
        {
            //check to see if ice cream type is selected
            if (!(Icecreamselected()))
            {
                smallradioButton.Checked = false;
                MessageBox.Show("You must first select ice cream type first",
                   "Warning");
            }
            else
            {
                MessageBox.Show("Small Ice Cream $3.00",
                                  "Small Ice Cream Price");
                size = "small";
            }
        }

        private void mediumradioButton_CheckedChanged(object sender, EventArgs e)
        {
            //check to see if ice cream type is selected
            if (!(Icecreamselected()))
            {
                mediumradioButton.Checked = false;
                MessageBox.Show("You must first select ice cream type first",
                   "Warning");
            }
            else
            {
                MessageBox.Show("Medium Ice Cream $4.00",
                                  "Medium Ice Cream Price");
            }
            size = "medium";
        }

        private void largeradioButton_CheckedChanged(object sender, EventArgs e)
        {
            //check to see if ice cream type is selected
            if (!(Icecreamselected()))
            {
                largeradioButton.Checked = false;
                MessageBox.Show("You must first select ice cream type first",
                   "Warning");
            }
            else
            {
                MessageBox.Show("Large Ice Cream $5.00",
                                  "Large Ice Cream Price");
            }
            size = "large";
        }

        private void freshfruitcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!(Icecreamselected()))
            {
                freshfruitcheckBox.Checked = false;
                MessageBox.Show("You must first select ice cream type first",
                   "Warning");
            }
            else // if toppings checkbox is selected, increment toppings price
            if (freshfruitcheckBox.Checked)
            {
                topprice += 1;
                toppings += 1;

            }
            else // decrement toppings price
            if (topprice > 0)
            {
                topprice -= 1;
                toppings -= 1;
            }
        }

        private void carmelcheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (!(Icecreamselected()))
            {
                carmelcheckBox.Checked = false;
                MessageBox.Show("You must first select ice cream type first",
                   "Warning");
            }
            else // if freshfruit is selected, increment toppings price
             if (carmelcheckBox.Checked)
            {
                topprice += 1;
                toppings += 1;
            }
            else
                if (topprice > 0)
            {
                topprice -= 1;
                toppings -= 1;
            }
        }

        private void chocolatecheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //check to see if ice cream type is selected
            if (!(Icecreamselected()))
            {
                chocolatecheckBox.Checked = false;
                MessageBox.Show("You must first select ice cream type first",
                   "Warning");
            }
            else // if freshfruit is selected, increment toppings price
            if (chocolatecheckBox.Checked)
            {
                topprice += 1;
                toppings += 1;
            }
            else
              if (topprice > 0)
            {
                topprice -= 1;
                toppings -= 1;
            }
        }

        private void mintcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!(Icecreamselected()))
            {
                mintcheckBox.Checked = false;
                MessageBox.Show("You must first select ice cream type first",
                   "Warning");
            }
            else // if freshfruit is selected, increment toppings price
        if (mintcheckBox.Checked)
            {
                topprice += 1;
                toppings -= 1;
            }
            else
          if (topprice > 0)
            {
                topprice -= 1;
                toppings -= 1;
            }
        }


        private void exitbutton_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Do you want to exit the program", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Hope you enjoyed using this program!", "Exit");
                this.Close();
            }
            else if (DialogResult == DialogResult.No)
            { MessageBox.Show("Keep enjoying the program!", "Exit"); }

        }


        private void resetbutton_Click(object sender, EventArgs e)
        { // clear the form
            smallradioButton.Checked = false;
            mediumradioButton.Checked = false;
            largeradioButton.Checked = false;
            freshfruitcheckBox.Checked = false;
            carmelcheckBox.Checked = false;
            chocolatecheckBox.Checked = false;
            mintcheckBox.Checked = false;
            strawberryradioButton.Checked = false;
            chocolateradioButton.Checked = false;
            vanillaradioButton.Checked = false;
            icecreampictureBox.Visible = false;
            icecreamtypelabel.Text = "Ice Cream";
            totalamountlabel.Text = "";

            //set the amounts back to 0
            totprice = 0;
            price = 0;
            topprice = 0;
            total = 0;

            size = "";
            flavor = "";
        }

        private void strawberryradioButton_CheckedChanged(object sender, EventArgs e)
        {
            icecreampictureBox.Visible = true;
           // icecreampictureBox.Image = Image.FromFile("images/strawberry.png");
            icecreamtypelabel.Text = "Strawberry Ice Cream";
            flavor = "strawberry";

            try
            {
                icecreampictureBox.Image = Image.FromFile("images/strawberry.png");
            }
            catch
            {
                MessageBox.Show
                    ("The image couldn't be found in that folder.", "Warning!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }


        private void chocolateradioButton_CheckedChanged(object sender, EventArgs e)
        {
            icecreampictureBox.Visible = true;
            icecreamtypelabel.Text = "Chocolate Ice Cream";
            flavor = "chocolate";

            try
            {
                icecreampictureBox.Image = Image.FromFile("images/chocolate.jpeg");
            }
            catch
            {
                MessageBox.Show
                    ("The image couldn't be found in that folder.", "Warning!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void vanillaradioButton_CheckedChanged(object sender, EventArgs e)
        {
            icecreampictureBox.Visible = true;
            icecreampictureBox.Image = Image.FromFile("images/vanilla.png");
            icecreamtypelabel.Text = "Vanilla Ice Cream";
            flavor = "vanilla";

            try
            {
                icecreampictureBox.Image = Image.FromFile("images/vanilla.png");
            }
            catch
            {
                MessageBox.Show
                    ("The image couldn't be found in that folder.", "Warning!", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void checkoutbutton_Click(object sender, EventArgs e)
        {
            if (!(Icecreamselected()))
            {
                MessageBox.Show("You must first select ice cream type first",
                   "Warning");
            }
            else
                         if (!(Icecreamsizeselected()))
            {
                MessageBox.Show("You must first select ice cream size first",
                   "Warning");
            }
            else
                        if (smallradioButton.Checked)
            {
                price = 3.00;
                totprice = price + topprice;
                totalamountlabel.Text = totprice.ToString("c");
            }
            else
                        if (mediumradioButton.Checked)
            {
                price = 4.00;
                totprice = price + topprice;
                totalamountlabel.Text = totprice.ToString("c");

            }
            else
                        if (largeradioButton.Checked)
            {
                price = 5.00;
                totprice = price + topprice;
                totalamountlabel.Text = totprice.ToString("c");

            }

            //load  receipt
     //       ListViewItem list = receiptlistView.Items.Add(flavor);
    //        list.SubItems.Add(toppings.ToString());
    //        list.SubItems.Add(size);
    //        list.SubItems.Add(totprice.ToString());


            //total up the amount
    //        total = 0;
   //         foreach (ListViewItem orderitem in receiptlistView.Items)
    //        {
  //              double amt;

   //             if (double.TryParse(orderitem.SubItems[3].Text, out amt))
   //             {
   //                 // MessageBox.Show(amt.ToString(), "Amount");
   //                 total += amt;
   //             }
   //             else
   //             {
  //                  MessageBox.Show("Cannot convert in ListView", "Error");
   //             }

  //          }

   //         amtlabel.Text = total.ToString("c");

        }

        private void numbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rec_button_Click(object sender, EventArgs e)
        {  // show receipt
       
            receiptForm newform = new receiptForm(customertextBox.Text, flavor, numbertextBox.Text, totalamountlabel.Text);
            newform.Show();
        }
    }
}
