// EN: Adapter Design Pattern
//
// Intent: Provides a unified interface that allows objects with incompatible
// interfaces to collaborate.
//
using System;

namespace csharp.training.congruent.apps.patterns
{
    // EN: The Target defines the domain-specific interface used by the client
    // code.
    //
    public interface ITarget
    {
        string GetRequest();
    }

    // EN: The Adaptee contains some useful behavior, but its interface is
    // incompatible with the existing client code. The Adaptee needs some
    // adaptation before the client code can use it.
    //
    class Adaptee
    {
        private string _name; 
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string GetSpecificRequest()
        {
            return $"Specific request made for: {Name}";
        }
    }

    // EN: The Adapter makes the Adaptee's interface compatible with the
    // Target's interface.

    class Adapter(Adaptee adaptee) : ITarget
    {
        public string GetRequest()
        {
            return $"This is '{adaptee.GetSpecificRequest()}'";
        }
    }

    class Program
    {
        static void Main(string[] _)
        {
            Adaptee adaptee = new();
            Adapter target = new(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}
