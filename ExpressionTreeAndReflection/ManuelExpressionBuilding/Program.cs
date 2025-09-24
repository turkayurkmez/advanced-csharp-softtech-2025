// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");
// (x + y) * 2
//1. Adım: Parametreler
ParameterExpression x =  Expression.Parameter(typeof(int), "x");
ParameterExpression y = Expression.Parameter(typeof(int), "y");

//2. Adım: Sabit değer
ConstantExpression two = Expression.Constant(2);
//3. Adım: Toplama
BinaryExpression addition = Expression.Add(x, y);
//4. Adım: Çarpma
BinaryExpression multiply = Expression.Multiply(addition, two);

//5. Adım Lamda:
Expression<Func<int, int, int>> manualLambda = Expression.Lambda<Func<int, int, int>>(multiply, x, y);
Console.WriteLine($"Lambda temsili: {manualLambda}");
var compiled = manualLambda.Compile();
int result = compiled(5, 3);

Console.WriteLine($"sonuç: {result}");


