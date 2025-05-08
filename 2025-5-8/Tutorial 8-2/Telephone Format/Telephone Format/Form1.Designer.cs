namespace Telephone_Format
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計器變數。
        /// 用於管理表單中的元件。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理任何正在使用的資源。
        /// 如果參數 disposing 為 true，則釋放托管資源。
        /// </summary>
        /// <param name="disposing">如果為 true，則釋放托管資源；否則僅釋放非托管資源。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // 釋放元件資源
            }
            base.Dispose(disposing); // 呼叫基底類別的 Dispose 方法
        }

        #region Windows 表單設計器產生的程式碼

        /// <summary>
        /// 設計器支援所需的方法。
        /// 此方法用於初始化表單中的所有元件。
        /// 請勿手動修改此方法的內容，應透過設計器進行更改。
        /// </summary>
        private void InitializeComponent()
        {
            // 建立一個文字框，用於讓使用者輸入 10 位數字
            this.numberTextBox = new System.Windows.Forms.TextBox();

            // 建立一個標籤，用於顯示指示訊息，告知使用者應輸入的內容
            this.instructionLabel = new System.Windows.Forms.Label();

            // 建立一個按鈕，用於觸發格式化電話號碼的功能
            this.formatButton = new System.Windows.Forms.Button();

            // 建立一個按鈕，用於退出應用程式
            this.exitButton = new System.Windows.Forms.Button();

            // 開始初始化表單
            this.SuspendLayout();

            // 
            // numberTextBox
            // 
            // 設定文字框的位置、名稱和大小
            this.numberTextBox.Location = new System.Drawing.Point(92, 67); // 設定文字框的座標位置
            this.numberTextBox.Name = "numberTextBox"; // 設定文字框的名稱
            this.numberTextBox.Size = new System.Drawing.Size(100, 20); // 設定文字框的寬度和高度
            this.numberTextBox.TabIndex = 0; // 設定 Tab 鍵的順序

            // 
            // instructionLabel
            // 
            // 設定標籤的位置、名稱、大小和顯示的文字
            this.instructionLabel.Location = new System.Drawing.Point(12, 12); // 設定標籤的座標位置
            this.instructionLabel.Name = "instructionLabel"; // 設定標籤的名稱
            this.instructionLabel.Size = new System.Drawing.Size(260, 40); // 設定標籤的寬度和高度
            this.instructionLabel.TabIndex = 1; // 設定 Tab 鍵的順序
            this.instructionLabel.Text = "輸入一個 10 位數字，我將其格式化為電話號碼。"; // 設定標籤的顯示文字
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; // 設定文字對齊方式為置中

            // 
            // formatButton
            // 
            // 設定格式化按鈕的位置、名稱和大小
            this.formatButton.Location = new System.Drawing.Point(64, 106); // 設定按鈕的座標位置
            this.formatButton.Name = "formatButton"; // 設定按鈕的名稱
            this.formatButton.Size = new System.Drawing.Size(75, 23); // 設定按鈕的寬度和高度
            this.formatButton.TabIndex = 2; // 設定 Tab 鍵的順序
            this.formatButton.Text = "格式化"; // 設定按鈕的顯示文字
            this.formatButton.UseVisualStyleBackColor = true; // 使用預設的按鈕樣式
            this.formatButton.Click += new System.EventHandler(this.formatButton_Click); // 綁定按鈕的點擊事件

            // 
            // exitButton
            // 
            // 設定退出按鈕的位置、名稱和大小
            this.exitButton.Location = new System.Drawing.Point(145, 106); // 設定按鈕的座標位置
            this.exitButton.Name = "exitButton"; // 設定按鈕的名稱
            this.exitButton.Size = new System.Drawing.Size(75, 23); // 設定按鈕的寬度和高度
            this.exitButton.TabIndex = 3; // 設定 Tab 鍵的順序
            this.exitButton.Text = "退出"; // 設定按鈕的顯示文字
            this.exitButton.UseVisualStyleBackColor = true; // 使用預設的按鈕樣式
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click); // 綁定按鈕的點擊事件

            // 
            // Form1
            // 
            // 設定表單的自動縮放比例和其他屬性
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F); // 設定表單的縮放比例
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font; // 設定表單的縮放模式
            this.ClientSize = new System.Drawing.Size(284, 140); // 設定表單的寬度和高度
            this.Controls.Add(this.exitButton); // 將退出按鈕加入表單
            this.Controls.Add(this.formatButton); // 將格式化按鈕加入表單
            this.Controls.Add(this.instructionLabel); // 將標籤加入表單
            this.Controls.Add(this.numberTextBox); // 將文字框加入表單
            this.Name = "Form1"; // 設定表單的名稱
            this.Text = "電話號碼格式化"; // 設定表單的標題
            this.ResumeLayout(false); // 停止表單的佈局邏輯
            this.PerformLayout(); // 應用表單的佈局邏輯
        }

        #endregion

        // 定義表單中的元件
        private System.Windows.Forms.TextBox numberTextBox; // 用於輸入電話號碼的文字框
        private System.Windows.Forms.Label instructionLabel; // 顯示指示訊息的標籤
        private System.Windows.Forms.Button formatButton; // 用於格式化電話號碼的按鈕
        private System.Windows.Forms.Button exitButton; // 用於退出應用程式的按鈕
    }
}

