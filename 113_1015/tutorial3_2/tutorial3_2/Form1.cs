using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tutorial3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double kms;
            double liters;
            //double average;

            kms=double.Parse(txbkm.Text);
            liters=double.Parse(txbliter.Text);
            //average=kms/liters;

            lblshow.Text=( kms / liters).ToString("n3");
        }
    }
}
