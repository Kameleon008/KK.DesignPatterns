using KK.DesignPattern.Proxy.Services;

public static class Program
{
    public static void Main()
    {
        var builder = WebApplication.CreateBuilder();

        builder.Services.AddSingleton<IDataService>(_ =>
        {
            var dataService = new DataService();
            return new DataServiceCachingProxy(dataService);
        });

        var app = builder.Build();

        app.MapGet("/asset/{id:int}", async (int id, IDataService service) => await service.GetItemAsync(id));

        app.Run();
    }
}



Console.WriteLine("     #######     ");
Console.WriteLine("   ##       ##   ");
Console.WriteLine("  #           #  ");
Console.WriteLine(" #  #########  # ");
Console.WriteLine(" #  #########  # ");
Console.WriteLine(" #  #########  # ");
Console.WriteLine("  #  #######  #  ");
Console.WriteLine("   #  #####  #   ");
Console.WriteLine("    #  ###  #    ");
Console.WriteLine("     #######     ");
Console.WriteLine("      =====      ");
Console.WriteLine("      =====      ");
Console.WriteLine("       ===       "); 