using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace GCConfiguration
{
    public static class GCMonitoring
    {
        public static void ReportGCStatus()
        {
            Console.WriteLine("------ GC Durum Raporu ------");
            //1. Collection count:
            Console.WriteLine($"Gen0 Collections: {GC.CollectionCount(0)}");
            Console.WriteLine($"Gen1 Collections: {GC.CollectionCount(1)}");
            Console.WriteLine($"Gen2 Collections: {GC.CollectionCount(2)}");

            //bellek kullanımı:
            var totalMemory = GC.GetTotalMemory(false);
            Console.WriteLine($"Total Memory Usage:{totalMemory:N0} byte");

            //GC mode denetimi:
            Console.WriteLine($"GC Mode: {(GCSettings.IsServerGC ? "Server":"WorkStation")}");

            //Latency:
            Console.WriteLine($"Latency Mode: {GCSettings.LatencyMode}");

            //Memory Pressure:
            Console.WriteLine($"Total Available Memory {GC.GetTotalAllocatedBytes():N0}");

        }

        public static void MeasureGCPressure(Action testAction, string testName)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            var startMemory = GC.GetTotalMemory(false);
            int startGen0 = GC.CollectionCount(0);
            int startGen1 = GC.CollectionCount(1);
            int startGen2 = GC.CollectionCount(2);

            var stopWatch = Stopwatch.StartNew();
            //test edilecek parametre almayan void metot:
            testAction();
            stopWatch.Stop();


            var endMemory = GC.GetTotalMemory(false);
            int endGen0 = GC.CollectionCount(0);
            int endGen1 = GC.CollectionCount(1);
            int endGen2 = GC.CollectionCount(2);

            Console.WriteLine($"\n----- {testName} SONUÇLARI ------");

            Console.WriteLine($"Execution time: {stopWatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Memory change:{endMemory - startMemory}");
            Console.WriteLine($"Gen0 collection:{endGen0 - startGen0}");
            Console.WriteLine($"Gen1 collection:{endGen1 - startGen1}");
            Console.WriteLine($"Gen2 collection:{endGen2 - startGen2}");





        }
    }
}
