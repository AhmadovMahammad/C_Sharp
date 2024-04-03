namespace MementoDesignPattern
{
    public class Position
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
    public class NotepadEditor
    {
        public string Text { get; set; } = string.Empty;
        public Position MousePosition { get; set; } = new();

        public NotepadEditorMemento SaveCurrentState()
        {
            return new NotepadEditorMemento(Text, MousePosition);
        }
        public void RestorePreviousState(NotepadEditorMemento memento)
        {
            Text = memento.Text;
            MousePosition = memento.MousePosition;
        }


        public void WriteText(string text)
        {
            Text += $" {text}";
        }
        public void GetCurrentText()
        {
            Console.WriteLine($"current editor text : {Text}");
        }
    }
}
