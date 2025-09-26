using System.Data;
using System.Threading.Tasks;

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

        private async void buttonDownload_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            labelStatus.Text = "Ýndirme baþlýyor";
            labelSpeed.Text = string.Empty;

            _cancellationTokenSource = new CancellationTokenSource();

            try
            {
                AddLog("Ýndirme baþlatýldý");
                AddLog($"URL: {textBoxUrl.Text}");
                await DownloadFileAsync(textBoxUrl.Text, _cancellationTokenSource.Token);
                AddLog("Ýndirme tamamlandý");
            }
            catch (OperationCanceledException ex)
            {
                AddLog("Ýþlem kullanýcý tarafýndan iptal edildi");
                labelStatus.Text = "Ýptal edildi";
                progressBar1.Value = 0;


            }
            catch (Exception ex)
            {
                AddLog($"Hata! {ex.Message}");
                labelStatus.Text = $"Hata! {ex.Message}";
            }
            finally
            {
                _cancellationTokenSource?.Dispose();
                _cancellationTokenSource = null;


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

                AddLog($"Dosya boyutu: {formatBytes(totalBytes)}");

                using var stream = await response.Content.ReadAsStreamAsync();
                var buffer = new byte[8192]; //8KB -> 8192 Byte
                int bytesRead;

                if (totalBytes > 0)
                {
                    progressBar1.Maximum = (int)Math.Min(totalBytes, int.MaxValue);

                }

                UpdateStatus("Download Devam ediyor");

                while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)) > 0)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    totalBytesDownloaded += bytesRead;

                    if (totalBytes > 0)
                    {



                        progressBar1.Value = (int)Math.Min((int)totalBytesDownloaded, progressBar1.Maximum);

                        var elapsed = DateTime.Now - startTime;
                        var speed = elapsed.TotalSeconds > 0 ? totalBytesDownloaded / elapsed.TotalSeconds : 0;

                        var percentage = (int)((totalBytesDownloaded * 100) / totalBytes);
                        UpdateStatus($"Ýndiriliyor... %{percentage}");
                        labelSpeed.Text = $"{formatBytes((long) speed)}/s";
                    }

                    if (totalBytesDownloaded % (1024 * 1024) == 0)
                    {
                        AddLog($"{totalBytesDownloaded} byte indirildi");
                    }
                }

                var totalElapsed = DateTime.Now - startTime;
                var averageSpeed = totalElapsed.TotalSeconds > 0 ? totalBytesDownloaded / totalElapsed.TotalSeconds : 0;

                AddLog($"Ortalama hýz: {formatBytes((long)averageSpeed)}");
                AddLog($"Toplam indirme süresi: {totalElapsed:mm\\:ss}");


            }
            catch (HttpRequestException ex)
            {

                throw new Exception($"Http hatasý: {ex.Message} ");
            }
            catch (TaskCanceledException ex)
            {
                throw new OperationCanceledException("Ýþlem iptal edildi", ex);
            }

        }

        private string formatBytes(long bytes)
        {
            string[] suffixes = ["B", "KB", "MB", "GB"];
            int counter = 0;

            decimal number = bytes;
            while (Math.Round(number /1024)>=1)
            {
                number = number /1024;
                counter++;
            }

            return $"{number:n1} {suffixes[counter]}";
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
                return;
            }
            var timeSpamp = DateTime.Now.ToString("HH:mm:ss");
            listBoxLog.Items.Add($"[{timeSpamp}] - {process} ");
            listBoxLog.TopIndex = Math.Max(0, listBoxLog.Items.Count - 1);
            if (listBoxLog.Items.Count > 100)
            {
                listBoxLog.Items.Remove(0);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            AddLog("Ýptal sinayli gönderildi");
            labelStatus.Text = "Ýptal talebi geldi";

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _cancellationTokenSource?.Cancel();
            httpClient?.Dispose();
        }
    }
}
