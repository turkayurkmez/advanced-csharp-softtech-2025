// See https://aka.ms/new-console-template for more information
using DelegateAndLambda;

Console.WriteLine("Hello, World!");

bool isEven(int number)
{
    return number % 2 == 0;
}

void showNumbers(int[] numbers)
{

    Console.WriteLine(string.Join(", ", numbers));
}



int[] numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

//.net 1.0:
var evenNumbers = Helper.Filter(numbers, isEven);
showNumbers(evenNumbers);

//.net 2.0:
var oddNumbers = Helper.Filter(numbers, delegate (int x) { return x % 2 == 1; });
showNumbers(oddNumbers);

//.net 3.5:
var bigThanFive = Helper.Filter(numbers, s => s > 5);
showNumbers(bigThanFive);

var smallThanEight = numbers.Where(n => n < 8);

showNumbers(smallThanEight.ToArray());


//LINQ: Language INtegrated Query
//SELECT num FROM numbers WHERE num < 8
var smallThenEight_withLINQ = from num in numbers
                              where num < 8
                              select num;




