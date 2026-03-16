namespace KK.DesignPattern.AbstractFactory.Components.Buttons
{
    internal class WindowsButton(string name) : IButton
    {
        public string Name { get; } = name;

        public void Render()
        {
            Console.WriteLine("WinButton: [{0}]", this.Name);
        }

        public void Press()
        {
            Console.WriteLine("[{0}] Pressed on Windows!", this.Name);
        }
    }
}
