namespace KK.DesignPattern.Singleton
{
    internal class DifferentPlace
    {
        private readonly Singleton _singleton = Singleton.Instance;

        public void DoSomething()
        {
            Console.WriteLine("Different place - DoSomething(): {0:HH:mm:ss:fff}", _singleton.CreateTime);
        }

    }
}
