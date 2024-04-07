using System.Security.Cryptography.X509Certificates;

namespace ObserverDesignPattern
{
    public interface IEventAggregator
    {
        void Publish<TEvent>(TEvent eventToPublish);
        void Subscribe<TEvent>(Action<TEvent> eventHandler);
    }
    public class EventAggregator : IEventAggregator
    {
        private readonly Dictionary<Type, List<object>> _eventSubscriptions = new();
        public void Publish<TEvent>(TEvent eventToPublish)
        {
            var eventType = typeof(TEvent);
            if (_eventSubscriptions.ContainsKey(eventType))
                foreach (var subscriber in _eventSubscriptions[eventType].OfType<Action<TEvent>>())
                    subscriber(eventToPublish);
        }
        public void Subscribe<TEvent>(Action<TEvent> eventHandler)
        {
            var eventType = typeof(TEvent);
            if (!_eventSubscriptions.ContainsKey(eventType))
                _eventSubscriptions.Add(eventType, new List<object>());
            _eventSubscriptions[eventType].Add(eventHandler);
        }
    }
}
