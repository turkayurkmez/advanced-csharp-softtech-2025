// See https://aka.ms/new-console-template for more information
using Tuples;

Console.WriteLine("Hello, World!");

//ya kalanı da almak isterseniz?


int divide(int a, int b, out int modulo)
{
    modulo = a % b;
    return a / b;
}

DivResult divideWithObject(int a, int b)
{
    return new DivResult { Division = a / b, Modulo = a % b };

}

Tuple<int,int> divideWithTuple(int a, int b)
{
    var tuple = Tuple.Create(a / b, a % b);
    return tuple;
}

(int, int, bool) divideWithDecoTuple(int a, int b)
{    
    return (a/b, a%b, a%b==0);
}

int moduloValue=0;
var division = divide(10, 3, out moduloValue);
Console.WriteLine($"İşlem sonucu: {division}, kalan: {moduloValue}");

var div2 = divideWithObject(10, 3);
Console.WriteLine($"İşlem sonucu: {div2.Division}, kalan: {div2.Modulo}");



var div3 = divideWithTuple(10, 3);
Console.WriteLine($"İşlem sonucu: {div3.Item1}, kalan: {div3.Item2}");

(int divReult, int modResult, bool isFullDiv) = divideWithDecoTuple(10, 3);
Console.WriteLine($"İşlem sonucu: {divReult}, kalan: {modResult}, kalansız mı {isFullDiv}");



