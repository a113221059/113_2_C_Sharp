using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Unformat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // IsValidFormat 方法接受一個字串參數，並判斷該字串是否符合美國電話號碼的格式。
        // 格式要求為: (XXX)XXX-XXXX，其中：
        // - (XXX) 表示區碼，必須包含括號。
        // - XXX 表示前綴碼，必須為三個數字。
        // - XXXX 表示行號，必須為四個數字。
        // 如果字串符合上述格式，則返回 true；否則返回 false。
        private bool IsValidFormat(string str)
        {
           
            // 檢查字串是否為空或長度不符合格式要求
            if (string.IsNullOrEmpty(str) || str.Length != 13)
            {
                return false;
            }

            // 檢查字串是否符合 (XXX)XXX-XXXX 格式
            if (str[0] == '(' && str[4] == ')' && str[8] == '-')
            {
                // 確保括號內和後續部分的字元都是數字
                if (str.Substring(1, 3).All(char.IsDigit) &&
                str.Substring(5, 3).All(char.IsDigit) &&
                str.Substring(9, 4).All(char.IsDigit))
                {
                    return true;
                }
            }

            return false;
        }
        
            
        

        // Unformat 方法接受一個字串參數（以引用方式傳遞），將字串轉換為格式化的電話號碼。
        // 格式化的意思是將字串中的格式符號移除，將其轉換為純數字的電話號碼。
        // 例如：輸入 "(123)456-7890" 將被轉換為 "1234567890"。
        // 1 個參考
        private void Unformat(ref string str)
        {
            // 使用 Remove 方法移除括號和連字符
            str = str.Remove(0, 1); // 移除左括號 '('
            str = str.Remove(2, 1); // 移除右括號 ')'
            str = str.Remove(6, 1); // 移除連字符 '-'
        }

        private void unformatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text;
            if (IsValidFormat(input))
            {
                Unformat(ref input);
                numberTextBox.Text = input; // 更新 TextBox 的內容
            }
            else
            {
                MessageBox.Show("請輸入有效的電話號碼格式 (例如: (123)456-7890)。");
                numberTextBox.Clear(); // 清空 TextBox
                numberTextBox.Focus(); // 將焦點設置回 TextBox
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        
    }
}
