namespace csharp.training.congruent.apps
{
    internal class EmailObserver : IObserver
    {
        public void Listen(IAccount?   account)
        {
            // See the complex use of 
            // ? = nullable type
            // check for not null 
            // ! for null forgiving compiler... 
            if (account !=null && account is Account)
            {
                Console.WriteLine($"Observer for Emails: {(account as Account)!.Balance} Mail will be sent to : {(account as Account)!.Email}");     ;
            }
        }
    }
}
