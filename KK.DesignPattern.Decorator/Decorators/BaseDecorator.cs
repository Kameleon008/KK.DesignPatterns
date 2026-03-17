namespace KK.DesignPattern.Decorator.Decorators
{
    internal abstract class BaseDecorator(INotifier notifier) : INotifier
    {
        private readonly INotifier _wrappedNotifier = notifier;

        public virtual void Notify(string message)
        {
            this._wrappedNotifier.Notify(message);
        }
    }
}
