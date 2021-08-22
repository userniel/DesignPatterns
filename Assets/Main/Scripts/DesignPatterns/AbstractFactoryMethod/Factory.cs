namespace DesignPatterns.AbstractFactoryMethod
{
    public abstract class Factory
    {
        #region Constructor
        public Factory() { }
        #endregion

        #region Public Methods
        public abstract ProductA CreateA<T>() where T : ProductA, new();
        public abstract ProductB CreateB<T>() where T : ProductB, new();
        #endregion
    }
}
