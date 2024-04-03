using Telegram.Bot;

namespace BridgeDesignPattern.Senders
{
    public class TelegramSender : MessageSender
    {
        private TelegramBotClient? _botClient;
        private readonly string _apiKey;
        public TelegramSender(string apiKey)
        {
            _apiKey = apiKey;
        }
        public override void SendMessage(string subject, string body)
        {
            if (_botClient is not null)
                Console.WriteLine($"Message is sent through Telegram Bot.\n[Subject : {subject}] | [Body : {body}]");
            //send message through bot client
        }
        public override void Start()
        {
            try
            {
                _botClient = new TelegramBotClient(_apiKey);
            }
            catch (Exception)
            {
                throw new Exception("error occured while starting telegram bot.");
            }
            //telegram bot is started   
        }
    }
}
