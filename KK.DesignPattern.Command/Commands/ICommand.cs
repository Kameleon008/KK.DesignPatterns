namespace KK.DesignPattern.Command.Commands
{
    public interface ICommand
    {
        public void Execute();

        public void UnExecute();
    }
}
