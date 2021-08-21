namespace DesignPatterns.FactoryMethod
{
    public interface ICreator
    {
        public Product Create<T>() where T : Product, new();
    }
}
