namespace AdvancedAsyncPatterns
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
            buttonAsync = new Button();
            richTextBox1 = new RichTextBox();
            buttonSlow = new Button();
            buttonFast = new Button();
            buttonClear = new Button();
            labelTime = new Label();
            buttonTest = new Button();
            SuspendLayout();
            // 
            // buttonAsync
            // 
            buttonAsync.Location = new Point(30, 77);
            buttonAsync.Name = "buttonAsync";
            buttonAsync.Size = new Size(94, 29);
            buttonAsync.TabIndex = 0;
            buttonAsync.Text = "Asenkron";
            buttonAsync.UseVisualStyleBackColor = true;
            buttonAsync.Click += buttonAsync_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(30, 126);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(585, 237);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // buttonSlow
            // 
            buttonSlow.Location = new Point(130, 77);
            buttonSlow.Name = "buttonSlow";
            buttonSlow.Size = new Size(94, 29);
            buttonSlow.TabIndex = 2;
            buttonSlow.Text = "Yavaş";
            buttonSlow.UseVisualStyleBackColor = true;
            buttonSlow.Click += buttonSlow_Click;
            // 
            // buttonFast
            // 
            buttonFast.Location = new Point(230, 77);
            buttonFast.Name = "buttonFast";
            buttonFast.Size = new Size(94, 29);
            buttonFast.TabIndex = 3;
            buttonFast.Text = "Hızlı";
            buttonFast.UseVisualStyleBackColor = true;
            buttonFast.Click += buttonFast_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(33, 381);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "Temizle";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(136, 384);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(18, 20);
            labelTime.TabIndex = 5;
            labelTime.Text = "...";
            // 
            // buttonTest
            // 
            buttonTest.Location = new Point(230, 384);
            buttonTest.Name = "buttonTest";
            buttonTest.Size = new Size(189, 29);
            buttonTest.TabIndex = 6;
            buttonTest.Text = "ConfigureAwait";
            buttonTest.UseVisualStyleBackColor = true;
            buttonTest.Click += buttonTest_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTest);
            Controls.Add(labelTime);
            Controls.Add(buttonClear);
            Controls.Add(buttonFast);
            Controls.Add(buttonSlow);
            Controls.Add(richTextBox1);
            Controls.Add(buttonAsync);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAsync;
        private RichTextBox richTextBox1;
        private Button buttonSlow;
        private Button buttonFast;
        private Button buttonClear;
        private Label labelTime;
        private Button buttonTest;
    }
}
