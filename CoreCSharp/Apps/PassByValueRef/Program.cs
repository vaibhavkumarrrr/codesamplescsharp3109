using csharp.training.congruent.classes; 
namespace csharp.training.congruent.apps
{
    public class A
    {
        private int i1;

        public int Geti()
        {
            return i1;
        }

        public void Seti(int value)
        {
            i1 = value;
        }

        public static void ChangeAValue(A a)
        {
            a.Seti(20);
        }
        public static void ChangeARef(ref A a)
        {
            a.Seti(20);
        }
    }

    internal class Program
    {
         static string ChangeString(ref string s)
        {
            s = "Changed";
            return s;
        }   

        static   string ChangeStringAlt(string _)
        {
            string t = new("Hello Changes"); 
            Console.WriteLine($"Inside changeStringAlt: {t}");
            return t; 
        }

        static void Main(string[] _)
        {

            Point2DStruct p = new(1, 2);
            Console.WriteLine($"Structure Before change by Value: {p}");
            Point2DStruct.ModifyPointValue(p);
            Console.WriteLine($"Structure After change by Value: {p}");
            Console.WriteLine($"Structure Before change by Ref: {p}");
            Point2DStruct.ModifyPointRef(ref p);
            Console.WriteLine($"Structure After change by Ref: {p}");
            Console.WriteLine("********************************");


            Point2D p2 = new(1, 2);
            Console.WriteLine($"Class Before change by Value: {p2}");
            Point2D.ModifyPointValue(p2);
            Console.WriteLine($"Class After change by Value: {p2}");
            Console.WriteLine($"Class Before change by Ref: {p2}");
            Point2D.ModifyPointRef(ref p2);
            Console.WriteLine($"Class After change by Ref: {p2}");
            Console.WriteLine("********************************");


            // as long as you pass a reference type, you can modify its properties
            A objA = new();
            objA.Seti(10);
            A.ChangeAValue(objA);
            Console.WriteLine(objA.Geti());
            A.ChangeARef(ref objA);
            Console.WriteLine(objA.Geti());
            Console.WriteLine("********************************");

            // Strings are immutable though
            // this applies also to structs which are value types
            // passing them as ref resolves this issue  
            string str = "Original";
            Console.WriteLine($"Original String : {str}");
            Console.WriteLine($"During change String : {ChangeString(ref str)}");
            Console.WriteLine($"Afer change String : {str}");
            // reference has been changed 
            //but original string is not changed

            str = ChangeStringAlt(str);
            Console.WriteLine($"Afer change Alt String : {str}");
            Console.WriteLine("********************************");

        }
    }
}
