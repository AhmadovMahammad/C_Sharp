namespace BuilderDesignPattern
{
    public abstract class LetterBuilder
    {
        protected Letter letter = new();
        public abstract void BuildHeader();
        public abstract void BuildDimension();
        public abstract void BuildStyle();
        public Letter GetLetter()
        {
            return letter;
        }
    }
}
