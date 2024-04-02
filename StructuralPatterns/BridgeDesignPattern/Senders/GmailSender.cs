using System.Net;
using System.Net.Mail;

namespace BridgeDesignPattern.Senders
{
    public class GmailSender : MessageSender
    {
        private SmtpClient? _smtpClient;
        public string SmtpServer { get; }
        public string SmtpPort { get; }
        public string Username { get; }
        public string Password { get; }
        public GmailSender(string smtpServer, string smtpPort, string username, string password)
        {
            SmtpServer = smtpServer;
            SmtpPort = smtpPort;
            Username = username;
            Password = password;
        }
        public override void SendMessage(string subject, string body)
        {
            //var from = new MailAddress(Username, "Bridge Pattern");
            //using var mail = new MailMessage(from, new MailAddress("random@gmail.com"));
            //mail.Subject = subject;
            //mail.Body = body;
            //mail.IsBodyHtml = true;

            //if (_smtpClient is not null)
            //{
            //    _smtpClient.Send(mail);
            //    Console.WriteLine("Message is sent through Gmail Service");
            //}

            Console.WriteLine($"Message is sent through Gmail Service\n[Subject : {subject}] | [Body : {body}]");
        }
        public override void Start()
        {
            try
            {
                var email = Username;
                var password = Password;
                var smtpServer = SmtpServer;
                var smtpPort = SmtpPort;
                _smtpClient = new("smtp.gmail.com", Convert.ToInt32(smtpPort))
                {
                    Credentials = new NetworkCredential(email, password),
                    EnableSsl = true
                };
            }
            catch (Exception)
            {
                throw new Exception("error occured while starting gmail service.");
            }
        }
    }
}
