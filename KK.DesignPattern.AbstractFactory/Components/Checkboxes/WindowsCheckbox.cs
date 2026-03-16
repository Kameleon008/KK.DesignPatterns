namespace KK.DesignPattern.AbstractFactory.Components.Checkboxes
{
    internal class WindowsCheckbox(string name) : ICheckbox
    {
        public string Name { get; } = name;

        public bool IsChecked { get; private set; } = false;

        public void Render()
        {
            switch (IsChecked)
            {
                case true: Console.WriteLine("WindowsCheckbox [W]"); break;
                case false: Console.WriteLine("WindowsCheckbox [ ]"); break;
            }
        }

        public bool Toggle()
        {
            this.IsChecked = !this.IsChecked;
            return this.IsChecked;
        }
    }
}
