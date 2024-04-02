namespace BridgeDesignPattern.Senders
{
    public abstract class MessageSender
    {
        public abstract void SendMessage(string subject, string body);
        public abstract void Start();
    }
}
