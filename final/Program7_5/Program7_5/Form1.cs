using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Program7_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 使用 List 來存放球隊與冠軍資料
        List<string> teamList = new List<string>();
        List<string> winnerList = new List<string>();

        // 儲存目前選擇的球隊檔案名稱
        string teamFileName = "";

        /// <summary>
        /// 表單載入時執行，先顯示提示，再顯示球隊檔名，最後開啟世界冠軍隊伍檔案
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {

            // 1. 先顯示提示
            MessageBox.Show("請先選擇球隊檔案，", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 2. 讓使用者選擇球隊檔案
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "請選擇球隊檔案 (Teams.txt)";
            ofd.Filter = "文字檔案 (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(ofd.FileName); // 修正 'Filename' 為 'FileName'
                teamFileName = ofd.FileName; // 修正將檔案名稱正確指派給 'teamFileName'

                listBox1.Items.Clear();
                foreach (string line in lines)
                {
                    listBox1.Items.Add(line); // 修正 'lines' 為 'line'
                }
                listBox1.Items.Insert(0, "請選擇一支球隊"); // 修正 'lnsert' 為 'Insert'
                listBox1.SelectedIndex = 0; // 修正 'label1.Selectedindex; = 0' 為 'listBox1.SelectedIndex = 0'
            }
            else
            {
                MessageBox.Show("未選擇球隊檔案");
                this.Close();
                return;
            }

            

            // 4. 讀取球隊檔案
            if (!讀取球隊檔案(teamFileName))
            {
                MessageBox.Show("讀取球隊檔案失敗，程式即將結束。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // 5. 讓使用者選擇冠軍檔案
            while (!讀取冠軍檔案())
            {
                

                
            }
        }

        /// <summary>
        /// 讀取球隊檔案
        /// </summary>
        /// <param name="fileName">檔案名稱</param>
        /// <returns>成功載入回傳 true，否則回傳 false</returns>
        private bool 讀取球隊檔案(string fileName)
        {
            MessageBox.Show("請選擇冠軍紀錄檔。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (string.IsNullOrEmpty(fileName)) return false;
            try
            {
                teamList.Clear();
                listBox1.Items.Clear();
                using (StreamReader inputFile = new StreamReader(fileName, Encoding.UTF8))
                {
                    string line;
                    while ((line = inputFile.ReadLine()) != null)
                    {
                        teamList.Add(line);
                        listBox1.Items.Add(line);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("讀取球隊檔案時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// 讓使用者透過對話方塊選擇 WorldSeries.txt 檔案，讀取每一年的冠軍球隊名稱並加入 winnerList
        /// </summary>
        /// <returns>成功載入回傳 true，否則回傳 false</returns>
        private bool 讀取冠軍檔案()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "請選擇冠軍紀錄檔案 (WorldSeries.txt)";
            openFileDialog.Filter = "文字檔案 (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    winnerList.Clear();
                    using (StreamReader inputFile = new StreamReader(openFileDialog.FileName, Encoding.UTF8))
                    {
                        string line;
                        while ((line = inputFile.ReadLine()) != null)
                        {
                            winnerList.Add(line);
                        }
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("讀取冠軍檔案時發生錯誤：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                // 未選擇檔案時回傳 false
                return false;
            }
        }

        /// <summary>
        /// 當使用者在 listBox1 選取球隊時，計算該球隊奪冠次數及奪冠年份，並以繁體中文顯示於 label1
        /// </summary>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null || winnerList.Count == 0)
            {
                label1.Text = "請先選擇球隊與載入冠軍資料。";
                return;
            }

            string selectedTeam = listBox1.SelectedItem.ToString();
            int numWin = 0;
            List<int> winYears = new List<int>();

            // MLB 世界大賽從 1903 年開始，1904 與 1994 年未舉辦
            int year = 1903;
            int winnerIndex = 0;
            while (winnerIndex < winnerList.Count)
            {
                // 排除 1904 與 1994 年
                if (year == 1904 || year == 1994)
                {
                    year++;
                    continue;
                }
                if (winnerList[winnerIndex] == selectedTeam)
                {
                    numWin++;
                    winYears.Add(year);
                }
                winnerIndex++;
                year++;
            }

            // 組合顯示訊息，包含奪冠次數與年份
            if (numWin > 0)
            {
                label1.Text = $"{selectedTeam} 從 1903 年到 2009 年共獲得 {numWin} 次世界大賽冠軍。\n奪冠年份：{string.Join("、", winYears)}";
            }
            else
            {
                label1.Text = $"{selectedTeam} 從 1903 年到 2009 年未曾獲得世界大賽冠軍。";
            }
        }
    }

    /// <summary>
    /// 顯示球隊檔名的自訂表單
    /// </summary>
    public class TeamFileNameShowForm : Form
    {
        private TextBox txtFileName;
        private Button btnOK;
        private Label lblPrompt;

        public TeamFileNameShowForm(string fileName)
        {
            this.Text = "球隊檔案確認";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(420, 140);
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            lblPrompt = new Label();
            lblPrompt.Text = "目前選擇的球隊檔案名稱：";
            lblPrompt.Location = new Point(20, 20);
            lblPrompt.Size = new Size(200, 20);

            txtFileName = new TextBox();
            txtFileName.Location = new Point(20, 50);
            txtFileName.Size = new Size(370, 20);
            txtFileName.ReadOnly = true;
            txtFileName.Text = fileName;

            btnOK = new Button();
            btnOK.Text = "確定";
            btnOK.Location = new Point(310, 90);
            btnOK.Size = new Size(80, 30);
            btnOK.Click += (s, e) => { this.DialogResult = DialogResult.OK; };

            this.Controls.Add(lblPrompt);
            this.Controls.Add(txtFileName);
            this.Controls.Add(btnOK);
        }
    }
}

