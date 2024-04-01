using BuilderPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        //Builder Pattern
        var letterDirector = new LetterDirector();

        var referenceLetter = letterDirector.ConstructLetter(new ReferenceLetterBuilder());
        referenceLetter.Display();

        var envelopeLetter = letterDirector.ConstructLetter(new EnvelopeBuilder());
        envelopeLetter.Display();
    }
}