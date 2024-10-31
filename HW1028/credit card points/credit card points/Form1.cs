using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace credit_card_points
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            decimal cost;
            int points;

            try
            {
                cost = decimal.Parse(txtcost.Text);

                if (cost <= 100)
                {
                    points = 1;
                }
                else if (cost <=500)
                {
                    points = 5;
                }
                else if(cost <=1000)
                {
                     points=10;
                }
                else if( cost <=2000)
                {
                    points = 15;
                }
                else
                {
                    points = 20;
                }

                lblpoints.Text = points.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
