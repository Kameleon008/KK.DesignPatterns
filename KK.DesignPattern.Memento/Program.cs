namespace KK.DesignPattern.Memento;

public static class Program
{
    public static void Main()
    {
        var editor = new TextEditor();
        var history = new History();
        
        editor.Content = "First version";
        history.Push(editor.Save());

        editor.Content = "Second Version (some mistakes where made)";

        Console.WriteLine($"Actual content: {editor.Content}");

        // Revert to firs version
        var previousState = history.Pop();
        editor.Restore(previousState);

        Console.WriteLine($"Content after restore: {editor.Content}");
    }
}