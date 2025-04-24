using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        private List<int> testScores = new List<int>();
        private OpenFileDialog openFile = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }
        private double Average(int[] scores)
        {
            int total = 0;
            foreach (int score in scores)
            {
                total += score;
            }
            return (double)total / scores.Length;
        }


        // Highest 方法接受一個 int 陣列參數
        // 並返回該陣列中的最高值。
        private int Highest(int[] scores)
        {
            int highest = scores[0];
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > highest)
                {
                    highest = scores[i];
                }
            }
            return highest;
        }

        // Lowest 方法接受一個 int 陣列參數
        // 並返回該陣列中的最低值。
        private int Lowest(int[] scores)
        {
            int lowest = scores[0];
            foreach (int score in scores)
            {
                if (score < lowest)
                {
                    lowest = score;
                }
            }
            return lowest;
        }

      

        private void exitButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {


            sortedScoresListBox.Items.Clear();
            List<int> sortedScores = new List<int>(testScores);
            sortedScores.Sort();
            foreach (int score in sortedScores)
            {
                sortedScoresListBox.Items.Add(score);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 確認是否有選擇項目
            if (testScoresListBox.SelectedIndex != -1)
            {
                // 取得選擇的索引
                int selectedIndex = testScoresListBox.SelectedIndex;

                // 從 testScores 中移除對應索引的資料
                testScores.RemoveAt(selectedIndex);

                // 更新 testScoresListBox
                testScoresListBox.Items.Clear();
                foreach (int score in testScores)
                {
                    testScoresListBox.Items.Add(score);
                }

                // 更新 sortedScoresListBox
                sortedScoresListBox.Items.Clear();
                List<int> sortedScores = new List<int>(testScores);
                sortedScores.Sort();
                foreach (int score in sortedScores)
                {
                    sortedScoresListBox.Items.Add(score);
                }
            }
            else
            {
                // 如果沒有選擇項目，顯示提示訊息
                MessageBox.Show("請選擇要刪除的分數", "提示");
            }
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            const int SIZE = 48;
            int[] testscores = new int[SIZE];
            int index = 0;
            int highestScore = 0;
            int lowestScore = 0;
            double averageScore = 0.0;

            StreamReader inputFile;
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(openFile.FileName);
                    while (!inputFile.EndOfStream && index < SIZE)
                    {
                        testscores[index] = Convert.ToInt32(inputFile.ReadLine());
                        testScores.Add(testscores[index]);
                        testScoresListBox.Items.Add(testscores[index]);
                        index++;
                    }
                    inputFile.Close();
                    averageScore = Average(testscores);
                    highestScore = Highest(testscores);
                    lowestScore = Lowest(testscores);
                    averageScoreLabel.Text = averageScore.ToString("n1");
                    highScoreLabel.Text = highestScore.ToString();
                    lowScoreLabel.Text = lowestScore.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤");
            }
        }
    }
}