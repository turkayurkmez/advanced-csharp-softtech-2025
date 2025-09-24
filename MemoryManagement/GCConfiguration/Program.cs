using GCConfiguration;
using System.Data.SqlClient;

internal class Program
{
    private static void Main(string[] args)
    {

        // var total = GC.GetTotalMemory(true);
        //Console.WriteLine($"metot çağrılmadan önce...: {total}");
        GCMonitoring.ReportGCStatus();
        GCMonitoring.MeasureGCPressure(heapBomb, "Heap Bomb Metodu");


        GCMonitoring.ReportGCStatus();

        //total = GC.GetTotalMemory(true);
        //Console.WriteLine($"metot bittikten sonra...: {total}");


        //Yayına alınan projelerde, aşağıdaki gibi bir Collect() zorlaması olmamalı.
        // Neden? GC'nin kendisi de bir maaliyet çünkü....
        // Demek ki sadece test amacıyla (monitör etmek için) kullanılmalı.
        //GC.Collect();

        //total = GC.GetTotalMemory(true);
        // Console.WriteLine($"GC çalıştıktan sonra...: {total}");

        //DemonstrateGenerations();

        //SqlConnection sqlConnection = new SqlConnection();

        //Bir nesnenin dispose() metodu varsa; bu nesne içindeki kompleks özelliklerin GC tarafından toplanmasını sağlar. 


        using FileGenerator fileGenerator = new FileGenerator();
        fileGenerator.CreateFile();

        

        


      
        
    }

    static void heapBomb()
    {
        object o = new object();
        var total = GC.GetTotalMemory(true);
      
        Console.WriteLine(total);
    }

    static void DemonstrateGenerations()
    {
        //Console.WriteLine("GC Demo başlıyor....");

        //GC: objeleri yaşam sürelerine göre üç jenerasyona ayırır:
        //Gen 0:Çok hızlı yaratılıp hemen bellekten kaldırılır.

        for (int i = 0; i < 1000; i++)
        {
            var tempObject = new object();
            //Gen 0'da oluşturulur.
            //for scope'u bitince bellekten kaldırılır.
        }

        //Console.WriteLine($"Gen0 collection:{GC.CollectionCount(0)}");

        //Gen 1: basit koleksiyonlar ya da array'ler.....
        var mediumCollection = new List<object>();
        for (int i = 0; i < 1000; i++)
        {
            mediumCollection.Add(new object());
            //Gen0'da doğar ama gen1'e terfi eder.
        }

        //GC.Collect(0); //zorla topla....
        //Console.WriteLine($"Gen1 collection:{GC.CollectionCount(1)}");
        //Console.WriteLine($"temizlenen Gen0  collection sayısı:{GC.CollectionCount(0)}");



        //Gen2: Uzun ömürlü nesneler
        var longLiveObjects = new Dictionary<int, string>();
        for (int i = 0; i < 1000; i++)
        {
            longLiveObjects[i] = $"Long live value {i}";
        }

        GC.Collect(1);
        Console.WriteLine($" Temizlenen toplam: {GC.CollectionCount(1)}");

        Console.WriteLine($"Gen2 collection:{GC.CollectionCount(2)}");








    }
}