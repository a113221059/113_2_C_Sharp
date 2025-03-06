namespace Tutorial4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double distance, gas, average;

            if (double.TryParse(distanceTextbox.Text, out distance))
            {
                if (double.TryParse(distanceTextbox.Text, out gas))
                {
                    average = distance / gas;
                    averageLabel.Text = average.ToString("f2") + "����/����;";
                    loglistBox.Items.Add(average.ToString("f2") + "����/����");
                }


                else
                {
                    MessageBox.Show("�o�ӽп�J�Ʀr");
                    gasTextbox.Focus();
                    gasTextbox.Text = "";
                }
            }

            else
            {
                MessageBox.Show("���{�ƽп�J�Ʀr");
                distanceTextbox.Focus();
                distanceTextbox.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loglistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loglistBox.Items.Clear();
            loglistBox.Items.Add("�����o�Ӭ���");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double sum = 0;
            if (loglistBox.Items.Count > 1)
            {

                for (int i = 1; i < loglistBox.Items.Count; i++)

                {
                    sum += double.Parse(loglistBox.Items[i].ToString().Replace("����/����", ""));
                }
                loglistBox.Items.Add("�����o��:" + (sum / (loglistBox.Items.Count - 1)).ToString("f2") + "����/����");
            }
            else
            {
                MessageBox.Show("�S������");
            }
            }
        }
    }

