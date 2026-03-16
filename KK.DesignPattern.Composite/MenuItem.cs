namespace KK.DesignPattern.Composite
{
    internal class MenuItem(string name, double price) : IMenuComponent
    {
        public void Display()
        {
            Console.WriteLine($"  Dish: {name} - {price} EUR");
        }
    }
}
