using System.Runtime.InteropServices;
using csharp.training.congruent.classes;        
namespace csharp.training.congruent.apps 
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Rajesh"; p.LastName = "Singh"; 
            p.Introduce(); 
        }
    }
}
