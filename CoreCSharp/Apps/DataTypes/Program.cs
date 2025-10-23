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
            int[] intArr = { 1, 2 };
            Console.WriteLine(getClassification(25));
             int[]  intArr = [1, 2];
             Console.WriteLine(GetClassification(25));
            if (intArr[0] > 0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Non Positive");
            }

            string s = "Sriram";
            Console.WriteLine(s);
            s = changeValue(s);
            s = ChangeValue(s); 
            Console.WriteLine(s);
            Console.WriteLine(s);
            A objA = new A();
            objA.i = 10;
            changeA(ref objA);
            Console.WriteLine(objA.i);

            // min max value of primitive datatypes
            // Signed integral types
            Console.WriteLine("sbyte Min: " + sbyte.MinValue);
            Console.WriteLine("sbyte Max: " + sbyte.MaxValue);

            Console.WriteLine("short Min: " + short.MinValue);
            Console.WriteLine("short Max: " + short.MaxValue);

            Console.WriteLine("int Min: " + int.MinValue);
            Console.WriteLine("int Max: " + int.MaxValue);

            Console.WriteLine("long Min: " + long.MinValue);
            Console.WriteLine("long Max: " + long.MaxValue);

            Console.WriteLine("Int128 Min: " + Int128.MinValue);
            Console.WriteLine("Int128 Max: " + Int128.MaxValue);

            // Unsigned integral types
            Console.WriteLine("byte Min: " + byte.MinValue);
            Console.WriteLine("byte Max: " + byte.MaxValue);

            Console.WriteLine("ushort Min: " + ushort.MinValue);
            Console.WriteLine("ushort Max: " + ushort.MaxValue);

            Console.WriteLine("uint Min: " + uint.MinValue);
            Console.WriteLine("uint Max: " + uint.MaxValue);

            Console.WriteLine("ulong Min: " + ulong.MinValue);
            Console.WriteLine("ulong Max: " + ulong.MaxValue);

            Console.WriteLine("UInt128 Min: " + UInt128.MinValue);
            Console.WriteLine("UInt128 Max: " + UInt128.MaxValue);

            // Floating point types
            Console.WriteLine("float Min: " + float.MinValue);
            Console.WriteLine("float Max: " + float.MaxValue);

            Console.WriteLine("double Min: " + double.MinValue);
            Console.WriteLine("double Max: " + double.MaxValue);

            // Decimal type
            Console.WriteLine("decimal Min: " + decimal.MinValue);
            Console.WriteLine("decimal Max: " + decimal.MaxValue);

            // Char type
            Console.WriteLine("char Min: " + (int)char.MinValue);
            Console.WriteLine("char Max: " + (int)char.MaxValue);

            // Boolean type
            Console.WriteLine("bool False: " + bool.FalseString);
            Console.WriteLine("bool True: " + bool.TrueString);

            // 
            ushort dayname = (ushort)Days.Monday;
            if (dayname <= 32)
            {
                Console.WriteLine("meeting on weekday");
            }
            else
            {
                Console.WriteLine("meeting on weekend");
            }
            //
            festivalCalendar fc = new festivalCalendar();
            fc.festivalnameChecker("JAN");
            // exception trying
            int a0 = 0;
            int a5 = 10;

            try
            {
                while (true)
                {
                    int a10 = a5 / a0;
                    Console.WriteLine("division done");
                    continue;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            //
            while (true)
            {
                try
                {
                    Console.WriteLine("enter a number");
                    int number1 = Convert.ToInt16(Console.ReadLine());
                    for (int number = 900000000; number > 0; number++)
                    {
                        number1 = number1 + (number * number);
                    }
                    Console.WriteLine(number1);
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.ToString());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("exception" + ex);
                    break;
                }
            }
            //           
            try
            {
                string path = @"c:\abc.txt";
                File.WriteAllText(path, "hello dosto, exception sikhte hain");
                Console.WriteLine("file created");
            }
            catch (FileLoadException ex)
            {
                Console.WriteLine("unable to load the file, check for the permission" + ex);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("file not found exception" + ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("unauthorixed acess" + ex);

            }
            catch (DriveNotFoundException ex)
            {
                Console.WriteLine("unable to find the drive " + ex);

            }
            catch (Exception ex)
            {
                Console.WriteLine("some exception" + ex);
            }
            A objA = new()
            {
                I = 10
            };
            ChangeA(ref objA); 
            Console.WriteLine(objA.I);
        }
    }
}