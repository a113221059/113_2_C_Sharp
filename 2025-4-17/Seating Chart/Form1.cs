namespace Seating_Chart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LocalizeComponents();
        }

        private void LocalizeComponents()
        {
            // �ק露�� Text �ݩʬ��c�餤��
            this.Text = "�y���"; // �ק�����D
            displayPriceButton.Text = "��ܻ���";
            exitButton.Text = "�h�X";
            // �p�G����L����A�̦��ק復�̪� Text �ݩ�
        }

        private void displayPriceButton_Click(object sender, EventArgs e)
        {
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // �������
            this.Close();
        }
    }
}
