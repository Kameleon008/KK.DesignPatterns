namespace KK.DesignPattern.State.CoffeeMachineStates
{
    internal class StateBrewing : CoffeeMachineState
    {
        private CoffeeTypes selectedCoffee;

        public StateBrewing(CoffeeMachine context, CoffeeTypes coffee) : base(context)
        {
            this.selectedCoffee = coffee;
            _ = this.StartBrewing();
        }

        public override void InsertCoin()
        {
            Logging.MachineMessage("Wait, brewing Cafe!");
        }

        public override void SelectCoffee(CoffeeTypes type)
        {
            Logging.MachineMessage("You've already selected!");
        }

        private async Task StartBrewing()
        {
            Logging.MachineMessage($"Brewing started {selectedCoffee}...");
            await ShowProgressBar();
            Finish();
        }

        public void Finish()
        {
            Logging.MachineMessage($"Your's {selectedCoffee.ToString()} Ready!");
            context.ChangeState(new StateWaiting(context));
        }

        private static async Task ShowProgressBar()
        {
            const int barWidth = 30;
            Console.Write("[");
            var leftPos = Console.CursorLeft;

            for (var i = 0; i <= barWidth; i++)
            {
                var percent = (i * 100) / barWidth;

                Console.SetCursorPosition(leftPos, Console.CursorTop);

                var bar = new string('█', i) + new string('.', barWidth - i);
                Console.Write($"{bar}] {percent}%");

                await Task.Delay(100);
            }

            Console.WriteLine();
        }
    }
}
