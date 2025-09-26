using System.Diagnostics;
using System.Threading.Tasks;

namespace AdvancedAsyncPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonAsync_Click(object sender, EventArgs e)
        {

            //Stabil deðil: UI Thread'de devam etmeye çalýþacak. UI donabilir.
            string result1 = await DownloadData("https://jsonplaceholder.typicode.com/posts");

            //Boþ olan herhangi bir thread'e dönmesini istiyoruz.
            string result2 = await DownloadData("https://jsonplaceholder.typicode.com/posts").ConfigureAwait(false);

            //Bu satýrda, hangi thread'deyiz? result1 için Form'un thread result2 için ise bilmiyoruz.
            updateUI(result2);
        }

        void updateUI(string input)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => updateUI(input)));
                return;
            }

            richTextBox1.Text = input;


        }

        async Task<string> DownloadData(string url)
        {

            //await Task.Delay(5000);
            HttpClient httpClient = new HttpClient();
            var message = await httpClient.GetAsync(url);
            message.EnsureSuccessStatusCode();

            return await message.Content.ReadAsStringAsync();

        }
        Stopwatch stopwatch;
        private async void buttonSlow_Click(object sender, EventArgs e)
        {
            stopwatch = Stopwatch.StartNew();
            PerformanceComparison performanceComparison = new PerformanceComparison();

            richTextBox1.Text = await performanceComparison.SlowVersionAsync();
            stopwatch.Stop();
            labelTime.Text = stopwatch.ElapsedMilliseconds.ToString();

        }

        private async void buttonFast_Click(object sender, EventArgs e)
        {
            stopwatch = Stopwatch.StartNew();
            PerformanceComparison performanceComparison = new PerformanceComparison();
            richTextBox1.Text = await performanceComparison.FastVersionAsync();
            stopwatch.Stop();
            labelTime.Text = stopwatch.ElapsedMilliseconds.ToString();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private async void buttonTest_Click(object sender, EventArgs e)
        {
            Trace.WriteLine($"UI Thread ID: {Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(1000);
            Trace.WriteLine($"UI Thread'a 1 sn sonra geri döndük: {Thread.CurrentThread.ManagedThreadId}");

            await Task.Delay(1000).ConfigureAwait(false);
            Trace.WriteLine($"Thread pool içindeyiz (1 sn sonra) : {Thread.CurrentThread.ManagedThreadId}");


            //   this.Text = "Güncellendi";

            await this.InvokeAsync(() =>
            {
                this.Text = "Güncellendi";
            }); 

        }
    }
}
