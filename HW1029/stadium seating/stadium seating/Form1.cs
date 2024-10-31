using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stadium_seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, C;
           
            const decimal Acost = 15;
            const decimal Bcost = 12;
            const decimal Ccost = 9;

            try
            {
                A=int.Parse(txtAseats.Text);
                B=int.Parse(txtBseats.Text);
                C=int.Parse(txtCseats.Text);

                lblARevenue.Text = (A * Acost).ToString("c");
                lblBRevenue.Text= (B * Bcost).ToString("c");
                lblCRevenue.Text =(C * Ccost).ToString("c");
                lblTotalRevenue.Text = ((A * Acost) + (B * Bcost) + (C * Ccost)).ToString("c");

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAseats.Text = " ";
            txtBseats.Text = " ";
            txtCseats.Text = " ";
            lblARevenue.Text= " ";
            lblBRevenue.Text = " ";
            lblCRevenue.Text=" ";
            lblTotalRevenue.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
