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
            // 修改元件的 Text 屬性為繁體中文
            this.Text = "座位表"; // 修改表單標題
            displayPriceButton.Text = "顯示價格";
            exitButton.Text = "退出";
            // 如果有其他元件，依次修改它們的 Text 屬性
        }

        private void displayPriceButton_Click(object sender, EventArgs e)
        {
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
