using KK.DesignPattern.Factory.Enums;
using KK.DesignPattern.Factory.Models.Shapes;

namespace KK.DesignPattern.Factory
{
    internal static class ShapeFactory
    {
        public static IShape Create(Shapes name)
        {
            return name switch
            {
                Shapes.Circle => new Circle(),
                Shapes.Square => new Square(),
                Shapes.Triangle => new Triangle(),
                _ => throw new ArgumentOutOfRangeException(nameof(name), name, null)
            };
        }
    }
}
