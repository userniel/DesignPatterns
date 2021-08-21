namespace DesignPatterns.FactoryMethod
{
    public class Creator
    {
        #region Constructor
        public Creator() { }
        #endregion

        #region Public Methods
        public Product Create<T>() where T : Product, new()
        {
            return new T();
        }
        #endregion
    }
}
