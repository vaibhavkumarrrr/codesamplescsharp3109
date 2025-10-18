using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.training.congruent.apps
{
    internal class Account : IAccount
    {
        private double _balance = 0;

        private string _mobiles = string.Empty;
        private string _email = string.Empty;

        public String Mobile
        {
            get { return _mobiles; }
            set { _mobiles = value;  }
        }
        public String Email
        {
            get { return _email; }
            set { _email = value; }

        }
            
        private readonly List<IObserver> _observers = [];
        public Account() { }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }       
        }
        public void WithDrawMoney(double balance)
        {
            _balance -= balance;
            this.Send(); // send notifications... 
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }


        public void Send()
        {
            foreach(var observer in _observers)
            {
                observer.Listen(this);
            }
        }



    }
}
