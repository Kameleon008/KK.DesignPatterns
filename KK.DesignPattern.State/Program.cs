using KK.DesignPattern.State;

public static class Program
{
    public static async Task Main()
    {
        var machine = new CoffeeMachine();

        await Task.Delay(1000);
        Logging.UserMessage("Inserting Coin");
        machine.InsertCoin();

        await Task.Delay(1000);
        var coffee = (CoffeeTypes)new Random().Next(1, 6);
        Logging.UserMessage($"Press Button with coffee {coffee.ToString()}");
        machine.SelectCoffee(coffee);

        await Task.Delay(5000);
        Logging.UserMessage("Takes Coffee to go");
    }
}