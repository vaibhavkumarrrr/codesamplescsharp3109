// See https://aka.ms/new-console-template for more information
using VBClassLibrary;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(VBClass.Add(2, 4)); // Call the Add function from the VBClassLibrary
        Console.WriteLine(VBClass.Add(3, 7)); // Call the Add function from the VBClassLibrary
    }
}