using System.Runtime.InteropServices;
using csharp.training.congruent.classes;        
namespace csharp.training.congruent.apps 
{
    internal class Program
    {
        
        static void Main(string[] _)
        {
            // Person p = new ();
            //p.FirstName = "Rajesh"; p.LastName = "Singh";
            Person p = new()
            {
                FirstName = "Rajesh",
                LastName = "Singh"
            };
            p.Introduce(); 
        }
    }
}
