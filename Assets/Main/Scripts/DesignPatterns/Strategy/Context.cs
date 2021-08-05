namespace DesignPatterns.Strategy
{
    public class Context
    {
        protected IStrategy _strategy;

        #region Constructor
        public Context() { }
        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }
        #endregion

        #region Public Methods
        public int Request(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }
        public IStrategy GetStrategy()
        {
            return _strategy;
        }
        #endregion
    }
}
