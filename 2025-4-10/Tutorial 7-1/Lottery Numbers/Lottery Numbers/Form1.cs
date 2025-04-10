using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery_Numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 5;
            int[] lotteryNumbers = new int[SIZE];
            Random rand = new Random();

            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                int number;
                do
                {
                    number = rand.Next(1, 43);
                }while(lotteryNumbers.Contains(number));
                lotteryNumbers[i] = number;
            }
            Array.Sort(lotteryNumbers);

            Label[] showlabels = { firstLabel, secondLabel, thirdLabel, fourthLabel, fifthLabel };
            for (int i = 0; i < lotteryNumbers.Length; i++)
            {
                showlabels[i].Text = lotteryNumbers[i].ToString();
            }
        }
        

        
        

private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
