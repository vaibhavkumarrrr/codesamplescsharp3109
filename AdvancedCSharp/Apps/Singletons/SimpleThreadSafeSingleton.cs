using System;

namespace csharp.training.congruent.apps
{
    public sealed class SimpleThreadSafeSingleton
    {
        private static SimpleThreadSafeSingleton? instance = null;
        public static readonly object padlock = new();
        private int _counter = 0;
        public void WriteObject()
        {
            Console.WriteLine($"In WriteObject() {_counter++}");
        }

        SimpleThreadSafeSingleton()
        {
            Console.WriteLine("Creating a new SimpleThreadSafeSingleton");
        }
        public static SimpleThreadSafeSingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    instance ??= new SimpleThreadSafeSingleton();
                    return instance;
                }
            }
        }
    }
}
