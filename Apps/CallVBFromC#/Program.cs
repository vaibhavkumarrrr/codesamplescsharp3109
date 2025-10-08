using VBClassLib.csharp.training.congruent.libraries;

namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VBClass.Add(2, 4)); // Call the Add function from the VBClassLibrary
            Console.WriteLine(VBClass.Add(3, 7)); // Call the Add function from the VBClassLibrary
            Console.WriteLine(VBClass.Mul(3, 7)); // Call the Add function from the VBClassLibrary

        }
    }
}
