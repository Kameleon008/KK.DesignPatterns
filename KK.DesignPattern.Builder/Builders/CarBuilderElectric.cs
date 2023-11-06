namespace KK.DesignPattern.Builder.Builders
{
    internal class CarBuilderElectric : ICarBuilder
    {
        private readonly Car _car = new Car();

        public ICarBuilder SetSeats(string value)
        {
            this._car.Seats = $"ElectricCar - {value}";
            return this;
        }

        public ICarBuilder SetEngine(string value)
        {
            this._car.Engine = $"ElectricCar - {value}";
            return this;
        }

        public ICarBuilder SetGps(string value)
        {
            this._car.Gps = $"ElectricCar - {value}";
            return this;
        }

        public ICarBuilder SetSunroof(string value)
        {
            this._car.Sunroof = $"ElectricCar - {value}";
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
