//https://csharpindepth.com/articles/Singleton#unsafe 
namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] _)
        {
            // Create a non thread Safe Singleton - Method #1 
            NonThreadSafeSingleton n = NonThreadSafeSingleton.Instance;
            n.WriteObject(); n.WriteObject();
            NonThreadSafeSingleton n1 = NonThreadSafeSingleton.Instance;
            n1.WriteObject();
            
            // Create a simple thread Safe Singleton - Method #2 
            SimpleThreadSafeSingleton n2 = SimpleThreadSafeSingleton.Instance;
            n2.WriteObject(); n2.WriteObject();
            SimpleThreadSafeSingleton n3 = SimpleThreadSafeSingleton.Instance;
            n3.WriteObject();

            // Create a thread Safe Singleton with double check - Method #3 
            DoubleCheckThreadSafeSingleton n4 = DoubleCheckThreadSafeSingleton.Instance;
            n4.WriteObject(); n4.WriteObject();
            DoubleCheckThreadSafeSingleton n5 = DoubleCheckThreadSafeSingleton.Instance;
            n5.WriteObject();

            // Create a thread Safe Singleton with no locks  - Method #4 
            ThreadSafeNonLockSingleton n6 = ThreadSafeNonLockSingleton.Instance;
            n6.WriteObject(); n6.WriteObject();
            ThreadSafeNonLockSingleton n7 = ThreadSafeNonLockSingleton.Instance;
            n7.WriteObject();


            // Full Lazy Initialization  - Method #5 
            FullLazySingleton n8 = FullLazySingleton.Instance;
            n8.WriteObject(); n8.WriteObject();
            FullLazySingleton n9 = FullLazySingleton.Instance;
            n9.WriteObject();

            // Full Lazy Initialization with Lazy<T>  - Method #6 
            LazyTLambdaSingleton n10 = LazyTLambdaSingleton.Instance;
            n10.WriteObject(); n10.WriteObject();
            LazyTLambdaSingleton n11 = LazyTLambdaSingleton.Instance;
            n9.WriteObject();

            //Console.WriteLine("Hello, World!");
        }
    }
}
