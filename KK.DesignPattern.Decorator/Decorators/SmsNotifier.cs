namespace KK.DesignPattern.Decorator.Decorators
{
    internal class SmsNotifier(INotifier notifier) : BaseDecorator(notifier)
    {
        public override void Notify(string message)
        {
            base.Notify(message);
            Console.WriteLine("Send Notification SMS: {0}", message);
        }
    }
}
