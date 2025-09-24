// See https://aka.ms/new-console-template for more information
using ExpressionTreeQueryBuilder;

Console.WriteLine("Hello, World!");

string sql1 = SqlBuilder.BuildWhere<Person>(p => p.Age > 30);
Console.WriteLine($"SQL Sorgusu: WHERE {sql1} ");
string sql2 = SqlBuilder.BuildWhere<Person>(p => p.Age > 30 && p.City=="Eskişehir");
Console.WriteLine($"SQL Sorgusu: WHERE {sql2} ");


int minimumYas = 18;
string sql3 = SqlBuilder.BuildWhere<Person>(p => p.Age > minimumYas || p.Name == "Berke");
Console.WriteLine($"SQL Sorgusu: WHERE {sql3} ");



