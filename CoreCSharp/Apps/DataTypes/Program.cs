using csharp.training.congruent.classes;
using csharp.training.congruent.enums;
namespace csharp.training.congruent.apps
{
    public class A
    {
        public int I { get; set;  }
     }
    internal class Program
    {
        public static void ChangeA(ref A a)
        {
            a.I = 20;
        }

         
        static string ChangeValue(string s)
        {
            return "Hello " + s;
        }
        static string GetClassification(int temperature) => temperature switch
        {
            < 0 => throw new ArgumentOutOfRangeException(nameof(temperature), "Cannot be negative"),
            < 20 => "Too Cold",
            < 40 => "OK",
            >= 41 and <= 60 => "Too Hot",
            _ => "Unknown"
        };

        static void Main(string[] _)
        {
            Console.WriteLine(unchecked((uint)-1));
            int a = unchecked(1 + int.MaxValue);
            Console.WriteLine(a);
            char b = 'ஒ'; // write 
            Console.WriteLine(b);
            //int c = 34;
            //string s = "Sriram";
            double d = 3.14159;
            double e = 2.71828;
            double f = d + e;
            if (f == 5.85987)
            {
                Console.WriteLine("Sum of d and e is 5.85987");
            }
            // decimal g = 2.71828;
            //int x = 3 % 4;
            Console.WriteLine(3 * 5 / 2.0);
            uint h = 0xff_ff_ff_ff;
            Console.WriteLine(h);
            Console.WriteLine(uint.MaxValue);
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("{0}{1}", '\uD83D', '\uDE48');
            int? z = null;
            Console.WriteLine(z.HasValue);
            int nonNull = z.GetValueOrDefault();
            Console.WriteLine(nonNull);
            Console.WriteLine(Season.Winter);
            Days meetingDay = Days.Saturday;
            int x = (int)Days.Saturday & (int)Days.Weekday;
            Console.WriteLine("Weekday : " + x);
            x = (int)Days.Saturday & (int)Days.Weekend;
            Console.WriteLine("Weekend : " + x);
            Console.WriteLine("Meeting is on " + meetingDay);
            Console.WriteLine("Note: Weekends are on " + Days.Saturday + " and on " + Days.Sunday);
            Console.WriteLine(nonNull.GetType());
            Days x1 = (Days)0;
            Console.WriteLine(x1);
            x1 = Days.Monday;
            Console.WriteLine(x1);

            int test = 0;
            //obj = 34;
            Console.WriteLine((object)test);
            test = (int)(object)test;
            Console.WriteLine(test);
            const double Pi = 3.1416;
            Console.WriteLine(Pi);
            //Pi = 3.45; 
             int[]  intArr = [1, 2];
             Console.WriteLine(GetClassification(25));
            if (intArr[0] > 0)
            {
                Console.WriteLine("Positive");
            } else
            {
                Console.WriteLine("Non Positive"); 
            }

            string s = "Sriram";
            Console.WriteLine(s);
            s = ChangeValue(s); 
            Console.WriteLine(s);
            Console.WriteLine(s);
            A objA = new()
            {
                I = 10
            };
            ChangeA(ref objA); 
            Console.WriteLine(objA.I);
        }
    }
}