namespace TaskCancellationDemo
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
            textBoxUrl = new TextBox();
            buttonDownload = new Button();
            buttonCancel = new Button();
            progressBar1 = new ProgressBar();
            labelStatus = new Label();
            labelSpeed = new Label();
            label2 = new Label();
            listBoxLog = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 34);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 0;
            label1.Text = "İndirelecek dosya url:";
            // 
            // textBoxUrl
            // 
            textBoxUrl.Location = new Point(195, 37);
            textBoxUrl.Name = "textBoxUrl";
            textBoxUrl.Size = new Size(593, 27);
            textBoxUrl.TabIndex = 1;
            textBoxUrl.Text = "https://file-examples.com/wp-content/storage/2017/02/file-sample_100kB.doc";
            // 
            // buttonDownload
            // 
            buttonDownload.Location = new Point(573, 75);
            buttonDownload.Name = "buttonDownload";
            buttonDownload.Size = new Size(94, 29);
            buttonDownload.TabIndex = 2;
            buttonDownload.Text = "İndir";
            buttonDownload.UseVisualStyleBackColor = true;
            buttonDownload.Click += buttonDownload_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(694, 77);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "İptal";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(143, 135);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(524, 29);
            progressBar1.TabIndex = 4;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(143, 187);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(53, 20);
            labelStatus.TabIndex = 5;
            labelStatus.Text = "Hazır...";
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(418, 189);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(28, 20);
            labelSpeed.TabIndex = 6;
            labelSpeed.Text = "[...]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 279);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 7;
            label2.Text = "İşlem geçmişi";
            // 
            // listBoxLog
            // 
            listBoxLog.FormattingEnabled = true;
            listBoxLog.Location = new Point(391, 283);
            listBoxLog.Name = "listBoxLog";
            listBoxLog.Size = new Size(217, 144);
            listBoxLog.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxLog);
            Controls.Add(label2);
            Controls.Add(labelSpeed);
            Controls.Add(labelStatus);
            Controls.Add(progressBar1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonDownload);
            Controls.Add(textBoxUrl);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUrl;
        private Button buttonDownload;
        private Button buttonCancel;
        private ProgressBar progressBar1;
        private Label labelStatus;
        private Label labelSpeed;
        private Label label2;
        private ListBox listBoxLog;
    }
}
