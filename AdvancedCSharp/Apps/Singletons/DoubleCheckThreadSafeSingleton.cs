using System;

namespace csharp.training.congruent.apps
{
    public sealed class DoubleCheckThreadSafeSingleton
    {
        private static DoubleCheckThreadSafeSingleton ? instance = null;
        public static readonly object padlock = new();
        private int _counter = 0;
        public void WriteObject()
        {
            Console.WriteLine($"In WriteObject() {_counter++}");
        }

        DoubleCheckThreadSafeSingleton()
        {
            Console.WriteLine("Creating a new DoubleCheckThreadSafeSingleton");
        }
        
        public static DoubleCheckThreadSafeSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        instance ??= new DoubleCheckThreadSafeSingleton();
                    }

                }
                return instance;
            }
        }
    }
}
