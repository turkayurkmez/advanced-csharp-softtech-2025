// See https://aka.ms/new-console-template for more information
using Collections;

Console.WriteLine("Hello, World!");
/*
 * Kararı nasıl vereceksiniz?
 * List<T>
 * IList<T> --> Index ile çalışacaksanız (Insert, RemoveAt -> Koleksiyona müdahale var)
 * ICollection<T> T nesnesi ile manipülasyon (Add, Clear, Remove)
 * IEnumerable<T> -> Sadece foreach...
 */

//FIFO - LIFO
Queue<string> emails = new Queue<string>();
emails.Enqueue("mail@bilmemne.com");
emails.Enqueue("mail2@bilmemne.com");
emails.Enqueue("mail3@bilmemne.com");
emails.Enqueue("mail4@bilmemne.com");

while (emails.Count > 0)
{
    string sendingMailAddress = emails.Dequeue();
    Console.WriteLine($"{sendingMailAddress} adresine mail gönderildi...");
}

Stack<string> stack = new Stack<string>();
stack.Push("A");
stack.Push("B");
stack.Push("C");

while (stack.Count > 0)
{
    string value = stack.Pop();
    Console.WriteLine(value);
    Console.WriteLine($"Koleksiyonda kalan: {stack.Count} ");
}



//List<string> emailList = new List<string>()
//{
//   "mail@bilmemne.com",
//   "mail2@bilmemne.com",
//   "mail3@bilmemne.com",
//   "mail4@bilmemne.com"

//};

//foreach (var item in emailList)
//{
//    Console.WriteLine($"Liste içinden {item} adresine mail atıldı");
//    //emailList.Add("yapamazsın!");
//}


ClassRoom classRoom = new ClassRoom();
classRoom.AddStudent(new Student() { Name="Zeynep", Id=1, Score=70});
classRoom.AddStudent(new Student() { Name = "Tuncay", Id = 2, Score = 90 });

foreach (var student in classRoom)
{
    Console.WriteLine($"{student.Name}\t{student.Score}");
}