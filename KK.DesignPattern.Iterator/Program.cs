using KK.DesignPattern.Iterator.Collections;

public static class Program
{
    static void Main()
    {
        // The client code may or may not know about the Concrete Iterator
        // or Collection classes, depending on the level of indirection you
        // want to keep in your program.
        var collection = new WordsCollection();
        collection.AddItem("First");
        collection.AddItem("Second");
        collection.AddItem("Third");
        collection.AddItem("Fourth");


        Console.WriteLine("Straight traversal:");

        foreach (var element in collection)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("\nReverse traversal:");

        collection.ReverseDirection();

        foreach (var element in collection)
        {
            Console.WriteLine(element);
        }
    }
}