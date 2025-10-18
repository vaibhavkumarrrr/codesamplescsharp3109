using csharp.training.congruent.classes;

// Book and Book Printer are now 
// totally Decoupled. 

Book a = new("Grapes of Wrath", "John Steinbeck", "A great Book", "9780143039433");
BookPrinter.PrintBook(a);

Console.WriteLine(a.IsBookWrittenBy("Sriram"));
Console.WriteLine(a.IsBookWrittenBy("John Steinbeck"));
a.DescribeBook();