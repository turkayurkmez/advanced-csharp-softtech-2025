// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(analyseIntArrayModern(new int[] { 10, 3, 3, 4, 5, 6, 7, 8, 90 }));


string analyseIntArray(int[] numbers)
{
	if (numbers == null || numbers.Length ==0)
	{
		return "Boş dizi";
	}

	if (numbers.Length ==1 && numbers[0] == 8)
	{
		return "Tek eleman var o da 8";
	}

    if (numbers.Length >= 2 && numbers[0] == 1 && numbers[1]==2)
    {
        return "Array 1,2 ile başlıyor";
    }
	return "";

}

string analyseIntArrayModern(int[] numbers)
{
	return numbers switch
	{
		[] => "Boş dizi",
		[8] => "Tek eleman: 8",
		[1, 2, ..] => "1,2 ile başlıyor",
		[.., 999] => "999 ile bitiyor",
		[1, .., 9] => "1 ile başlayıp 9 ile bitiyor",
		[var first, .., var last] => $"ilk eleman {first} son eleman {last}"

		//[1, ..var middle, 9] => $"1 ile başlar 9 ile biter. Aradaki {middle.Length} elemanın değerleri: {string.Join(",", middle)}"
	};
}