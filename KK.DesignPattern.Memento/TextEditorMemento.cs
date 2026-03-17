namespace KK.DesignPattern.Memento
{
    internal class TextEditorMemento(string content)
    {
        public string Content { get; } = content;

        public DateTime CreatedAt { get; } = DateTime.Now;
    }
}
