namespace BuilderPattern
{
    public class ReferenceLetterBuilder : LetterBuilder
    {
        public override void BuildDimension()
        {
            letter.PaperSize = PaperSize.A7;
            letter.Width = 200;
            letter.Height = 800;
        }
        public override void BuildHeader()
        {
            letter.Header = "Reference Letter";
        }
        public override void BuildStyle()
        {
            letter.BgColor = BackgroundColor.White;
        }
    }
}
