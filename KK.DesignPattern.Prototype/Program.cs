using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace KK.DesignPattern.Prototype;

public static class Program
{
    public static void Main()
    {
        var document = new Document();
        document.AddContent("Some Content");
        document.AddAnnotation("annotation_1");
        document.AddAnnotation("annotation_2");

        Console.WriteLine("Original:");
        DisplayDocument(document);

        var clone = document.Clone();
        Console.WriteLine("Clone:");
        DisplayDocument(clone);

        clone.AddContent("Updated document");
        clone.AddAnnotation("cloned");
        Console.WriteLine("Clone:");
        DisplayDocument(clone);

        var deepClone = document.DeepClone();
        Console.WriteLine("DeepClone:");
        DisplayDocument(deepClone);
    }

    private static void DisplayDocument(Document document)
    {

        document.DisplayContent();
        document.DisplayAnnotations();
        document.DisplayCreateDate();
        Console.WriteLine();
    }
}