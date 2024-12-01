using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace measuring_bacterial_growth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            try 
            {
                int bacteria = int.Parse(textBox1.Text);
                int doubledays = int.Parse(textBox2.Text);
                int totaldays = int.Parse(textBox3.Text);

                if (bacteria <= 0 || doubledays <= 0 || totaldays <= 0)
                {
                    MessageBox.Show("請輸入正整數");
                    return;
                }

                for (int days = totaldays; days >= 1; days--)
                {
                    double grow = Math.Pow(2, (double)days / doubledays);
                    int bacteriacount = (int)(bacteria * grow);

                    listBox1.Items.Add($"天數:{days},細菌數量:{bacteriacount}");
                }
            }
            catch 
            {
                MessageBox.Show("請輸入有效數字");
            }
        }

    }
}
