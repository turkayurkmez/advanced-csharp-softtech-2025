using System.Dynamic;

namespace FormBagInWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dynamic bag = new ExpandoObject();
            bag.Baslik = "Form Baþlýðý";
            //MessageBox.Show(bag.Baslik);
            bag.ShowTitle = (Action)(() => { MessageBox.Show(bag.Baslik); });

            bag.ShowTitle();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            dynamic formBag = new ExpandoObject();

            formBag.ImageText = textBoxName.Text;
            formBag.Image = pictureBox1.Image;

            Form2 form2 = new Form2(formBag);
            form2.Show();
        }
    }
}
