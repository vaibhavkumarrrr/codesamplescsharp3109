using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExample1
{
    internal class ExampleOverLoad
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }

        public static double Sum(double a, int b)
        {
            Console.WriteLine("Double Int method called");
            return a + b;
        }
    }
}
