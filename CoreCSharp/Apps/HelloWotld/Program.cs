using System.Runtime.InteropServices;
using System.Text;

namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello , World!";
            //string b = "Hello ";
            //b += ", World!"; 
            string b = "Hello , World!";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a==b);
            Console.WriteLine(a.Equals(b)); 
            Console.WriteLine(object.ReferenceEquals(a,b));
            b = "Hello Rakesh";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));
           Console.WriteLine(object.ReferenceEquals(a, b));
            StringBuilder bldr = new StringBuilder("Hello, "); 
            bldr.Append("World!");
            Console.WriteLine(bldr.ToString());
            bldr.Replace("World","Rakesh");
            Console.WriteLine(bldr.ToString());
            Console.WriteLine(bldr.GetType());

            Console.WriteLine("""
                \\This is a test 
                and on another ""line 
                Yet another line.
                """);
            string s = $"Print new this line {Environment.NewLine} and this on second line"; 
            Console.WriteLine("Print this line {0} and this on second line",Environment.NewLine); 
            Console.WriteLine("\\\\Line1\"\"" + Environment.NewLine + "line2");
            Console.WriteLine(s);
            Console.WriteLine(s);
        }
    }
} 
