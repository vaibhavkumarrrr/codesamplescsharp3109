namespace csharp.training.congruent.classes { 
   public class Account
    {
        private double _balance;
        public double Balance { get { return _balance; }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
                else
                {
                    Console.WriteLine("Balance cannot be negative.");
                }
            }
        }
    }

}