using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS_VALUE = 0.05m;
        const decimal TEN_CENTS_VALUE = 0.10m;
        const decimal TWENT_YFIVE_CENTS_VALUE = 0.25m;
        const decimal FIFTY_CENTS_VALUE = 0.50m;

        private decimal total;
        public Form1()
        {
            InitializeComponent();
        }

        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //total = total + 0.5m;
            total += FIVE_CENTS_VALUE;
            totalLabel.Text=total.ToString("c");
        }
        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            //total += 0.10m;
            total += TEN_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //total += 0.25m;
            total += TWENT_YFIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            //total += 0.50m;
            total += FIFTY_CENTS_VALUE;
            totalLabel.Text = total.ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            total = 0;
            totalLabel.Text = total.ToString("c");
        }
    }
}
