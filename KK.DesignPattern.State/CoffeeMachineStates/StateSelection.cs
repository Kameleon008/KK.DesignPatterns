namespace KK.DesignPattern.State.CoffeeMachineStates
{
    internal class StateSelection(CoffeeMachine context) : CoffeeMachineState(context)
    {
        public override void InsertCoin()
        {
            Logging.MachineMessage("Coin already inside!");
        }

        public override void SelectCoffee(CoffeeTypes coffeeType)
        {
            Logging.MachineMessage($"Selected {coffeeType.ToString()}...");
            context.ChangeState(new StateBrewing(context, coffeeType));
        }
    }
}
