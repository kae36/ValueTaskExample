// See https://aka.ms/new-console-template for more information

// How to use ValueTask in C#
// https://www.infoworld.com/article/3565433/how-to-use-valuetask-in-csharp.html


using ConsoleApp;

Console.WriteLine("This is a test");
//static void Main(string[] args)
//{
  IRepository<int> repository = new Repository<int>();
  var result = repository.GetData();
  if (result.IsCompleted)
    Console.WriteLine("Operation complete...");
  else
    Console.WriteLine("Operation incomplete...");
  Console.ReadKey();
//}
