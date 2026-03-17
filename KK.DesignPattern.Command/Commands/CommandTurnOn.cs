namespace KK.DesignPattern.Command.Commands
{
    internal class CommandTurnOn(Bulb bulb) : ICommand
    {
        public void Execute()
        {
            bulb.TurnOn();
        }

        public void UnExecute()
        {
            bulb.TurnOff();
        }
    }
}
