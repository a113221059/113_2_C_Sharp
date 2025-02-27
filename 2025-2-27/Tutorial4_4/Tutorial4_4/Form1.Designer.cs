namespace Tutorial4_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            distanceTextbox = new TextBox();
            gasTextbox = new TextBox();
            label4 = new Label();
            averageLabel = new Label();
            calcuateButton = new Button();
            button2 = new Button();
            loglistBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(105, 75);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(105, 143);
            label2.Name = "label2";
            label2.Size = new Size(143, 24);
            label2.TabIndex = 1;
            label2.Text = "消耗油量公升數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(105, 228);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 2;
            label3.Text = "您的平均油耗";
            // 
            // distanceTextbox
            // 
            distanceTextbox.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            distanceTextbox.Location = new Point(297, 75);
            distanceTextbox.Name = "distanceTextbox";
            distanceTextbox.Size = new Size(139, 28);
            distanceTextbox.TabIndex = 3;
            // 
            // gasTextbox
            // 
            gasTextbox.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gasTextbox.Location = new Point(297, 143);
            gasTextbox.Name = "gasTextbox";
            gasTextbox.Size = new Size(139, 28);
            gasTextbox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(334, 235);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // averageLabel
            // 
            averageLabel.BorderStyle = BorderStyle.Fixed3D;
            averageLabel.Location = new Point(297, 237);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(139, 23);
            averageLabel.TabIndex = 6;
            // 
            // calcuateButton
            // 
            calcuateButton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            calcuateButton.Location = new Point(121, 316);
            calcuateButton.Name = "calcuateButton";
            calcuateButton.Size = new Size(135, 38);
            calcuateButton.TabIndex = 7;
            calcuateButton.Text = "計算";
            calcuateButton.UseVisualStyleBackColor = true;
            calcuateButton.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button2.Location = new Point(323, 316);
            button2.Name = "button2";
            button2.Size = new Size(154, 36);
            button2.TabIndex = 8;
            button2.Text = "離開";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // loglistBox
            // 
            loglistBox.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            loglistBox.FormattingEnabled = true;
            loglistBox.ItemHeight = 20;
            loglistBox.Location = new Point(529, 75);
            loglistBox.Name = "loglistBox";
            loglistBox.Size = new Size(188, 204);
            loglistBox.TabIndex = 9;
            loglistBox.SelectedIndexChanged += loglistBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(554, 314);
            button1.Name = "button1";
            button1.Size = new Size(135, 38);
            button1.TabIndex = 10;
            button1.Text = "總平均油耗";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(loglistBox);
            Controls.Add(button2);
            Controls.Add(calcuateButton);
            Controls.Add(averageLabel);
            Controls.Add(label4);
            Controls.Add(gasTextbox);
            Controls.Add(distanceTextbox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox distanceTextbox;
        private TextBox gasTextbox;
        private Label label4;
        private Label averageLabel;
        private Button calcuateButton;
        private Button button2;
        private ListBox loglistBox;
        private Button button1;
    }
}
