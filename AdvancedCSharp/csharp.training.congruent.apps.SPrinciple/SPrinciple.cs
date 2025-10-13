using csharp.training.congruent.classes; 
namespace csharp.training.congruent.apps.SPrinciple
{
    internal class SPrinciple
    {   
        static  void Main(string[] _)
        {
            Book a = new("Grapes of Wrath", "John Steinbeck", "A great Book", "9780143039433");
            BookPrinter.PrintBook(a);
            Console.WriteLine(a.IsBookWrittenBy("John Steinbeck"));
            a.DescribeBook(); 
        }
    }
}
