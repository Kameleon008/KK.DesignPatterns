using KK.DesignPattern.AbstractFactory.Components.Buttons;
using KK.DesignPattern.AbstractFactory.Components.Checkboxes;

namespace KK.DesignPattern.AbstractFactory.Factories
{
    internal class FactoryWindows : IFactory
    {
        public IButton CreateButton(string name)
        {
            return new WindowsButton(name);
        }

        public ICheckbox CreateCheckbox(string name)
        {
            return new WindowsCheckbox(name);
        }
    }
}
