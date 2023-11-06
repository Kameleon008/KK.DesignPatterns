namespace KK.DesignPattern.Builder.Exceptions
{
    internal class CarBuilderNotSetException : Exception
    {
        public CarBuilderNotSetException()
            : base("Car Builder not set.")
        {
        }

        public CarBuilderNotSetException(string message)
            : base(message)
        {
        }

        public CarBuilderNotSetException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}