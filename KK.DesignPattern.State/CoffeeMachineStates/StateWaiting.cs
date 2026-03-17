namespace KK.DesignPattern.State.CoffeeMachineStates
{
    internal class StateWaiting(CoffeeMachine player) : CoffeeMachineState(player)
    {
        public override void InsertCoin()
        {
            Logging.MachineMessage("Now Select Coffee");
            this.context.ChangeState(new StateSelection(context));
        }

        public override void SelectCoffee(CoffeeTypes coffee)
        {
            Logging.MachineMessage("Insert Coin!");
        }
    }
}
