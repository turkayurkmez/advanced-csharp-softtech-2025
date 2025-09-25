using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBagInWindows
{
    public partial class Form2 : Form
    {

        private dynamic formBag;
        public Form2(dynamic formBag)
        {
            InitializeComponent();
            this.formBag = formBag;


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Image = formBag.Image;
            Width = pictureBox.Width + 150;
            Height = pictureBox.Height + 150;

            pictureBox.Location = new Point(0, 0);

            Label label = new Label { Text = formBag.ImageText, Location = new Point(0, pictureBox.Height + 20) };

            Controls.Add(pictureBox);
            Controls.Add(label);



        }
    }
}
