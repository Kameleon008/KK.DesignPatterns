using KK.DesignPattern.Command.Commands;

namespace KK.DesignPattern.Command;

public static class Program
{
    private static readonly Bulb Bulb = new();

    private static readonly RemoteControl Remote = new();

    public static async Task Main()
    {
        var turnOn = new CommandTurnOn(Bulb);
        var turnOff = new CommandTurnOff(Bulb);

        Remote.Execute(turnOn);
        await Task.Delay(500);

        Remote.Execute(turnOff);
        await Task.Delay(500);

        Remote.Undo();
        await Task.Delay(500);


        while (true)
        {
            var color = (ConsoleColor)new Random().Next(9, 16);
            var changeColor = new CommandChangeColor(Bulb, color);
            Remote.Execute(changeColor);
            await Task.Delay(500);
        }
    }


}