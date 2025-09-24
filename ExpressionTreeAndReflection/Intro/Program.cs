// See https://aka.ms/new-console-template for more information
using System.Linq.Expressions;

Console.WriteLine("Hello, World!");

Func<int, bool> normalLambda = x => x > 5;

bool isBigThanFive = normalLambda(8);

//Expression Treee ile:
Expression<Func<int, bool>> expressionTree = x => x > 5;
Console.WriteLine($"Parametre: {string.Join(",",expressionTree.Parameters)}");
Console.WriteLine($"Dönüş değeri:{expressionTree.ReturnType}");
Console.WriteLine($"Tanımlı lambda fonksiyonu:{expressionTree.Body}");
BinaryExpression binaryExp = (BinaryExpression)expressionTree.Body;
Console.WriteLine($"Tanımlı lambda fonksiyonu (SOL):{binaryExp.Left}");
Console.WriteLine($"Tanımlı lambda fonksiyonu (SAĞ):{binaryExp.Right}");


Console.WriteLine($"Node tipi:{expressionTree.NodeType}");
Console.WriteLine($"Body Node tipi:{expressionTree.Body.NodeType}");

var compiledTree = expressionTree.Compile();
bool output = compiledTree(8);
Console.WriteLine($"derlenmiş exp. tree sonucu: {output}");
