namespace csharp.training.congruent.apps
{
    internal class SMSObserver : IObserver
    {
        public void Listen(IAccount? account)
        {
            if (account != null && account is Account)
            {
                Console.WriteLine("IN SMS Sender: Balance: " + (account as Account)!.Balance + " - SMS " + (account as Account)!.Mobile);
            }
        }
    }
}
