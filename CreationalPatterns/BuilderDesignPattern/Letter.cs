namespace BuilderDesignPattern
{
    public enum PaperSize
    {
        A4,
        A5,
        A6,
        A7,
        A8,
        A9,
    }
    public enum BackgroundColor
    {
        Gray,
        White,
        Transparent
    }
    public class Letter
    {
        public string Header { get; set; } = string.Empty;
        public int Width { get; set; }
        public int Height { get; set; }
        public PaperSize PaperSize { get; set; }
        public BackgroundColor BgColor { get; set; }
        public void Display()
        {
            Console.WriteLine(Header.PadLeft(Header.Length + 3, '-'));
            Console.WriteLine($"paper size : {PaperSize} |  {Width} * {Height}");
            Console.WriteLine($"{BgColor} background color");
        }
    }
}
