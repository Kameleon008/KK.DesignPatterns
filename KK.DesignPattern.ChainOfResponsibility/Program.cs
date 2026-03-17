using KK.DesignPattern.ChainOfResponsibility;

public static class Program
{
    public static void Main()
    {
        var manager = new Manager();
        var director = new Director();
        var board = new Board();

        manager.SetNext(director);
        director.SetNext(board);

        Console.WriteLine();
        manager.ProcessRequest(500);
        
        Console.WriteLine();
        manager.ProcessRequest(1500);
        
        Console.WriteLine();
        manager.ProcessRequest(15000);

    }
}