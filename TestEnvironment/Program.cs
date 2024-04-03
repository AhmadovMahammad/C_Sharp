using BridgeDesignPattern.Messages;
using BridgeDesignPattern.Senders;
using BuilderDesignPattern;
using SingletonDesignPattern;
using DecoratorDesignPattern;
using FlyweightDesignPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Creational Design Patterns

        #region Builder Pattern

        //var letterDirector = new LetterDirector();

        //var referenceLetter = letterDirector.ConstructLetter(new ReferenceLetterBuilder());
        //referenceLetter.Display();

        //var envelopeLetter = letterDirector.ConstructLetter(new EnvelopeBuilder());
        //envelopeLetter.Display();

        #endregion

        #region Singleton Pattern

        //var query = @"INSERT INTO AuditLogs 
        //              VALUES('/about',1,'empty','GET','Admin','Account','Leadership',200,GETDATE(), GETDATE(), GETDATE(),null, null,null)";

        //Thread 1
        //var process_first = new Thread(() =>
        //{
        //    var dbConnection = SingletonDatabaseConnection.GetInstance("User Id=MAHAMMADA;Server=.;Database=BraInvest_CourseManagement;Integrated Security=Yes;");
        //    dbConnection.RunQuery(query);
        //});

        //Thread 2
        //var process_second = new Thread(() =>
        //{
        //    var dbConnection = SingletonDatabaseConnection.GetInstance("User Id=RandomUsername;Server=.;Database=BraInvest_CourseManagement;Integrated Security=Yes;");
        //    dbConnection.RunQuery(query);
        //});

        //Alhough we get second instance of database connection with random properties, it uses only the first one

        //process_first.Start();
        //process_second.Start();

        //process_first.Join();
        //process_second.Join();

        #endregion

        #endregion

        #region Structural Design Patterns

        #region Bridge Pattern

        //var gmailSender = new GmailSender("smtp.mail.ru", "587", "dev.ahmadov.mahammad@gmail.com", "password");
        //gmailSender.Start();

        //var telegramSender = new TelegramSender("apiKey");
        //telegramSender.Start();


        //var confirmMessage = new ConfirmMessage("Confirmation Letter", "Your message has been approved") { MessageSender = telegramSender };
        //confirmMessage.Send();

        //var errorMessage = new ErrorMessage("Error Letter", "Your message has been cancelled") { MessageSender = gmailSender };
        //errorMessage.Send();

        #endregion

        #region Decorator Pattern

        //IBeverage beverage = new Tea();
        //Console.WriteLine(beverage.Description + " $" + beverage.Cost);
        ////Black Tea $1.5

        //beverage = new Milk(beverage);
        //beverage = new Caramel(beverage);
        //Console.WriteLine(beverage.Description + " $" + beverage.Cost);
        ////Black Tea, Extra Milk, Caramel $2.75

        //beverage = new Espresso();
        //beverage = new Caramel(beverage);
        //beverage = new Caramel(beverage);
        //Console.WriteLine(beverage.Description + " $" + beverage.Cost);
        ////Espresso, Caramel, Caramel $3.49

        #endregion

        #region Flyweight Pattern

        //var gameArena = new GameArena();
        //gameArena.StartGame(100, 100);

        ////Result : 
        ////Total Grid : 10000
        ////Instances count : 24

        ////for non-pattern situation, we should created a new instance for each enemy.
        ////on the contrary, we created 24 new instances for 10_000 enemy

        #endregion

        #endregion
    }
}