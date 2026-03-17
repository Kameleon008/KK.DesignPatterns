namespace KK.DesignPattern.Flyweight
{
    internal class TreeType(string name, string color, string texture)
    {
        public string Name { get; } = name;

        public string Color { get; } = color;

        public string Texture { get; } = texture;

        public void Draw(int x, int y)
        {
            Console.WriteLine($"Draw tree {Name} (Color: {Color}, Texture: {Texture}) on position [{x}, {y}]");
        }
    }
}
