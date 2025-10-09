using csharp.training.congruent.enums;
namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.WriteLine("Meeting is on " + meetingDay);
            Console.WriteLine("Note: Weekends are on " + Days.Saturday + " and on " + Days.Sunday);
            Console.WriteLine(nonNull.GetType());
            Days x = (Days)0;
                       Console.WriteLine(x);
            x = Days.Monday;
            Console.WriteLine(x);

            int test = 0;
            object obj = test;
            obj = 34; 
            Console.WriteLine(obj);
            test = (int)obj; 
            Console.WriteLine(test);

        }
    }
}
