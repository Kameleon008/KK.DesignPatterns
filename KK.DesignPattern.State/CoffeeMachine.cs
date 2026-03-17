using KK.DesignPattern.State.CoffeeMachineStates;

namespace KK.DesignPattern.State
{
    internal class CoffeeMachine
    {
        private CoffeeMachineState state;

        public CoffeeMachine()
        {
            this.state = new StateWaiting(this);
        }

        public void ChangeState(CoffeeMachineState state)
        {
            this.state = state;
        }

        public void InsertCoin() => state.InsertCoin();

        public void SelectCoffee(CoffeeTypes type) => state.SelectCoffee(type);
    }
}
