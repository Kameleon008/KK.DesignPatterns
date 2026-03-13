namespace KK.DesignPattern.Builder.Builders
{
    internal class CarBuilderSport : ICarBuilder
    {
        private readonly Car _car = new Car();

        public ICarBuilder SetSeats(string value)
        {
            this._car.Seats = $"SportCar - {value}";
            return this;
        }

        public ICarBuilder SetEngine(string value)
        {
            this._car.Engine = $"SportCar - {value}";
            return this;
        }

        public ICarBuilder SetGps(string value)
        {
            this._car.Gps = $"SportCar - {value}";
            return this;
        }

        public ICarBuilder SetSunroof(string value)
        {
            this._car.Sunroof = $"SportCar - {value}";
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
