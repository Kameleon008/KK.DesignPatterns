using System;
using System.Collections.Generic;
using System.Text;

namespace KK.DesignPattern.Memento
{
    internal class History
    {
        private readonly Stack<TextEditorMemento> _history = new Stack<TextEditorMemento>();

        public void Push(TextEditorMemento memento) => _history.Push(memento);

        public TextEditorMemento Pop() => _history.Pop();
    }
}
