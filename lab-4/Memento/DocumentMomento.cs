namespace Task5_Memento
{
    public class DocumentMemento
    {
        public string Content { get; }

        public DocumentMemento(string content)
        {
            Content = content;
        }
    }
}
