namespace KK.DesignPattern.Builder.Builders
{
    internal interface ICarBuilder
    {
        public ICarBuilder SetSeats(string value);
        
        public ICarBuilder SetEngine(string value);
        
        public ICarBuilder SetGps(string value);
        
        public ICarBuilder SetSunroof(string value);
        
        public Car Build();

    }
}
