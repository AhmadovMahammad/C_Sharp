namespace BridgeDesignPattern.Messages
{
    public class ConfirmMessage : BaseMessage
    {
        public ConfirmMessage(string Subject, string Body) : base(Subject, Body)
        {
        }
        public override void Send()
        {
            MessageSender?.SendMessage(Subject, Body);
        }
    }
}
