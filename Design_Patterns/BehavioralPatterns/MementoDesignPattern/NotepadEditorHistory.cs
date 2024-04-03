namespace MementoDesignPattern
{
    public class NotepadEditorHistory
    {
        private readonly Stack<NotepadEditorMemento> _undoVersions = new();
        private readonly Stack<NotepadEditorMemento> _redoVersions = new();

        //following method tries to clear previous sessions and store only newer version.
        public void SaveEditor(NotepadEditor editor)
        {
            _redoVersions.Clear();
            _undoVersions.Push(editor.SaveCurrentState());
            Console.WriteLine($"current editor text : {editor.Text}");
        }

        //      <--- || ctrl + Z
        public void UndoEditor(NotepadEditor editor)
        {
            //editor text as example : 
            //1. hello 2. world 3. helloworld

            //we click undo button

            //now editor text is world and helloworld is added into redo stack

            if (_undoVersions.Count > 0)
            {
                var previousMemento = _undoVersions.Pop();
                _redoVersions.Push(editor.SaveCurrentState());
                editor.RestorePreviousState(previousMemento);
            }
            else
                Console.WriteLine("undo history is empty");
        }

        //      ---> || ctrl + shift + Z 
        public void RedoEditor(NotepadEditor editor)
        {
            if (_redoVersions.Count > 0)
            {
                var nextMemento = _redoVersions.Pop();
                _undoVersions.Push(editor.SaveCurrentState());
                editor.RestorePreviousState(nextMemento);
            }
            else
                Console.WriteLine("redo history is empty");
        }
    }
}
