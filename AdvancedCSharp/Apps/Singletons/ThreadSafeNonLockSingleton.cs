
namespace csharp.training.congruent.apps
{
    public sealed class ThreadSafeNonLockSingleton
    {
        private static readonly ThreadSafeNonLockSingleton instance = new();
        // Oh well a new wrinkle -- static constructurs..
        private int _counter = 0;
        public void WriteObject()
        {
            Console.WriteLine($"In WriteObject() {_counter++}");
        }
        static ThreadSafeNonLockSingleton()
        {
            Console.WriteLine("No Objects - A static constructor is being called");
        }
        public static ThreadSafeNonLockSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
