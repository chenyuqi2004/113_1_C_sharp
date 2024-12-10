﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lights
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void turnLightOn()
        {
            lightOnPictureBox.Visible = true;
            lightOffPictureBox.Visible = false;
            lightStateLabel.Text = "ON";
        }
        private void turnLightOff()
        {
            lightOnPictureBox.Visible = false;
            lightOffPictureBox.Visible = true;
            lightStateLabel.Text = "OFF";
        }

        private void switchButton_Click(object sender, EventArgs e)
        {
           if (lightOnPictureBox.Visible == true)
            {
                //關燈
                //lightOnPictureBox.Visible = false;
                //lightOffPictureBox.Visible = true;
                //lightStateLabel.Text = "Off";
                turnLightOff();
            }
            else
            {
                //開燈
                //lightOffPictureBox.Visible=true;
                //lightOffPictureBox.Visible=false;
                //lightStateLabel.Text = "on";
                turnLightOn();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
