namespace KK.DesignPattern.Command.Commands
{
    internal class CommandChangeColor(Bulb bulb, ConsoleColor color) : ICommand
    {
        private ConsoleColor _previousColor;

        public void Execute()
        {
            this._previousColor = bulb.Color;
            bulb.SetColor(color);
        }

        public void UnExecute()
        {
            bulb.SetColor(this._previousColor);
        }
    }
}
