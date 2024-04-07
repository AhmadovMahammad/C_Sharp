using ObserverDesignPattern.Events;

namespace ObserverDesignPattern
{
    public class Client
    {
        private readonly IEventAggregator _eventAggregator;
        public Client(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            InitializeSubscriptions();
        }
        public void InitializeSubscriptions()
        {
            _eventAggregator.Subscribe<InvalidOperationEvent>(InvalidOperationEventHandler);
        }
        private void InvalidOperationEventHandler(InvalidOperationEvent handler)
        {
            Console.WriteLine("exception : {0}", handler.ErrorDescription);
        }
    }
}
