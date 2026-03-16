namespace KK.DesignPattern.Prototype
{
    public interface IPrototype<out T>
    {
        public T Clone();

        public T DeepClone();

    }
}
