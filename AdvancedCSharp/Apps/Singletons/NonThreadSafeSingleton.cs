namespace csharp.training.congruent.apps
{
    public sealed class NonThreadSafeSingleton
    {
        private int _counter = 0;  
        public void WriteObject()
        {
            Console.WriteLine($"In WriteObject() {_counter++}"); 
        }
        private NonThreadSafeSingleton() {
            Console.WriteLine("Creating a new NonThreadSafeSingleton");
        }
        private static NonThreadSafeSingleton? instance = null;
        public static NonThreadSafeSingleton Instance
        {
            get
            {
                instance ??= new NonThreadSafeSingleton();
                return instance;
            }
        }
    }
}
