using System.Runtime.InteropServices;
using System.Text;
using CustomExtensionMethods;
namespace csharp.training.congruent.apps
{
    /* Sample code that shows hello world and string manipulations */

    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello , World!";
            //string b = "Hello ";
            //b += ", World!";
            //Comment below line and uncomment above 2 lines to see string interning in action
            string b = "Hello , World!";
            Console.WriteLine($"String a {a}");
            Console.WriteLine($"String b {b}");
            Console.WriteLine($"string == {a==b}");
            Console.WriteLine($"String equals: {a.Equals(b)}"); 
            Console.WriteLine($"Object Reference Equality: {object.ReferenceEquals(a,b)}");
            b = "Hello Rakesh";
            Console.WriteLine($"String a {a}");
            Console.WriteLine($"String b {b}");
            Console.WriteLine($"string == {a == b}");
            Console.WriteLine($"String equals: {a.Equals(b)}");
            Console.WriteLine($"Object Reference Equality: {object.ReferenceEquals(a, b)}");

            // Example of using string Builder
            StringBuilder bldr = new StringBuilder("Hello, "); 
            bldr.Append("World!");
            Console.WriteLine(bldr.ToString());
            bldr.Replace("World","Rakesh");
            //ToString is not required to print StringBuilder object
            //Tostring is called implicitly
            //ToString is required when you need string object
            //ToString is not overridden in StringBuilder class
            Console.WriteLine(bldr);
            Console.WriteLine(bldr.GetType());

            // Print using multi line 
            Console.WriteLine(""""

                This is a test 
                and on another line.  
                Yet another line.

                """");
            // Print using $
            string s = $"Print new this line {Environment.NewLine} and this on second line"; 
            Console.WriteLine(s);
            // Print using format
            Console.WriteLine("Print this line {0} and this on second line",Environment.NewLine);
            // Escape sequences & String Concatentation
            Console.WriteLine("\\\\Line1\"\"" + Environment.NewLine + "\n\n\\n is the NEWLINE and is not platform indepdendent - line2");
            String abc = "This is a a sample";
            Console.WriteLine($"Word Count of '{abc}' is {abc.WordCount()}");
        }
    }
} 
