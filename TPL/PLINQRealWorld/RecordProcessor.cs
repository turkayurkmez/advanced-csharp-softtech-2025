using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLINQRealWorld
{
    public class RecordProcessor
    {
        public async Task ProcessLargeDataAsync()
        {
            Console.WriteLine("Büyüv eri seti işlenecek...");

            var records = generateRecords(1_000_000);

            var parallelOptions = new ParallelOptions()
            {
                CancellationToken = CancellationToken.None,
                MaxDegreeOfParallelism = Math.Max(1, Environment.ProcessorCount - 1)
            };

            var stopWatch = Stopwatch.StartNew();
            var processCount = 0;
            var lockObject = new object();

            var partitioner = Partitioner.Create(records, true);

            await Task.Run(() =>
            {
                Parallel.ForEach(partitioner, parallelOptions, partition =>
                {
                    var localProcesorCount = 0;
                    var batchResults = new List<ProcessedRecord>();

                    foreach (var record in partitioner.AsParallel())
                    {
                        var proccessed = processRecord(record);
                        batchResults.Add(proccessed);
                        localProcesorCount++;

                        if (localProcesorCount % 1000 == 0)
                        {
                            lock (lockObject)
                            {
                                processCount += 1000;
                                Console.WriteLine($"İşlenen: {processCount: N0} ");
                            }
                        }
                    }

                    SaveBatch(batchResults);

                    lock (lockObject)
                    {
                        processCount += localProcesorCount % 1000;
                    }
                });
            });

            stopWatch.Stop();
            Console.WriteLine($"{records.Count:N0} kayıt {stopWatch.Elapsed.TotalSeconds} saniyede işlendi");
            Console.WriteLine($"saniyede işlenen kayıt: {records.Count / stopWatch.Elapsed.TotalSeconds}");
        }

        private void SaveBatch(List<ProcessedRecord> batchResults)
        {
          Thread.Sleep(1);
        }

        private ProcessedRecord processRecord(DataRecord record)
        {
            var result = 0.0;
            for (int i = 0; i < 100; i++)
            {
                result += Math.Sin(record.Value + i) * Math.Cos(record.Value - i);
            }

            return new ProcessedRecord
            {
                Id = record.Id,
                ProcessedValue = result,
                Category = record.Category,
            };
        }

        private List<DataRecord> generateRecords(int count)
        {
            var random = new Random(42);
            return Enumerable.Range(1, count)
                   .Select(i => new DataRecord
                   {
                       Id = i,
                       Value = random.NextDouble() * 1000,
                       Category = $"Cat-{random.Next(1, 10)}"

                   }).ToList();
        }
    }

    public class ProcessedRecord
    {
        public int Id { get; set; }
        public double ProcessedValue { get; set; }
        public string Category { get; set; }
    }

    public class DataRecord
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public string Category { get; set; }
    }
}
