using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The IsValidNumber method accepts a string and
        // returns true if it contains 10 digits, or false
        // otherwise.
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10; // The number of digits in a telephone number.
            if (str.Length == VALID_LENGTH) // Check if the length is 10.
            {
                for (int i = 0; i < str.Length; i++) // Loop through each character.
                {
                    if (!char.IsDigit(str[i])) // Check if the character is a digit.
                    {
                        return false; // Return false if not a digit.
                    }
                }
                return true; // Return true if all characters are digits.
            }
            return false; // Return false if length is not 10.
        }
        //TeiephoneFormat 方法接受一個字串參數(參考方式傳遞)
        //此方法會將該字串格式化為電話號碼的形式

        // The TelephoneFormat method accepts a string argument
        // by reference and formats it as a telephone number.
        private void TelephoneFormat(ref string str)
        {
            //檢查字串長度為0
            // if (str.Length == 10) 
            // {
            //格式化為(123)456-7890
            //  str = $"({str.Substring(0,2)}){str.Substring(2, 4)}-{str.Substring(6, 4)}"; // Format the number.

            // }
            str = str.Insert(0, "("); // Insert the opening parenthesis.
            str = str.Insert(3, ")");  // Insert the closing parenthesis.
            str = str.Insert(9, "-");
        }// Insert the hyphen.

        private void formatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text; // Get the input from the text box.
            if (IsValidNumber(input)) // Check if the input is valid.
            {
                TelephoneFormat(ref input); // Format the number.
                MessageBox.Show(input,"格式化後的電話號碼",MessageBoxButtons.OK,MessageBoxIcon.Information); // Show the formatted number.
            }
            else
            {
                MessageBox.Show("請輸入有效的電話號碼。","錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show an error message.
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

