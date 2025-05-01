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

        // 新增的 TextBox 和按鈕
        private TextBox scoreTextBox;
        private TextBox positionTextBox;
        private Button insertButton;

        public Form1()
        {
            InitializeComponent();

            // 初始化新增的元件
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
           
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
            if (testScoresListBox.SelectedIndex != -1)
            {
                int selectedIndex = testScoresListBox.SelectedIndex;
                testScores.RemoveAt(selectedIndex);

                testScoresListBox.Items.Clear();
                foreach (int score in testScores)
                {
                    testScoresListBox.Items.Add(score);
                }

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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                // 驗證並解析成績
                if (!int.TryParse(textBox1.Text, out int newScore))
                {
                    MessageBox.Show("請輸入有效的整數分數。", "錯誤");
                    return;
                }

                // 驗證並解析插入位置
                if (!int.TryParse(textBox2.Text, out int position))
                {
                    MessageBox.Show("請輸入有效的插入位置。", "錯誤");
                    return;
                }

                // 檢查插入位置是否有效
                if (position < 0 || position > testScores.Count)
                {
                    MessageBox.Show("插入位置無效，請輸入有效的索引範圍。", "錯誤");
                    return;
                }

                // 插入成績
                testScores.Insert(position, newScore);

                // 更新 ListBox
                testScoresListBox.Items.Clear();
                foreach (int score in testScores)
                {
                    testScoresListBox.Items.Add(score);
                }

                // 清空 TextBox
                textBox1.Clear();
                textBox2.Clear();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"發生錯誤：{ex.Message}", "錯誤");
            }
        }
    }
}

        

        