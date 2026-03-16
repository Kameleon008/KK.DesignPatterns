namespace KK.DesignPattern.AbstractFactory.Components.Checkboxes
{
    internal interface ICheckbox
    {
        public string Name { get; }

        public bool IsChecked { get; }

        public void Render();

        public bool Toggle();
    }
}
