// See https://aka.ms/new-console-template for more information
using ReflectionIntro;
using System.Reflection;

Console.WriteLine("Hello, World!");

Personel personel = new Personel { Age = 35, Name = "Hülya" };

Type personType = personel.GetType();

Console.WriteLine("--- Properties ---");
foreach (var property in personType.GetProperties())
{
    Console.WriteLine($"{property.Name}: {property.GetValue(personel)} ({property.PropertyType.Name})");

}

Console.WriteLine("--- Methods ---");
foreach (var method in personType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
{
    if (method.DeclaringType == personType)
    {
        Console.WriteLine($"{method.Name} - {(method.IsPublic ? "public": "private")}");

    }
}

MethodInfo methodInfo = personType.GetMethod("secretMethod", BindingFlags.NonPublic | BindingFlags.Instance);
methodInfo?.Invoke(personel, null);
