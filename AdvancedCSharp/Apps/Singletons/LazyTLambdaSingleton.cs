namespace csharp.training.congruent.apps
{
    public class LazyTLambdaSingleton
    {
        private int _counter = 0;
        public void WriteObject()
        {
            Console.WriteLine($"In WriteObject() {_counter++}");
        }
        private LazyTLambdaSingleton()
        {
            Console.WriteLine("Creating a new LazyTLambdaSingleton");
        }

        //private static readonly Lazy<LazyTLambdaSingleton> lazy =
        //new Lazy<LazyTLambdaSingleton>(() => new LazyTLambdaSingleton());
        private static readonly Lazy<LazyTLambdaSingleton> lazy =
        new(() => new LazyTLambdaSingleton());

        public static LazyTLambdaSingleton Instance { get { return lazy.Value; } }
    }
}
