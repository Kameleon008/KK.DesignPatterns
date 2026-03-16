namespace KK.DesignPattern.Singleton;

public static class Program
{
    public static void Main()
    {
        // INACCESSIBLE (private constructor)
        //var singleton = new Singleton();

        var singleton = Singleton.Instance;
        Console.WriteLine("Initial singleton instance: {0:HH:mm:ss:fff}", singleton.CreateTime);

        var otherInstance = Singleton.Instance;
        Console.WriteLine("Some other singleton instance: {0:HH:mm:ss:fff}", otherInstance.CreateTime);

        var differentPlace = new DifferentPlace();
        differentPlace.DoSomething();

    }
}