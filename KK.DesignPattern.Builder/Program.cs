using KK.DesignPattern.Builder.Builders;

namespace KK.DesignPattern.Builder;

internal class Program
{
    internal static void Main()
    {
        var dealer = new CarDealer();

        var sportCar = dealer.OrderSportCar();
        sportCar.DisplaySpec();

        var electricCar = dealer.OrderElectricCar();
        electricCar.DisplaySpec();

        var sportCarBuilder = new CarBuilderSport();
        sportCarBuilder.SetEngine("V8");
        sportCarBuilder.SetGps("None");
        sportCarBuilder.SetSunroof("Cabriolet");
        sportCarBuilder.SetSeats("Two sport bucket seats");

        var customSportCar = sportCarBuilder.Build();
        customSportCar.DisplaySpec();



    }
}