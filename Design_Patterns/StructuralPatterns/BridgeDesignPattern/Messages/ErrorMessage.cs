namespace BridgeDesignPattern.Messages
{
    public class ErrorMessage : BaseMessage
    {
        public ErrorMessage(string subject, string body) : base(subject, body)
        {
        }
        public override void Send()
        {
            MessageSender?.SendMessage(Subject, Body);
        }
    }
}
