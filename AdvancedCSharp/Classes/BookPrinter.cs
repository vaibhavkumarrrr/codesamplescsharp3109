namespace csharp.training.congruent.classes
{
    public class BookPrinter
    {
        public static void PrintBook(Book a)
        {
            Console.WriteLine("******** Book Info"); 
            Console.WriteLine(a.ToString());
        }
    }
}

