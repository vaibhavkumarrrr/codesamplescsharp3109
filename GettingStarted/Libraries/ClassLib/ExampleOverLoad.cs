namespace csharp.training.congruent.classes
{
    public  class ExampleOverLoad
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
