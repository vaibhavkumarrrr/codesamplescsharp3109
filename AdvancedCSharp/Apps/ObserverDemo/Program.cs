namespace csharp.training.congruent.apps
{
    internal class Program
    {
        static void Main(string[] _)
        {
            Console.WriteLine("Hello, World!");
            Account account = new()
            {
                //(account as Account).Balance = 300; 
                Mobile = "9940146501",
                Email = "somemail@google.com"
            };
            IObserver smsObserver  = new SMSObserver();
            account.Attach(smsObserver);
            account.WithDrawMoney(300);
            account.WithDrawMoney(600);
            IObserver eMailObserver = new EmailObserver();
            account.Attach(eMailObserver);
            account.WithDrawMoney(-900);
            account.Detach(smsObserver);
            account.WithDrawMoney(600);
            // play around with any attach/detach..
            account.Attach(smsObserver);
            account.WithDrawMoney(900);
        }
    }
}
