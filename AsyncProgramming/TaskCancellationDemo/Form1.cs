using System.Data;

namespace TaskCancellationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private CancellationTokenSource _cancellationTokenSource;
        private HttpClient httpClient = new HttpClient();

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            labelStatus.Text = "Ýndirme baþlýyor";
            labelSpeed.Text = string.Empty;

            _cancellationTokenSource = new CancellationTokenSource();

            try
            {
                AddLog("Ýndirme baþlatýldý");
                AddLog($"URL: {textBoxUrl.Text}");

            }
            catch (Exception)
            {

                throw;
            }

        }

        private async Task DownloadFileAsync(string url, CancellationToken cancellationToken)
        {
            var startTime = DateTime.Now;
            long totalBytesDownloaded = 0;

            try
            {
                using var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead, cancellationToken);
                response.EnsureSuccessStatusCode();

                var totalBytes = response.Content.Headers.ContentLength ?? 0;

                AddLog($"Dosya boyutu: {totalBytes} byte");

                using var stream = await response.Content.ReadAsStreamAsync();
                var buffer = new byte[8192];
                int bytesRead;

                if (totalBytes>0)
                {
                    progressBar1.Maximum = (int)Math.Min(totalBytes, int.MaxValue);

                }

                UpdateStatus("Download Devam ediyor");

                while ((bytesRead = await stream.ReadAsync(buffer,0,buffer.Length,cancellationToken))> 0)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    progressBar1.Value = (int)Math.Min((int)totalBytesDownloaded, progressBar1.Maximum);

                    var elapsed = DateTime.Now - startTime;
                    var speed = elapsed.TotalSeconds > 0? totalBytesDownloaded / elapsed.TotalSeconds : 0;

                    var percentage = (int)((totalBytesDownloaded * 100) / totalBytes);
                    UpdateStatus($"Ýndiriliyor... %{percentage}");
                }


            }
            catch (Exception)
            {

                throw;
            }

        }

        private void UpdateStatus(string status)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => UpdateStatus(status)));

                return;
            }

            labelStatus.Text = status;
        }

        private void AddLog(string process)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => AddLog(process)));
            }
            var timeSpamp = DateTime.Now.ToString("HH:mm:ss");
            listBoxLog.Items.Add($"[{timeSpamp}] - {process} ");
            listBoxLog.TopIndex = Math.Max(0, listBoxLog.Items.Count - 1);
            if (listBoxLog.Items.Count > 100)
            {
                listBoxLog.Items.Remove(0);
            }
        }
    }
}
