using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLOverview
{
    public class ImageProcessor
    {
        public void ProcessImageSequental(string[] imagePaths)
        {
            var stopWatch = Stopwatch.StartNew();

            foreach (var path in imagePaths)
            {
                processSingleImage(path);
            }
            stopWatch.Stop();
            Console.WriteLine($"Sıralı işlem, {stopWatch.ElapsedMilliseconds} ms sürdü");
        }

        public void ProcessImageParallel(string[] imagePaths)
        {
            var stopWatch = Stopwatch.StartNew();
            Parallel.ForEach(imagePaths, image => { 
                processSingleImage(image);
            });

            stopWatch.Stop();
            Console.WriteLine($"Paralel işlem, {stopWatch.ElapsedMilliseconds} ms sürdü");
        }

        private void processSingleImage(string path)
        {
            Thread.Sleep(150);
            Console.WriteLine($"{path} Resmi, {Thread.CurrentThread.ManagedThreadId} id'li thread'de işlendi");
        }
    }
}
