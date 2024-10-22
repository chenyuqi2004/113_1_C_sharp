using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            decimal originaPrice;
            decimal discountPercentage;
            decimal saleprice;
            try
            {
                originaPrice = decimal.Parse(originalPriceTextBox.Text);
                discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
                saleprice = originaPrice - (originaPrice * discountPercentage / 100);

                salePriceLabel.Text = saleprice.ToString("c");
            }
            catch 
            {
                MessageBox.Show("輸入資料格式錯誤");
            }

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
