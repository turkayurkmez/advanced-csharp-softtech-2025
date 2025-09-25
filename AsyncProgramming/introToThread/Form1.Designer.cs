namespace introToThread
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
            buttonSync = new Button();
            groupBox1 = new GroupBox();
            labelSenkron = new Label();
            groupBox2 = new GroupBox();
            progressBar1 = new ProgressBar();
            labelAsync = new Label();
            buttonAsync = new Button();
            groupBox3 = new GroupBox();
            progressBar2 = new ProgressBar();
            labelTask = new Label();
            buttonTask = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSync
            // 
            buttonSync.Location = new Point(99, 44);
            buttonSync.Name = "buttonSync";
            buttonSync.Size = new Size(94, 29);
            buttonSync.TabIndex = 0;
            buttonSync.Text = "Senkron";
            buttonSync.UseVisualStyleBackColor = true;
            buttonSync.Click += buttonSync_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelSenkron);
            groupBox1.Controls.Add(buttonSync);
            groupBox1.Location = new Point(108, 123);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senkron işlem";
            // 
            // labelSenkron
            // 
            labelSenkron.AutoSize = true;
            labelSenkron.Location = new Point(116, 88);
            labelSenkron.Name = "labelSenkron";
            labelSenkron.Size = new Size(18, 20);
            labelSenkron.TabIndex = 1;
            labelSenkron.Text = "...";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBar1);
            groupBox2.Controls.Add(labelAsync);
            groupBox2.Controls.Add(buttonAsync);
            groupBox2.Location = new Point(441, 123);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(297, 208);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "ASenkron işlem -Thread";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(56, 145);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(164, 29);
            progressBar1.TabIndex = 2;
            // 
            // labelAsync
            // 
            labelAsync.AutoSize = true;
            labelAsync.Location = new Point(116, 88);
            labelAsync.Name = "labelAsync";
            labelAsync.Size = new Size(18, 20);
            labelAsync.TabIndex = 1;
            labelAsync.Text = "...";
            // 
            // buttonAsync
            // 
            buttonAsync.ForeColor = Color.Crimson;
            buttonAsync.Location = new Point(99, 44);
            buttonAsync.Name = "buttonAsync";
            buttonAsync.Size = new Size(94, 29);
            buttonAsync.TabIndex = 0;
            buttonAsync.Text = "Asenkron";
            buttonAsync.UseVisualStyleBackColor = true;
            buttonAsync.Click += buttonAsync_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(progressBar2);
            groupBox3.Controls.Add(labelTask);
            groupBox3.Controls.Add(buttonTask);
            groupBox3.Location = new Point(769, 123);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(297, 208);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "ASenkron işlem -Task";
            // 
            // progressBar2
            // 
            progressBar2.Location = new Point(56, 145);
            progressBar2.Name = "progressBar2";
            progressBar2.Size = new Size(164, 29);
            progressBar2.TabIndex = 2;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(116, 88);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(18, 20);
            labelTask.TabIndex = 1;
            labelTask.Text = "...";
            // 
            // buttonTask
            // 
            buttonTask.ForeColor = Color.Crimson;
            buttonTask.Location = new Point(99, 44);
            buttonTask.Name = "buttonTask";
            buttonTask.Size = new Size(94, 29);
            buttonTask.TabIndex = 0;
            buttonTask.Text = "Asenkron";
            buttonTask.UseVisualStyleBackColor = true;
            buttonTask.Click += buttonTask_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSync;
        private GroupBox groupBox1;
        private Label labelSenkron;
        private GroupBox groupBox2;
        private Label labelAsync;
        private Button buttonAsync;
        private ProgressBar progressBar1;
        private GroupBox groupBox3;
        private ProgressBar progressBar2;
        private Label labelTask;
        private Button buttonTask;
    }
}
