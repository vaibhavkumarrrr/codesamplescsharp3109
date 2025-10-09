using csharp.training.congruent.classes; 
namespace csharp.training.congruent.apps
{
    public class A
    {
        public int i { get; set; }
        public static void changeAValue(A a)
        {
            a.i = 20;
        }
        public static void changeARef(ref A a)
        {
            a.i = 20;
        }
    }

    internal class Program
    {
         static string changeString(ref string s)
        {
            s = "Changed";
            return s;
        }   

        static void Main(string[] args)
        {

            Point2DStruct p = new Point2DStruct(1, 2);
            Console.WriteLine($"Structure Before change by Value: {p}");
            Point2DStruct.ModifyPointValue(p);
            Console.WriteLine($"Structure After change by Value: {p}");
            Console.WriteLine($"Structure Before change by Ref: {p}");
            Point2DStruct.ModifyPointRef(ref p);
            Console.WriteLine($"Structure After change by Ref: {p}");
            Console.WriteLine("********************************");


            Point2D p2 = new Point2D(1, 2);
            Console.WriteLine($"Class Before change by Value: {p2}");
            Point2D.ModifyPointValue(p2);
            Console.WriteLine($"Class After change by Value: {p2}");
            Console.WriteLine($"Class Before change by Ref: {p2}");
            Point2D.ModifyPointRef(ref p2);
            Console.WriteLine($"Class After change by Ref: {p2}");
            Console.WriteLine("********************************");


            // as long as you pass a reference type, you can modify its properties
            A objA = new A();
            objA.i = 10;
            A.changeAValue(objA);
            Console.WriteLine(objA.i);
            A.changeARef(ref objA);
            Console.WriteLine(objA.i);
            Console.WriteLine("********************************");

            // Strings are immutable though
            // this applies also to structs which are value types
            // passing them as ref resolves this issue  
            string str = "Original";
            Console.WriteLine($"Original String : {str}");
            Console.WriteLine($"During change String : {changeString(ref str)}");
            Console.WriteLine($"Afer change String : {str}");
            Console.WriteLine("********************************");

        }
    }
}
