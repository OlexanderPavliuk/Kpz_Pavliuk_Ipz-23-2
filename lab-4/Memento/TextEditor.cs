using System.Collections.Generic;

namespace Task5_Memento
{
    public class TextEditor
    {
        private readonly TextDocument _document;
        private readonly Stack<DocumentMemento> _history;

        public TextEditor(TextDocument document)
        {
            _document = document;
            _history = new Stack<DocumentMemento>();
        }

        public void Type(string newText)
        {
            _history.Push(_document.Save());
            _document.SetContent(newText);
        }

        public void Undo()
        {
            if (_history.Count > 0)
            {
                var memento = _history.Pop();
                _document.Restore(memento);
            }
        }

        public string GetText()
        {
            return _document.GetContent();
        }
    }
}
