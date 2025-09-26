using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPLOverview
{
    public class OptimizedImageProcessor 
    {
        public void ProcessImageParallel(string[] imagePaths, CancellationToken cancellationToken)
        {
            var stopWatch = Stopwatch.StartNew();

            var parallelOptions = new ParallelOptions()
            {
                CancellationToken = cancellationToken,
                MaxDegreeOfParallelism = Environment.ProcessorCount,

                //Schedule: zaman ayarı. Bu ayarlı işlemci belirliyor ve iki seçenek var. Current veya Default
                TaskScheduler = TaskScheduler.Default

            };
           // Console.WriteLine($"Çekirdek sayısı: {Environment.ProcessorCount}");

            var processCount = 0;

            var lockObject = new object();

            try
            {
                Parallel.ForEach(imagePaths,parallelOptions, (image,loopState) => {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        loopState.Break();
                        return;
                    }

                    try
                    {

                        processSingleImage(image);
                        lock (lockObject)
                        {
                            processCount++;
                            if (processCount % 2 == 0)
                            {
                             
                                Console.WriteLine($"{processCount} adet resim işlendi");
                            }
                        }
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                    }


                });


            }
            catch (OperationCanceledException ex)
            {

                Console.WriteLine("Paralel işlem iptal edildi....");
            }
          

            stopWatch.Stop();
            Console.WriteLine($"Paralel işlem, {stopWatch.ElapsedMilliseconds} ms sürdü");
        }

        private void processSingleImage(string image)
        {

            Thread.Sleep(150);
            Console.WriteLine($"\n{image} Resmi, {Thread.CurrentThread.ManagedThreadId} id'li thread'de işlendi");
            Console.WriteLine("----------------------------------------------");
        }
    }
}
