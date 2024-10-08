using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*資管一乙
 * a113221008
 * 陳昱齊*/

namespace Tutorial2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //顯示撲克牌背面
        private void BtnShowBack_Click(object sender, EventArgs e)
        {
            PtxBack.Visible = true; //設定visible屬性為假
            PtxFront.Visible = false;
        }
        //顯示撲克牌正面
        private void BtnShowFront_Click(object sender, EventArgs e)
        {
            PtxBack.Visible = false;
            PtxFront.Visible = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
