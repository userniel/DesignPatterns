namespace DesignPatterns.FactoryMethod
{
    public class Creator
    {
        public Creator() { }

        public Product Create<T>() where T : Product, new()
        {
            return new T();
        }
    }
}
