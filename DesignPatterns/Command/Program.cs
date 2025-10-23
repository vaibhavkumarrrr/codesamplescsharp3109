// EN: Command Design Pattern
//
// Intent: Turns a request into a stand-alone object that contains all
// information about the request. This transformation lets you parameterize
// methods with different requests, delay or queue a request's execution, and
// support undoable operations.
using System;

namespace csharp.training.congruent.apps.patterns
{
    // EN: The Command interface declares a method for executing a command.
    public interface ICommand
    {
        void Execute();
    }

    // EN: Some commands can implement simple operations on their own.
    class SimpleCommand(string payload) : ICommand
    {
        public void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({payload})");
        }
    }

    // EN: However, some commands can delegate more complex operations to other
    // objects, called "receivers."
    class ComplexCommand(Receiver receiver, string a, string b) : ICommand
    {
        private readonly Receiver _receiver = receiver;

        // EN: Context data, required for launching the receiver's methods.
        private readonly string _a = a;
        private readonly string _b = b;

        // EN: Commands can delegate to any methods of a receiver.
        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }

    // EN: The Receiver classes contain some important business logic. They know
    // how to perform all kinds of operations, associated with carrying out a
    // request. In fact, any class may serve as a Receiver.
    class Receiver
    {
        private int _readerCode; 
        public static int count = 0;
        public Receiver()
        {
            _readerCode = 0; count++;
        }
        public int ReaderCode
        {
            get { return _readerCode; }
            set { _readerCode = value; }
        }
        public void DoSomething(string a)
        {
            Console.WriteLine($"Receiver: {this.ReaderCode} of {Receiver.count} Working on ({a}.)");
        }

        public void DoSomethingElse(string b)
        {
            Console.WriteLine($"Receiver: {this.ReaderCode} of {Receiver.count} Also working on ({b}.)");
        }
    }

    // EN: The Invoker is associated with one or several commands. It sends a
    // request to the command.
    //
    // RU: Отправитель связан с одной или несколькими командами. Он отправляет
    // запрос команде.
    class Invoker
    {
        private ICommand _onStart;

        private ICommand _onFinish;

        // EN: Initialize commands.
        //
        // RU: Инициализация команд
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            this._onFinish = command;
        }

        // EN: The Invoker does not depend on concrete command or receiver
        // classes. The Invoker passes a request to a receiver indirectly, by
        // executing a command.
        //
        // RU: Отправитель не зависит от классов конкретных команд и
        // получателей. Отправитель передаёт запрос получателю косвенно,
        // выполняя команду.
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            try
            {
                this._onStart.Execute();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            Console.WriteLine("Invoker: ...doing something really important...");
            
            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            try 
            {
                this._onFinish.Execute();
            }
            catch { 
                //_onFinish can be null or can be a non ICommand
            }
        }
    }

    class Program
    {
        static void Main(string[] _)
        {
            // EN: The client code can parameterize an invoker with any
            // commands.
            //
            // RU: Клиентский код может параметризовать отправителя любыми
            // командами.
            Invoker invoker = new();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}
