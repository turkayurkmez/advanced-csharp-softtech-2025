// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
string email = "turkay.urkmez@dinamikzihin.com";



//bellek maaliyeti yüksek ve GC açısından dezavantaj:
string userName = email.Substring(0, email.IndexOf('@'));
string domain = email.Substring(email.IndexOf('@')+1);
Console.WriteLine($"Kullanıcı adı: {userName} ve domain: {domain}");




ReadOnlySpan<char> emailspan = email.AsSpan();
int atIndex = emailspan.IndexOf("@");
ReadOnlySpan<char> userNameSpan = emailspan.Slice(0,atIndex);
Console.WriteLine(userNameSpan.ToString());




string[] generateMillionEmails()
{
    string[] emails = new string[1000000];

    for (int i = 0; i<emails.Length;i++)
    {
        emails[i] = $"sample_{i}@domain{i}.com";
    }

    return emails;
}

string[] emails = generateMillionEmails();
var stopWatch = Stopwatch.StartNew();
for (int i = 0; i < emails.Length; i++)
{
    string subUserName = emails[i].Substring(0, emails[i].IndexOf('@'));

}

stopWatch.Stop();
Console.WriteLine($"Substring ile geçen süre: {stopWatch.ElapsedMilliseconds} ms");

stopWatch.Restart();
for (int i = 0; i < emails.Length; i++)
{
    ReadOnlySpan<char> emailWithSpan = emails[i].AsSpan();
    ReadOnlySpan<char> spanUserName = emailWithSpan.Slice(0, emailWithSpan.IndexOf('@'));

}

stopWatch.Stop();
Console.WriteLine($"Span<> ile geçen süre: {stopWatch.ElapsedMilliseconds} ms");


//Memory -> Span struct'unun asenkron kardeşi. Eğer bir task içinde bu işlemi yapıyorsanız; span yerine kullanılır.
var emailMemory = email.AsMemory();
