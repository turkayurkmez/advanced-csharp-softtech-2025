// See https://aka.ms/new-console-template for more information
using RecordTypes;

Console.WriteLine("Hello, World!");

User user = new User() { Id =1, Name ="Türkay"};
User user1 = new User() { Id = 1, Name = "Türkay" };

Console.WriteLine($"Eşit mi? {user == user1}");

user1.Name = "Ümmühan";

Console.WriteLine($"user1 instance'ının adı: {user1.Name} olarak değişti");
Console.WriteLine($"Eşit mi? {user == user1}");


Money money = new Money(100, "TL");
Money tl = new Money(100, "TL");
Money anotherMoney = new Money(1500, "Dollar");

if (money == tl)
{
    Console.WriteLine("İki nesne de aynı değerde");
}
else
{
    Console.WriteLine("Farklı nesneler");
}

