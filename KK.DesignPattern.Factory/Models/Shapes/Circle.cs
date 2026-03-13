namespace KK.DesignPattern.Factory.Models.Shapes
{
    internal class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine();
            Console.WriteLine("  ###  ");
            Console.WriteLine(" #   # ");
            Console.WriteLine("#     #");
            Console.WriteLine("#     #");
            Console.WriteLine("#     #");
            Console.WriteLine(" #   # ");
            Console.WriteLine("  ###  ");
            Console.WriteLine();
        }
    }
}
