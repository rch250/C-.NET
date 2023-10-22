using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab9
{
    public partial class Display2 : Form
    {
        public Display2()
        {
            InitializeComponent();
        }

        private void Display2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginBaseDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.loginBaseDataSet.login);

        }
    }
}
