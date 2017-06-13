namespace Main_NumberGuessing
{
    partial class GuessGameForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.GuessButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.Number1TextBox = new System.Windows.Forms.TextBox();
            this.Number2TextBox = new System.Windows.Forms.TextBox();
            this.Number3TextBox = new System.Windows.Forms.TextBox();
            this.Number4TextBox = new System.Windows.Forms.TextBox();
            this.GuessTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(35, 277);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(75, 33);
            this.GuessButton.TabIndex = 5;
            this.GuessButton.Text = "送出";
            this.GuessButton.UseMnemonic = false;
            this.GuessButton.UseVisualStyleBackColor = true;
            this.GuessButton.Click += new System.EventHandler(this.GuessButton_Click);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(96, 324);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(40, 12);
            this.AnswerLabel.TabIndex = 7;
            this.AnswerLabel.Text = "Answer";
            // 
            // Number1TextBox
            // 
            this.Number1TextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number1TextBox.Location = new System.Drawing.Point(35, 22);
            this.Number1TextBox.Name = "Number1TextBox";
            this.Number1TextBox.Size = new System.Drawing.Size(27, 27);
            this.Number1TextBox.TabIndex = 8;
            // 
            // Number2TextBox
            // 
            this.Number2TextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number2TextBox.Location = new System.Drawing.Point(83, 22);
            this.Number2TextBox.Name = "Number2TextBox";
            this.Number2TextBox.Size = new System.Drawing.Size(27, 27);
            this.Number2TextBox.TabIndex = 9;
            // 
            // Number3TextBox
            // 
            this.Number3TextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number3TextBox.Location = new System.Drawing.Point(127, 22);
            this.Number3TextBox.Name = "Number3TextBox";
            this.Number3TextBox.Size = new System.Drawing.Size(27, 27);
            this.Number3TextBox.TabIndex = 10;
            // 
            // Number4TextBox
            // 
            this.Number4TextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Number4TextBox.Location = new System.Drawing.Point(172, 22);
            this.Number4TextBox.Name = "Number4TextBox";
            this.Number4TextBox.Size = new System.Drawing.Size(27, 27);
            this.Number4TextBox.TabIndex = 11;
            // 
            // GuessTextBox
            // 
            this.GuessTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.GuessTextBox.Location = new System.Drawing.Point(35, 65);
            this.GuessTextBox.Multiline = true;
            this.GuessTextBox.Name = "GuessTextBox";
            this.GuessTextBox.Size = new System.Drawing.Size(75, 196);
            this.GuessTextBox.TabIndex = 12;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ResultTextBox.Location = new System.Drawing.Point(125, 65);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(74, 196);
            this.ResultTextBox.TabIndex = 13;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(125, 277);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(72, 33);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "重設密碼";
            this.ResetButton.UseMnemonic = false;
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // GuessGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 343);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.GuessTextBox);
            this.Controls.Add(this.Number4TextBox);
            this.Controls.Add(this.Number3TextBox);
            this.Controls.Add(this.Number2TextBox);
            this.Controls.Add(this.Number1TextBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.GuessButton);
            this.Name = "GuessGameForm";
            this.Text = "猜數字";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox Number1TextBox;
        private System.Windows.Forms.TextBox Number2TextBox;
        private System.Windows.Forms.TextBox Number3TextBox;
        private System.Windows.Forms.TextBox Number4TextBox;
        private System.Windows.Forms.TextBox GuessTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ResetButton;
    }
}

