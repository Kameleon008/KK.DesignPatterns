namespace KK.DesignPattern.Factory.Models.Shapes
{
    internal class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine();
            Console.WriteLine("#######");
            Console.WriteLine("#     #");
            Console.WriteLine("#     #");
            Console.WriteLine("#     #");
            Console.WriteLine("#     #");
            Console.WriteLine("#     #");
            Console.WriteLine("#######");
            Console.WriteLine();

        }
    }
}
