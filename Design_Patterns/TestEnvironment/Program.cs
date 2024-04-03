using BridgeDesignPattern.Messages;
using BridgeDesignPattern.Senders;
using DecoratorDesignPattern;
using FlyweightDesignPattern;
using SingletonDesignPattern;
using BuilderDesignPattern;
using ChainOfResponsibilityDesignPattern;
using System.Reflection;
using MementoDesignPattern;

internal class Program
{
    private static void Main()
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

        ////Thread 1
        //var process_first = new Thread(() =>
        //{
        //    var dbConnection = SingletonDatabaseConnection.GetInstance("User Id=MAHAMMADA;Server=.;Database=BraInvest_CourseManagement;Integrated Security=Yes;");
        //    dbConnection.RunQuery(query);
        //});

        ////Thread 2
        //var process_second = new Thread(() =>
        //{
        //    var dbConnection = SingletonDatabaseConnection.GetInstance("User Id=RandomUsername;Server=.;Database=BraInvest_CourseManagement;Integrated Security=Yes;");
        //    dbConnection.RunQuery(query);
        //});

        ////Alhough we get second instance of database connection with random properties, it uses only the first one

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

        #region Behavioral Design Patterns

        #region ChainOfResponsibility Pattern

        //consider that we have a class that checks all the validations in itself

        //One function with too many if/else statements violates the “Single Responsibility Principle”
        //as this function just does “too” many things!

        //Although the code looks somewhat readable,
        //in future if we have to add new input fields,
        //we would need to add more validations to this function which eventually grows bigger.

        //-----------------------------------------------------------
        //So we should apply this design pattern.

        //var registerProcessor = new UserRegisterProcessor();
        //var listOfUsers = new List<UserDto>
        //{
        //    new()
        //    {
        //        Firstname = "Mahammad",
        //        Lastname = "Ahmadov",
        //        Age = 21,
        //        Email = "dev.ahmadov.mahammad@gmail.com",
        //        Password = "random_pass"
        //    },
        //    new()
        //    {
        //        Firstname = "Mahammad",
        //        Lastname = "Ahmadov",
        //        Age = 15,
        //        Email = "randomMail@mail.ru",
        //        Password = "short"
        //    },
        //    new()
        //    {
        //        Firstname = "Mahammad",
        //        Lastname = "Ahmadov",
        //        Age = 16,
        //        Email = "justtohide007@gmail.com",
        //        Password = "short124"
        //    },
        //};

        //foreach (var user in listOfUsers)
        //{
        //    var notificationMessage = string.Empty;
        //    if (registerProcessor.Register(user))
        //        notificationMessage += "registered successfully.";
        //    else
        //        notificationMessage += "error occured while registering.";
        //    Console.WriteLine("[ {0} ] : {1}\n", user.Email, notificationMessage);
        //}

        ///*
        // 1. [ dev.ahmadov.mahammad@gmail.com ] : registered successfully.

        // 2. error message : password length should be at least 8 characters.
        //    [ randomMail@mail.ru ] : error occured while registering.

        // 3. error message : only 18+ ages people can register fromm this website
        //    [ justtohide007@gmail.com ] : error occured while registering.
        // */

        #endregion

        #region Memento Pattern / Snapshot

        //var notepadHistory = new NotepadEditorHistory();
        //var editor = new NotepadEditor
        //{
        //    Text = "hello",
        //    MousePosition = new()
        //    {
        //        X = 15,
        //        Y = 20,
        //    }
        //};
        //notepadHistory.SaveEditor(editor);

        //editor.WriteText("world");
        //editor.WriteText("how are you?");
        //notepadHistory.SaveEditor(editor);

        //notepadHistory.UndoEditor(editor);
        //editor.GetCurrentText();

        //notepadHistory.RedoEditor(editor);
        //editor.GetCurrentText();
        
        #endregion

        #endregion
    }
}