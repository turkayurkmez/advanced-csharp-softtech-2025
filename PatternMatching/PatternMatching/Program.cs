
Console.WriteLine("selam");



var person = new Person("Ali", 25, "Eskişehir", "Yazılımcı");
var people = new List<Person>()
{
    person,
    new Person ( Name:"Aysun", City:"Ankara", Age:43, Job:"Öğretmen"),
    new Person ( Name:"Cengiz", City:"Yozgat", Age:16, Job:"Öğrenci"),
    new Person ( Name:"Burcu", City:"Çanakkale", Age:25, Job:"Mühendis"),
    new Person ( Name:"Necibe", City:"Edirne", Age:65, Job:"Diplomat"),

};


if (person != null)
{
    if (person.Age > 18)
    {
        if (person.Name == "Ali")
        {
            if (person.City == "Eskişehir")
            {
                Console.WriteLine("Bulduk!!!");
            }
        }

    }
}

//var company = "Softtech";
//if (company is string)
//{

//}
if (person is { Age: > 18, Name: "Ali", City: "Eskişehir" })
{
    Console.WriteLine("Tek satırda buldum");
}


foreach (var item in people)
{
    Console.WriteLine(analyzePerson(item));
}


Console.WriteLine(getMovementDirection(5, 3));
Console.WriteLine(getMovementDirection(0, 0));
Console.WriteLine(getMovementDirection(-5, 3));
Console.WriteLine(getMovementDirection(-5, -3));

Console.WriteLine(getDiscount(750));


string analyzePerson(Person person)
{
    return person switch
    {
        { Age: < 18 } => "Çocuk",
        { Age: >= 65 } => "Emekli",

        { Age: > 18, Job: "Öğretmen", City: "Ankara" } => "Başkentte Öğretmen",

        { Age: >= 18 and <= 35, Job: "Mühendis" } => "Genç mühendis",

        _ => "Analiz dışı kişi...."
    };


}



string getMovementDirection(int deltaX, int deltaY)
{
    return (deltaX, deltaY) switch
    {
        (0, 0) => "Durgun",
        ( < 0, 0) => "Batı",//x ekseni (-)
        ( > 0, 0) => "Doğu",
        (0, > 0) => "Kuzey",
        (0, < 0) => "Güney",
        ( > 0, > 0) => "Kuzeydoğu",
        ( < 0, > 0) => "Kuzeybatı",
        ( < 0, < 0) => "Güneybatı",
        ( > 0, < 0) => "Güneydoğu"
    };
}


decimal getDiscount(decimal total)
{
    return total switch
    {
        < 100 => 0,
        >= 100 and < 500 => total * .95m,
        >= 500 and < 1000 => total * .9m
    };


}
//Pattern Guards (when clauses)
string getWeatherCondition(Tempereature tempereature) => tempereature switch
{
    { Location: "Eskişehir", Celcius: < -10 } => "Eskişehir çok soğuk",
    { Celcius: var c } when c < -5 => $"{tempereature.Location} Buzlanma riski",
    { Celcius: var c } when c >= -5 && c < 5 => $"{tempereature.Location} Çok soğuk",
    { Celcius: var c } when c >= 5 && c < 15 => $"{tempereature.Location} Ilık",



};


public record Person(string Name, int Age, string City, string Job);
public record Tempereature(string Location, double Celcius);