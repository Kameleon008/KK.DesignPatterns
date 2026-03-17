namespace KK.DesignPattern.Flyweight
{
    internal class Tree(int x, int y, TreeType type)
    {
        public readonly TreeType Type = type;

        public void Display()
        {
            this.Type.Draw(x, y);
        }
    }
}
