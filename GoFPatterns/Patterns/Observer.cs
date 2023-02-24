namespace GoFPatterns.Patterns
{
    // Behavioral pattern
    public class Observer
    {

        // email; 
        // we have information about amount of observers 
        public void Notify()
        {
        }
    }

    public class Observable 
    {
        private List<Observer> Observers { get; set; }

        // SubscribeObserver, RemoveObs

        public void NotifyObservers() 
        {
            foreach (var obs in Observers)
                obs.Notify();
        }
    }
}
