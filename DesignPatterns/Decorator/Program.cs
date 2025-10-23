// EN: Decorator Design Pattern
//
// Intent: Lets you attach new behaviors to objects by placing these objects
// inside special wrapper objects that contain the behaviors.
using System;

namespace csharp.training.congruent.apps.patterns
{
    // EN: The base Component interface defines operations that can be altered
    // by decorators.
    public abstract class Component
    {
        public abstract string Operation();
    }

    // EN: Concrete Components provide default implementations of the
    // operations. There might be several variations of these classes.
    class ConcreteComponent : Component
    {
        public override string Operation()
        {
            return "ConcreteComponent";
        }
    }

    // EN: The base Decorator class follows the same interface as the other
    // components. The primary purpose of this class is to define the wrapping
    // interface for all concrete decorators. The default implementation of the
    // wrapping code might include a field for storing a wrapped component and
    // the means to initialize it.
    abstract class Decorator(Component component) : Component
    {
        protected Component _component = component;

        public void SetComponent(Component component)
        {
            this._component = component;
        }

        // EN: The Decorator delegates all work to the wrapped component.
        public override string Operation()
        {
            if (this._component != null)
            {
                return this._component.Operation();
            }
            else
            {
                return string.Empty;
            }
        }
    }

    // EN: Concrete Decorators call the wrapped object and alter its result in
    // some way.
    class ConcreteDecoratorA(Component comp) : Decorator(comp)
    {
        // EN: Decorators may call parent implementation of the operation,
        // instead of calling the wrapped object directly. This approach
        // simplifies extension of decorator classes.
        public override string Operation()
        {
            return $"ConcreteDecoratorA({base.Operation()})";
        }
    }

    // EN: Decorators can execute their behavior either before or after the call
    // to a wrapped object.
    class ConcreteDecoratorB(Component comp) : Decorator(comp)
    {
        public override string Operation()
        {
            return $"ConcreteDecoratorB({base.Operation()})";
        }
    }
    
    public class Client
    {
        private string code = "TestCode"; 
        public string Code
        {
            get { return code; }       
            set {  code = value; }  
        }
        // EN: The client code works with all objects using the Component
        // interface. This way it can stay independent of the concrete classes
        // of components it works with.
        public void ClientCode(Component component)
        {
            Console.WriteLine($"Client Code = {Code} ==> RESULT: " + component.Operation());
        }
    }
    
    class Program
    {
        static void Main(string[] _)
        {
            Client client = new ();

            var simple = new ConcreteComponent();
            Console.WriteLine("Client: I get a simple component:");
            client.ClientCode(simple);
            Console.WriteLine();

            // EN: ...as well as decorated ones.
            //
            // Note how decorators can wrap not only simple components but the
            // other decorators as well.
            //
            ConcreteDecoratorA decorator1 = new (simple);
            ConcreteDecoratorB decorator2 = new (decorator1);
            Console.WriteLine("Client: Now I've got a decorated component:");
            client.ClientCode(decorator2);
            ConcreteDecoratorB decorator3 = new (decorator2);
            client.ClientCode(decorator3);
        }
    }
}
