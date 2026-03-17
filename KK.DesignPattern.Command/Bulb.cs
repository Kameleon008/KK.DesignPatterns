namespace KK.DesignPattern.Command
{
    public class Bulb
    {
        public ConsoleColor Color { get; private set; }= ConsoleColor.White;

        private bool _isTurnOn = true;

        public void SetColor(ConsoleColor color)
        {
            this.Color = color;
            this.Render();
        }

        public void TurnOn()
        {
            this._isTurnOn = true;
            this.Render();
        }

        public void TurnOff()
        {
            this._isTurnOn = false;
            this.Render();
        }

        public void Render()
        {
            Console.Clear();
            var color = ConsoleColor.Black;

            if (_isTurnOn)
            {
                color = this.Color;
            }

            Console.ForegroundColor = color;

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

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("      =====      ");
            Console.WriteLine("      =====      ");
            Console.WriteLine("       ===       ");
        }
    }
}
