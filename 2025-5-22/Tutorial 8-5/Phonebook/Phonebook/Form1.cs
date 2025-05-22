using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Phonebook
{
    // 結構用於儲存電話簿的每一筆資料，包括姓名與電話號碼
    struct PhoneBookEntry
    {
        public string name;   // 聯絡人姓名
        public string phone;  // 聯絡人電話號碼
    }

    public partial class Form1 : Form
    {
        // 用來儲存所有電話簿資料的清單，每一筆資料為 PhoneBookEntry 結構
        private List<PhoneBookEntry> phoneList =
            new List<PhoneBookEntry>();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 讀取 PhoneList.txt 檔案內容，將每一筆資料轉換為 PhoneBookEntry 結構，
        /// 並加入 phoneList 清單中。每一行格式為「姓名,電話號碼」。
        /// 若檔案不存在或格式錯誤，會顯示相應的錯誤訊息。
        /// </summary>
        private void ReadFile()
        {
            StreamReader inputFile;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    inputFile = File.OpenText(openFile.FileName);
                    string line;
                    while (!inputFile.EndOfStream)
                    {
                        line = inputFile.ReadLine().Trim();
                        string[] parts = line.Split(' ');
                        if (parts.Length == 2)
                        {
                            PhoneBookEntry entry;
                            entry.name = parts[0].Trim();
                            entry.phone = parts[1].Trim();
                            phoneList.Add(entry);
                        }
                        else
                        {
                            MessageBox.Show("檔案格式錯誤 " );
                        }
                    }
                    inputFile.Close();
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("讀取檔案時發生錯誤: " + ex.Message);
                }
            }
        }



        /// <summary>
        /// 將 phoneList 清單中的所有姓名顯示在 nameListBox 控制項中，
        /// 讓使用者可以從清單中選擇聯絡人。
        /// </summary>
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        /// <summary>
        /// 當表單載入時，讀取電話簿檔案並顯示所有聯絡人姓名。
        /// 若讀取失敗則顯示錯誤訊息。
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile();//讀取

            DisplayNames();
            phoneLabel.Text = ""; // 預設電話號碼欄位為空白
        }

        /// <summary>
        /// 當使用者在 nameListBox 選擇不同的姓名時，
        /// 顯示對應的電話號碼於 phoneLabel 控制項。
        /// </summary>
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex; // 取得選取的索引
            if (index != -1)
            {
                // 顯示對應的電話號碼在 phoneLabel 控制項上
                phoneLabel.Text =  phoneList[index].phone;
            }
            else
            {
                // 如果沒有選擇任何姓名，則清空 phoneLabel 控制項的文字
                phoneLabel.Text = "無資料";
            }
        }

        /// <summary>
        /// 當使用者按下離開按鈕時，關閉表單並結束應用程式。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            {
                // 檢查是否有開啟過檔案
                if (!string.IsNullOrEmpty(openFile.FileName) && File.Exists(openFile.FileName))
                {
                    StreamWriter writer = null;
                    try
                    {
                        // 使用 File.CreateText 以覆寫方式開啟檔案
                        writer = File.CreateText(openFile.FileName);
                        foreach (PhoneBookEntry entry in phoneList)
                        {
                            writer.WriteLine($"{entry.name},{entry.phone}");
                        }
                    }
                    finally
                    {
                        if (writer != null)
                        {
                            writer.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("找不到原始檔案,無法儲存資料");
                }
                // 關閉表單
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PhoneBookEntry entry; // 宣告一個 PhoneBookEntry 結構
            entry.name = textBox1.Text.Trim(); // 姓名
            entry.phone = textBox2.Text.Trim(); // 電話號碼

            // 檢查姓名與電話號碼是否為空
            if (string.IsNullOrEmpty(entry.name) || string.IsNullOrEmpty(entry.phone))
            {
                MessageBox.Show("姓名或電話號碼不能為空");
                return;
            }
            // 檢查姓名是否已存在
            foreach (PhoneBookEntry existingEntry in phoneList)
            {
                if (existingEntry.name.Equals(entry.name, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("姓名已存在");
                    return;
                }
            }

            // 將資料加入清單中
            phoneList.Add(entry); // 將資料加入 phoneList 清單中
            nameListBox.Items.Add(entry.name); // 將姓名加入 nameListBox 控制項中

            // 清空 textBoxName 與 textBoxPhone 控制項的文字
            textBox1.Clear();
            textBox2.Clear();

            // 清空 phoneLabel 控制項的文字
            phoneLabel.Text = "";
        }
    }
}
