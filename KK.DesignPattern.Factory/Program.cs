using KK.DesignPattern.Factory.Enums;

namespace KK.DesignPattern.Factory;

internal class Program
{
    internal static void Main()
    {
        var circle = ShapeFactory.Create(Shapes.Circle);
        var triangle = ShapeFactory.Create(Shapes.Triangle);
        var square = ShapeFactory.Create(Shapes.Square);

        circle.Draw();
        triangle.Draw();
        square.Draw();
    }
}