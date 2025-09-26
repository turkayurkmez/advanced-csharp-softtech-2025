// See https://aka.ms/new-console-template for more information
using TPLOverview;

Console.WriteLine("Hello, World!");
var images = new string[] { "a.jpg","b.png","c.gif","x.jpg","q.png","w.svg" };

ImageProcessor imageProcessor = new ImageProcessor();

imageProcessor.ProcessImageParallel(images);
imageProcessor.ProcessImageSequental(images);

OptimizedImageProcessor optimizedImageProcessor = new OptimizedImageProcessor();
optimizedImageProcessor.ProcessImageParallel(images, new CancellationToken());