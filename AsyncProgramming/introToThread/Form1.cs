using System.Threading.Tasks;

namespace introToThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10000; i++)
            {
                labelSenkron.Text = i.ToString();
            }

            MessageBox.Show("�� bitti");
        }

        Thread thread = null;
        private void buttonAsync_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(Loop));
            thread.Start();
            MessageBox.Show("Thread Bitti");
        }

        void Loop()
        {
            for (int i = 0; i <= 10000; i++)
            {
                labelAsync.Text = i.ToString();
                progressBar1.Value = i / 100;
            }

            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Join();



        }

        private async void buttonTask_Click(object sender, EventArgs e)
        {

            ////bunu bekle:
            await Task.Run(taskLoop);

            //await taskLoop();
            //bekledi�in i� bittikten sonra �al��t�r:
            MessageBox.Show("Thread Bitti");



        }

        private async Task taskLoop()
        {
            for (int i = 0; i < 10000; i++)
            {
                labelTask.Text = i.ToString();
            }
        }
    }
}
