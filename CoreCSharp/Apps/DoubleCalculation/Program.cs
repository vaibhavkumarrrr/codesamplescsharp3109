using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security.Claims;

namespace csharp.training.congruent.apps
{
    public class Program
    {
        public static double Floor(double value, double step)
        {
            return Math.Floor(value / step) * step;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

    }
}
