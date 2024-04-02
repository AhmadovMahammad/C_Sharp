using BridgeDesignPattern.Senders;

namespace BridgeDesignPattern.Messages
{
    public abstract class BaseMessage
    {
        protected BaseMessage(string subject, string body)
        {
            Subject = subject;
            Body = body;
        }
        public MessageSender? MessageSender { get; set; }
        public string Subject { get; } = string.Empty;
        public string Body { get; } = string.Empty;
        public abstract void Send();
    }
}
