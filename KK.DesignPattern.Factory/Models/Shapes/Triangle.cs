namespace KK.DesignPattern.Factory.Models.Shapes
{
    internal class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine();
            Console.WriteLine("   #   ");
            Console.WriteLine("  # #  ");
            Console.WriteLine(" #   # ");
            Console.WriteLine("#     #");
            Console.WriteLine("#######");
            Console.WriteLine();

        }
    }
}
