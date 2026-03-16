using KK.DesignPattern.AbstractFactory.Components.Buttons;
using KK.DesignPattern.AbstractFactory.Components.Checkboxes;

namespace KK.DesignPattern.AbstractFactory.Factories
{
    internal interface IFactory
    {
        public IButton CreateButton(string name);

        public ICheckbox CreateCheckbox(string name);
    }
}
