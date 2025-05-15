namespace Telephone_Unformat
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// 用於管理表單中的元件。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理正在使用的所有資源。
        /// 如果參數 disposing 為 true，則釋放所有受管理的資源。
        /// </summary>
        /// <param name="disposing">如果需要釋放受管理資源，則為 true；否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose(); // 釋放元件資源
            }
            base.Dispose(disposing); // 呼叫基底類別的 Dispose 方法
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 設計工具支援的必要方法。
        /// 請勿使用程式碼編輯器修改此方法的內容。
        /// 此方法負責初始化表單中的所有元件。
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.unformatButton = new System.Windows.Forms.Button();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(145, 98);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 21);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "結束";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // unformatButton
            // 
            this.unformatButton.Location = new System.Drawing.Point(64, 98);
            this.unformatButton.Name = "unformatButton";
            this.unformatButton.Size = new System.Drawing.Size(75, 21);
            this.unformatButton.TabIndex = 6;
            this.unformatButton.Text = "移除格式";
            this.unformatButton.UseVisualStyleBackColor = true;
            this.unformatButton.Click += new System.EventHandler(this.unformatButton_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.Location = new System.Drawing.Point(12, 11);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(260, 37);
            this.instructionLabel.TabIndex = 5;
            this.instructionLabel.Text = "請輸入電話號碼，格式為 (XXX)XXX-XXXX，我將移除其格式。";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instructionLabel.Click += new System.EventHandler(this.instructionLabel_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(92, 62);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.unformatButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.numberTextBox);
            this.Name = "Form1";
            this.Text = "電話號碼格式移除";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton; // "Exit" 按鈕
        private System.Windows.Forms.Button unformatButton; // "Unformat" 按鈕
        private System.Windows.Forms.Label instructionLabel; // 顯示指示文字的標籤
        private System.Windows.Forms.TextBox numberTextBox; // 用於輸入電話號碼的文字框
    }
}

