using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            string FullName;
            string FirstName;
            string LastName;

            FirstName = TxtFirstName.Text;
            LastName = TxtLastName.Text;
            FullName = LastName + " "+ FirstName;

            LblShow.Text= FullName;





        }
    }
}
