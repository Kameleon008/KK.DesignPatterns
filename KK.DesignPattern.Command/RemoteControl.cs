using KK.DesignPattern.Command.Commands;

namespace KK.DesignPattern.Command
{
    internal class RemoteControl
    {
        private readonly CommandHistory _commandHistory = new CommandHistory();

        public void Execute(ICommand command)
        {
            _commandHistory.Push(command);
            command.Execute();
        }

        public void Undo()
        {
            var command = _commandHistory.Pop();
            command?.UnExecute();
        }
    }
}
