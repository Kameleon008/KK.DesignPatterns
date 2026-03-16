using System.Runtime.CompilerServices;

namespace KK.DesignPattern.Singleton
{
    public class Singleton
    {
        private static Singleton? _instance;

        public DateTime CreateTime { get; init; }

        private Singleton()
        {
            this.CreateTime = DateTime.Now;
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    Singleton._instance = new Singleton();
                }

                return _instance;
            }
        }

    }
}
