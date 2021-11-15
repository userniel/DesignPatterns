namespace DesignPatterns.FactoryMethod
{
    public interface ICreator<T>
    {
        public T Create<U>() where U : T, new();
    }
}
