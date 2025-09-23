// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//heap: 1M sayı heap'de
int[] numbers = new int[1000];
//stack allocation: 1M sayı stack'de
Span<int> stackNumbers = stackalloc int[1000];
for (int i = 0; i < stackNumbers.Length; i++)
{
    stackNumbers[i] = i * 2;
}

Console.WriteLine($"İlk eleman: {stackNumbers[0]}");
Console.WriteLine($"Sondan ikinci eleman: {stackNumbers[^2]}");
Console.WriteLine($"100.'den 120. elemana kadar: {string.Join(", ", stackNumbers[100..120].ToArray())}");
Console.WriteLine($"Slicing sondan 120 ile sondan 100: {string.Join(", ", stackNumbers[^120..^100].ToArray())}");
