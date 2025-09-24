namespace Display.ApplicationForm
{
    partial class Form1 : Form
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
            menuStrip1 = new MenuStrip();
            pluginsToolStripMenuItem = new ToolStripMenuItem();
            addPluginToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            numericUpDownHeight = new NumericUpDown();
            numericUpDownWidth = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            numericUpDownX = new NumericUpDown();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pluginsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pluginsToolStripMenuItem
            // 
            pluginsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPluginToolStripMenuItem, toolStripMenuItem1 });
            pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            pluginsToolStripMenuItem.Size = new Size(70, 24);
            pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // addPluginToolStripMenuItem
            // 
            addPluginToolStripMenuItem.Name = "addPluginToolStripMenuItem";
            addPluginToolStripMenuItem.Size = new Size(165, 26);
            addPluginToolStripMenuItem.Text = "Add Plugin";
            addPluginToolStripMenuItem.Click += addPluginToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(162, 6);
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(numericUpDownHeight);
            splitContainer1.Panel1.Controls.Add(numericUpDownWidth);
            splitContainer1.Panel1.Controls.Add(numericUpDownY);
            splitContainer1.Panel1.Controls.Add(numericUpDownX);
            splitContainer1.Size = new Size(800, 422);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 195);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 7;
            label3.Text = "Height";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 160);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 6;
            label4.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 98);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 5;
            label2.Text = "Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 63);
            label1.Name = "label1";
            label1.Size = new Size(18, 20);
            label1.TabIndex = 4;
            label1.Text = "X";
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(108, 193);
            numericUpDownHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(79, 27);
            numericUpDownHeight.TabIndex = 3;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(108, 160);
            numericUpDownWidth.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(79, 27);
            numericUpDownWidth.TabIndex = 2;
            // 
            // numericUpDownY
            // 
            numericUpDownY.Location = new Point(108, 91);
            numericUpDownY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(79, 27);
            numericUpDownY.TabIndex = 1;
            // 
            // numericUpDownX
            // 
            numericUpDownX.Location = new Point(108, 58);
            numericUpDownX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(79, 27);
            numericUpDownX.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pluginsToolStripMenuItem;
        private ToolStripMenuItem addPluginToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private SplitContainer splitContainer1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownHeight;
        private NumericUpDown numericUpDownWidth;
        private NumericUpDown numericUpDownY;
        private NumericUpDown numericUpDownX;
    }
}
