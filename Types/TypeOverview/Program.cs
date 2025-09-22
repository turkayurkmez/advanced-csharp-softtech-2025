// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//byte x = 255;
//byte y = 2;

int z = getTotal(2147483647, 1);

Console.WriteLine(z);

int getTotal(int x, int y)
{
    int output = 0;
	try
	{
		checked
		{
			output = x + y;
		}
	}
	catch (OverflowException)
	{

        Console.WriteLine($"{x} ve {y} toplamı int tipine dönüştürülemedi!");
	}

    return output;


    
}
