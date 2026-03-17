using KK.DesignPattern.Command.Commands;

namespace KK.DesignPattern.Command
{
    public class CommandHistory
    {
        private readonly List<ICommand> _commands = [];

        public void Push(ICommand command)
        {
            this._commands.Add(command);
        }

        public ICommand? Pop()
        {
            if (_commands.Count <= 0)
            {
                return null;
            }

            var lastCommand = this._commands[^1];
            _commands.RemoveAt(_commands.Count - 1);

            return lastCommand;

        }

        public void Clear()
        {
            _commands.Clear();
        }

    }
}
