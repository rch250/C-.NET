using System;
using System.CodeDom;
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
    public partial class receiptForm : Form
    {
        public receiptForm(string cname, string ctype, string cnumber, string ctotal)
        {
            InitializeComponent();
            cnamelabel.Text = cname;
            ctypelabel.Text = ctype;
            cnumberlabel.Text = cnumber;
            ctotallabel.Text = ctotal;
        }

        private void receiptForm_Load(object sender, EventArgs e)
        {

        }
    }
}
