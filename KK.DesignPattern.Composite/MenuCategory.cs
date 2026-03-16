namespace KK.DesignPattern.Composite
{
    internal class MenuCategory(string categoryName) : IMenuComponent
    {
        private readonly List<IMenuComponent> _children = [];

        public void Display()
        {
            Console.WriteLine($"\nCATEGORY: {categoryName.ToUpper()}");
            foreach (var element in _children)
            {
                element.Display();
            }
        }

        public void Add(IMenuComponent component) => _children.Add(component);
    }
}
