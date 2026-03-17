using System;
using System.Collections.Generic;
using System.Text;

namespace KK.DesignPattern.Memento
{
    internal class TextEditor
    {
        public string Content { get; set; }

        public TextEditorMemento Save()
        {
            Console.WriteLine("Saving State...");
            return new TextEditorMemento(this.Content);
        }

        public void Restore(TextEditorMemento memento)
        {
            this.Content = memento.Content;
            Console.WriteLine($"State from {memento.CreatedAt} restored");
        }
    }
}
