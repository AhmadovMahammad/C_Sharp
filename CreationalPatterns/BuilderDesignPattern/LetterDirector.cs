namespace BuilderDesignPattern
{
    public class LetterDirector
    {
        public Letter ConstructLetter(LetterBuilder builder)
        {
            builder.BuildDimension();
            builder.BuildStyle();
            builder.BuildHeader();

            return builder.GetLetter();
        }
    }
}
