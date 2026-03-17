using KK.DesignPattern.Flyweight;

public static class Program
{
    public static void Main()
    {
        var random = new Random();
        var qty = random.Next(100, 1001);

        var treeTypes = new List<TreeType>
        {
            new("Oak", "green", "a3f1c2d4-9b7e-4c1a-8f3d-2e5b6a7c8d90"),
            new("Pine", "dark green", "b7e2a9c1-3d4f-4a8b-9c2e-6f1d3a5b7c88"),
            new("Birch", "light green", "c1d9e8f7-2a3b-4c5d-8e9f-1a2b3c4d5e6f"),
            new("Maple", "red", "d4c3b2a1-7e6f-4d5c-9b8a-0f1e2d3c4b5a"),
            new("Spruce", "blue green", "e8f7d6c5-4b3a-4d2c-9e1f-7a6b5c4d3e2f"),
        };

        List<Tree> trees = [];

        for (var i = 0; i < qty; i++)
        {
            var treeType = treeTypes[random.Next(0, 4)];
            var x = random.Next(0, 1000);
            var y = random.Next(0, 1000);

            trees.Add(new Tree(x, y, treeType));
        }

        trees.ForEach(tree => tree.Display());
    }
}


