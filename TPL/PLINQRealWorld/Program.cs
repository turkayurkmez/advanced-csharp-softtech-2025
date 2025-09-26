// See https://aka.ms/new-console-template for more information
using PLINQRealWorld;

Console.WriteLine("Hello, World!");

var numbers = Enumerable.Range(1, 1000).ToArray();

//var sequential = numbers.Where(n => n % 3 == 0)
//                        .Select(n => n * n)
//                        .Sum();

var parallel = numbers.AsParallel()
                       .Where(n => n % 3 == 0)
                        .Select(n => n * n)
                        .Sum();

Console.WriteLine(parallel);

RecordProcessor recordProcessor = new RecordProcessor();
await recordProcessor.ProcessLargeDataAsync();  
