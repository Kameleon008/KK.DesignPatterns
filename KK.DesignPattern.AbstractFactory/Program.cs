using KK.DesignPattern.AbstractFactory.Components.Buttons;
using KK.DesignPattern.AbstractFactory.Components.Checkboxes;
using KK.DesignPattern.AbstractFactory.Factories;

namespace KK.DesignPattern.AbstractFactory;

public static class Program
{
    public static void Main()
    {
        var factories = new List<IFactory>
        {
            new FactoryWindows(),
            new FactoryMac()
        };

        var buttons = new List<IButton>();
        var checkboxes = new List<ICheckbox>();

        foreach (var factory in factories)
        {
            buttons.Add(factory.CreateButton("Button"));
            checkboxes.Add(factory.CreateCheckbox("Checkbox"));
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Windows UI:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        buttons[0].Render();
        buttons[0].Press();
        checkboxes[0].Render();
        checkboxes[0].Toggle();
        checkboxes[0].Render();
        checkboxes[0].Toggle();
        checkboxes[0].Render();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;


        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("MAC UI:");
        Console.ForegroundColor = ConsoleColor.Magenta;
        buttons[1].Render();
        buttons[1].Press();
        checkboxes[1].Render();
        checkboxes[1].Toggle();
        checkboxes[1].Render();
        checkboxes[1].Toggle();
        checkboxes[1].Render();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
    }


}