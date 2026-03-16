namespace KK.DesignPattern.AbstractFactory.Components.Buttons
{
    internal interface IButton
    {
        public string Name { get; }

        public void Render();

        public void Press();
    }
}
