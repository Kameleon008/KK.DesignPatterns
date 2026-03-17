namespace KK.DesignPattern.State
{
    internal static class Logging
    {
        public static void UserMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[USER]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        public static void MachineMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[MACHINE]: ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }
    }
}
