namespace KK.DesignPattern.State.CoffeeMachineStates
{
    internal abstract class CoffeeMachineState(CoffeeMachine context)
    {
        protected CoffeeMachine context = context;

        public abstract void InsertCoin();

        public abstract void SelectCoffee(CoffeeTypes coffee);
    }
}
