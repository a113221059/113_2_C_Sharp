using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cell_Phone_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        // GetPhoneData 方法接受一個 CellPhone 物件作為參數。
        // 它將使用者輸入的資料指派給該物件的屬性。
        private void GetPhoneData(CellPhone phone)
        {
            decimal price;
            phone.Brand = brandTextBox.Text;    
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            CellPhone myPhone = new CellPhone();
            // Call the GetPhoneData method to populate the phone object
            GetPhoneData( myPhone);
            // Display the phone's data in the text box.
         brandLabel.Text = myPhone.Brand;
         modelLabel.Text = myPhone.Model;
         priceLabel.Text = myPhone.Price.ToString("C2");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
