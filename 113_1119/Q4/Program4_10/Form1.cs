using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program4_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double totalCalories) &&
        double.TryParse(textBox2.Text, out double fatGrams))
            {
                // 檢查數值是否大於 0
                if (totalCalories > 0 && fatGrams > 0)
                {
                    // 計算脂肪卡路里數
                    double fatCalories = fatGrams * 9;

                    // 計算來自脂肪的卡路里百分比
                    double fatPercentage = (fatCalories / totalCalories) * 100;

                    // 組裝結果文字
                    string result = $"來自脂肪的卡路里數：{fatCalories:F2}\n" +
                                    $"來自脂肪的卡路里百分比：{fatPercentage:F2} %\n";

                    // 判斷是否為低脂食品
                    if (radioButton1.Checked)
                    {
                        if (fatPercentage < 30)
                        {
                            result += "此食品為低脂食品。";
                        }
                        else
                        {
                            result += "此食品不是低脂食品。";
                        }
                    }

                    // 顯示結果到最下方的 Label
                    label3.Text = result;
                }
                else
                {
                    MessageBox.Show("請輸入大於 0 的正數值！");
                }
            }
            else
            {
                MessageBox.Show("輸入格式無效，請輸入有效的數字！");
            }
        }
    }
    
}
