namespace KK.DesignPattern.Command.Commands
{
    internal class CommandTurnOff(Bulb bulb) : ICommand
    {
        public void Execute()
        {
            bulb.TurnOff();
        }

        public void UnExecute()
        {
            bulb.TurnOn();
        }
    }
}
