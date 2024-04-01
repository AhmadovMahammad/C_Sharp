namespace BuilderPattern
{
    public class EnvelopeBuilder : LetterBuilder
    {
        public override void BuildDimension()
        {
            letter.PaperSize = PaperSize.A4;
            letter.Width = 100;
            letter.Height = 200;
        }
        public override void BuildHeader()
        {
            letter.Header = "Birthday Envelope";
        }
        public override void BuildStyle()
        {
            letter.BgColor = BackgroundColor.Transparent;
        }
    }
}
