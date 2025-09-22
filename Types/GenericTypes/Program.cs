// See https://aka.ms/new-console-template for more information
using GenericTypes;
using System.Collections;

Console.WriteLine("Hello, World!");

object number = 42;


int value = (int)number; 

ArrayList items = new ArrayList();
items.Add(true);
items.Add(75);
items.Add("Remzi");
items.Add(1.65M);

bool isApproved = (bool)items[3];


object PushValue(object value)
{
    //bir şeyler...
    return value;
}


PushValue(42);
PushValue("Naber");
PushValue(new Random());


DoublePoint point = new DoublePoint();
GenericPoint<decimal> decimalPoint = new GenericPoint<decimal>();
GenericPoint<float> floatPoint = new GenericPoint<float>();

GenericPoint<bool> stringPoint = new GenericPoint<bool>();
