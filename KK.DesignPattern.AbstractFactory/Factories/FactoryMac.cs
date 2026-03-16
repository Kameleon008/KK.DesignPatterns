using KK.DesignPattern.AbstractFactory.Components.Buttons;
using KK.DesignPattern.AbstractFactory.Components.Checkboxes;

namespace KK.DesignPattern.AbstractFactory.Factories
{
    internal class FactoryMac : IFactory
    {
        public IButton CreateButton(string name)
        {
            return new MacButton(name);
        }

        public ICheckbox CreateCheckbox(string name)
        {
            return new MacCheckbox(name);
        }
    }
}
