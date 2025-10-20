using System.ComponentModel;

namespace csharp.training.congruent.apps
{
    public sealed class FullLazySingleton
    {
        private int _counter = 0;
        public void WriteObject()
        {
            Console.WriteLine($"In WriteObject() {_counter++}");
        }

        private FullLazySingleton()
        {
            Console.WriteLine("Creating a new FullLazySingleton");
        }

        public static FullLazySingleton Instance
        {
            get
            {
                return Nested.instance;
            }
        }

        // internal class
        private class Nested
        {
            // explicit C# static constructor
            // Do not mark type as beforefieldinit 
            static Nested() { }
            internal static readonly FullLazySingleton instance = new(); 
        }

    }
}
