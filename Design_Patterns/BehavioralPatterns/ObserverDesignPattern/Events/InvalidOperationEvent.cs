namespace ObserverDesignPattern.Events
{
    public class InvalidOperationEvent
    {
        public InvalidOperationEvent(string errorDescription)
        {
            ErrorDescription = errorDescription;
        }
        public string ErrorDescription { get; }
    }
}
