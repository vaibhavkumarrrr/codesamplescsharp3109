namespace csharp.training.congruent.apps
{
        public class A
        {
            public string X { get; set; } = "A";
        }

        public class B : A
        {
            public new string X { get; set; } = "B";
        }
        internal class Program
        {
            static void Main(string[] _)
            {
                A obj = new B();
                string tmp = obj is B b ? b.X : obj.X;
                Console.WriteLine($"Value of X: {tmp}");
                obj = new A();
                tmp = obj is B c ? c.X : obj.X;
                Console.WriteLine($"Value of X: {tmp}");
        }
        }
    }
