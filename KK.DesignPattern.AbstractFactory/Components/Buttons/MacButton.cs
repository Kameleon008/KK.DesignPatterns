namespace KK.DesignPattern.AbstractFactory.Components.Buttons
{
    internal class MacButton(string name) : IButton
    {
        public string Name { get; } = name;

        public void Render()
        {
            Console.WriteLine("MacButton: [{0}]", this.Name);
        }

        public void Press()
        {
            Console.WriteLine("[{0}] Pressed on MAC!", this.Name);
        }
    }
}
