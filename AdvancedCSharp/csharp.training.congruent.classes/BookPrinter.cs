namespace csharp.training.congruent.classes
{
    using System;
    using System.Net.Http.Headers;
    using System.Reflection.Metadata.Ecma335;
    using System.Runtime.CompilerServices;

    public class BookPrinter
    {
        public static void PrintBook(Book a)
        {
            Console.WriteLine("******** Book Info"); 
            Console.WriteLine(a.ToString());
        }
    }
}

