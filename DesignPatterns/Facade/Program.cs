// EN: Facade Design Pattern
//
// Intent: Provides a simplified interface to a library, a framework, or any
// other complex set of classes.
using System;

namespace csharp.training.congruent.apps.patterns
{
    // EN: The Facade class provides a simple interface to the complex logic of
    // one or several subsystems. The Facade delegates the client requests to
    // the appropriate objects within the subsystem. The Facade is also
    // responsible for managing their lifecycle. All of this shields the client
    // from the undesired complexity of the subsystem.
    public class Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
    {
        protected Subsystem1 _subsystem1 = subsystem1;
		
        protected Subsystem2 _subsystem2 = subsystem2;

        // EN: The Facade's methods are convenient shortcuts to the
        // sophisticated functionality of the subsystems. However, clients get
        // only to a fraction of a subsystem's capabilities.
        public string Operation()
        {
            string result = "Facade initializes subsystems:\n";
            result += this._subsystem1.Operation1();
            result += this._subsystem2.Operation1();
            result += "Facade orders subsystems to perform the action:\n";
            result += this._subsystem1.OperationN();
            result += this._subsystem2.OperationZ();
            return result;
        }
    }
    
    // EN: The Subsystem can accept requests either from the facade or client
    // directly. In any case, to the Subsystem, the Facade is yet another
    // client, and it's not a part of the Subsystem.
    public class Subsystem1
    {
        private readonly string _opname = "1";
        public string Operation1()
        {
            return $"Subsystem{_opname}: Ready!\n";
        }

        public string OperationN()
        {
            return $"Subsystem {_opname}: Go From Operation N!\n";
        }
    }
	
    // EN: Some facades can work with multiple subsystems at the same time.
    public class Subsystem2
    {
        private readonly string _opname = "2";
        public string Operation1()
        {
            return $"Subsystem{_opname}: Get ready!\n";
        }

        public string OperationZ()
        {
            return $"Subsystem{_opname}: Fire! From Operation Z\n";
        }
    }


    class Client
    {
        // EN: The client code works with complex subsystems through a simple
        // interface provided by the Facade. When a facade manages the lifecycle
        // of the subsystem, the client might not even know about the existence
        // of the subsystem. This approach lets you keep the complexity under
        // control.
        public static void ClientCode(Facade facade)
        {
            Console.Write(facade.Operation());
        }
    }
    
    class Program
    {
        static void Main(string[] _)
        {
            // EN: The client code may have some of the subsystem's objects
            // already created. In this case, it might be worthwhile to
            // initialize the Facade with these objects instead of letting the
            // Facade create new instances.
  
            Subsystem1 subsystem1 = new ();
            Subsystem2 subsystem2 = new ();
            Facade facade = new (subsystem1, subsystem2);
            Client.ClientCode(facade);
        }
    }
}
