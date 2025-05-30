namespace Task5_Memento
{
    public class TextDocument
    {
        private string _content;

        public TextDocument(string initialContent = "")
        {
            _content = initialContent;
        }

        public void SetContent(string content)
        {
            _content = content;
        }

        public string GetContent()
        {
            return _content;
        }

        public DocumentMemento Save()
        {
            return new DocumentMemento(_content);
        }

        public void Restore(DocumentMemento memento)
        {
            _content = memento.Content;
        }
    }
}
