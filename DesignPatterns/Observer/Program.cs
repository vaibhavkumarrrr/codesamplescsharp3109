// EN: Observer Design Pattern
//
// Intent: Lets you define a subscription mechanism to notify multiple objects
// about any events that happen to the object they're observing.
//
// Note that there's a lot of different terms with similar meaning associated
// with this pattern. Just remember that the Subject is also called the
// Publisher and the Observer is often called the Subscriber and vice versa.
// Also the verbs "observe", "listen" or "track" usually mean the same thing.
using System;
using System.Collections.Generic;
using System.Threading;

namespace csharp.training.congruent.apps.patterns
{
    public interface IObserver
    {
        // EN: Receive update from subject
        void Update(IAccount subject);
    }

    public interface IAccount
    {
        // EN: Attach an observer to the subject.
        void Attach(IObserver observer);

        // EN: Detach an observer from the subject.
        void Detach(IObserver observer);

        // EN: Notify all observers about an event.
        void Notify();
    }

    // EN: The Subject owns some important state and notifies observers when the
    // state changes.
    public class Account : IAccount
    {
        // EN: For the sake of simplicity, the Subject's state, essential to all
        // subscribers, is stored in this variable.
        private double _balance = 0;
        private string _mobile = string.Empty;
        public string Mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        private string _email = string.Empty;   
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public int State { get; set; } = -0;
        public double Balance
        {
            get {   return _balance; }
            set {   _balance = value; }
        }

        private static readonly List<IObserver> observers = [];

        // EN: List of subscribers. In real life, the list of subscribers can be
        // stored more comprehensively (categorized by event type, etc.).
        private readonly List<IObserver> _observers = observers;

        // EN: The subscription management methods.
        public void Attach(IObserver observer)
        {  
            Console.WriteLine("Subject: Attached observer : {0}", observer.GetType().Name);
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
            Console.WriteLine("Subject: Detached observer: {0}", observer.GetType().Name);
        }

        // EN: Trigger an update in each subscriber.
        public void Notify()
        {
            Console.WriteLine("Subject: Notifying observers...");

            foreach (var observer in _observers)
            {
                observer.Update(this);
            }
        }

        // EN: Usually, the subscription logic is only a fraction of what a
        // Subject can really do. Subjects commonly hold some important business
        // logic, that triggers a notification method whenever something
        // important is about to happen (or after it).
        public void WithDrawMoney(double amt)
        {
            this.State = new Random().Next(0, 10);
            this.Balance -= amt;
            Console.WriteLine("\nAccount: Money withdrawn.");
            Thread.Sleep(15);
            this.Notify();
        }
    }

    // EN: Concrete Observers react to the updates issued by the Subject they
    // had been attached to.
    class SMSNotifier : IObserver
    {
        public void Update(IAccount subject)
        {            
            /*if ((subject as Account).State < 3)
            {
                Console.WriteLine("SMSNotifier : Reacted to the event.");
                //Console.WriteLine(subject.)
            }*/
            if (subject is Account)
            {
                Console.WriteLine("SMSNotifier : In real world -- send SMS to {0}", (subject as Account).Mobile);
                Console.WriteLine(" Balance is now: {0}",(subject as Account).Balance);
            }
        }
    }

    class EmailNotifier : IObserver
    {
        public void Update(IAccount subject)
        {
            /*if ((subject as Account).State == 0 || (subject as Account).State >= 2)
            {
                Console.WriteLine("ConcreteObserverB: Reacted to the event.");
            }*/
            if (subject is Account)
            {
                Console.WriteLine("EmailNotifier : In real world -- send Email to {0},",(subject as Account).Email);
                Console.WriteLine(" Balance is now: {0}", (subject as Account).Balance);
            }
        }
    }
    
    class Program
    {
        static void Main(string[] _)
        {
            // EN: The client code.
            var account = new Account
            {
                Mobile = "12334567890",
                Email = "Sriram@sriram.com"
            };
            var smsObserver = new SMSNotifier();
            account.Attach(smsObserver);

            var emailObserver = new EmailNotifier();
            account.Attach(emailObserver);

            account.WithDrawMoney(500);
            account.WithDrawMoney(300);

            account.Detach(emailObserver);

            account.WithDrawMoney(200);
        }
    }
}
