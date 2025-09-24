namespace dynamicAndDLR
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
            buttonDynamicKeyword = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonDynamicKeyword
            // 
            buttonDynamicKeyword.Location = new Point(28, 43);
            buttonDynamicKeyword.Name = "buttonDynamicKeyword";
            buttonDynamicKeyword.Size = new Size(94, 29);
            buttonDynamicKeyword.TabIndex = 0;
            buttonDynamicKeyword.Text = "dynamic...";
            buttonDynamicKeyword.UseVisualStyleBackColor = true;
            buttonDynamicKeyword.Click += buttonDynamicKeyword_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 99);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "JSON Parser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(buttonDynamicKeyword);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDynamicKeyword;
        private Button button1;
    }
}
