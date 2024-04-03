namespace MementoDesignPattern
{
    public class NotepadEditorMemento
    {
        public string Text { get; } = string.Empty;
        public Position MousePosition { get; } = new();
        public NotepadEditorMemento(string editorText, Position position)
        {
            Text = editorText;
            MousePosition = position;
        }
    }
}
