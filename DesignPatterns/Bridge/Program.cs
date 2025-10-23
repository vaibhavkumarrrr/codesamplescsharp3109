// EN: Bridge Design Pattern
//
// Intent: Lets you split a large class or a set of closely related classes into
// two separate hierarchies—abstraction and implementation—which can be
// developed independently of each other.
//
//               A
//            /     \                        A         N
//          Aa      Ab        ===>        /     \     / \
//         / \     /  \                 Aa(N) Ab(N)  1   2
//       Aa1 Aa2  Ab1 Ab2
using System;
using System.ComponentModel.DataAnnotations;

namespace csharp.training.congruent.apps.patterns
{
    // EN: The Abstraction defines the interface for the "control" part of the
    // two class hierarchies. It maintains a reference to an object of the
    // Implementation hierarchy and delegates all of the real work to this
    // object.
    class Abstraction(IImplementation implementation)
    {
        protected IImplementation _implementation = implementation;

        public virtual string Operation()
        {
            return "Abstract: Base operation with:\n" + 
                _implementation.OperationImplementation();
        }
    }

    // EN: You can extend the Abstraction without changing the Implementation
    // classes.
    class ExtendedAbstraction(IImplementation implementation) : Abstraction(implementation)
    {
        public override string Operation()
        {
            return "ExtendedAbstraction: Extended operation with:\n" +
                base._implementation.OperationImplementation();
        }
    }

    // EN: The Implementation defines the interface for all implementation
    // classes. It doesn't have to match the Abstraction's interface. In fact,
    // the two interfaces can be entirely different. Typically the
    // Implementation interface provides only primitive operations, while the
    // Abstraction defines higher- level operations based on those primitives.
    //
    public interface IImplementation
    {
        string OperationImplementation();
    }

    // EN: Each Concrete Implementation corresponds to a specific platform and
    // implements the Implementation interface using that platform's API.
    //
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationA: The result in platform A.\n";
        }
    }

    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "ConcreteImplementationB: The result in platform B.\n";
        }
    }

    class Client
    {
        // EN: Except for the initialization phase, where an Abstraction object
        // gets linked with a specific Implementation object, the client code
        // should only depend on the Abstraction class. This way the client code
        // can support any abstraction-implementation combination.
        //
        private string code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public Client()
        {
            code = "Client No Code";
        }
        public void ClientCode(Abstraction abstraction)
        {
            Console.Write($"Client{Code}-{abstraction.Operation()}");
        }
    }
    
    class Program
    {
        static void Main(string[] _)
        {
            Client client = new()
            {
                Code = "Code666"
            };

            Abstraction abstraction;
            // EN: The client code should be able to work with any pre-
            // configured abstraction-implementation combination.
            //
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);
            Console.WriteLine();
            
            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
        }
    }
}
