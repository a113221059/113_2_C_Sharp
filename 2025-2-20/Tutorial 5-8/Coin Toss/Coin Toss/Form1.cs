﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            int sideUP;


            Random rand = new Random();
            sideUP = rand.Next(2);

            if(sideUP==0)
            {
                headsPictureBox.Visible = true;
                headsPictureBox.Visible = false;

            }
            else
            {
                headsPictureBox.Visible = false;
                headsPictureBox.Visible = true;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
