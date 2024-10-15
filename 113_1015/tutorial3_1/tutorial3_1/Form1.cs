using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial3_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            string output;
            output = "民國" + txtyear.Text + "年" + txtmounth.Text + "月" + txtdate.Text + "月" + "星期" + txtDayofweek.Text;

            lblshow.Text = output;

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtDayofweek.Text = "";
            txtdate.Text = "";
            txtmounth.Text = "";
            txtyear.Text = "";
            lblshow.Text = "";

        }
    }
}
