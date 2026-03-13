using static System.Console;

namespace KK.DesignPattern.Builder
{
    internal class Car
    {
        public string Seats { get; set; }

        public string Engine { get; set; }

        public string Gps { get; set; }

        public string Sunroof { get; set; }

        public void DisplaySpec()
        {
            WriteLine();
            WriteLine("Seats: {0}", this.Seats);
            WriteLine("Engine: {0}", this.Engine);
            WriteLine("Sunroof: {0}", this.Sunroof);
            WriteLine("GPS: {0}", this.Gps);
        }

    }
}
