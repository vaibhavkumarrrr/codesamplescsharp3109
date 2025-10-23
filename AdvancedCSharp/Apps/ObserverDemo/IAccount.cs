namespace csharp.training.congruent.apps
{
    internal interface IAccount
    {
        public void Attach(IObserver observer);
        public void Detach(IObserver observer);
     

        public void Send(); 

    }
}
