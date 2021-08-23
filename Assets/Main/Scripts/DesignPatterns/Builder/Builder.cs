namespace DesignPatterns.Builder
{
    public abstract class Builder
    {
        #region Constructor
        protected Builder()
        {
            Reset();
        }
        #endregion

        #region Public Methods
        public abstract void Reset();
        public abstract void AddPartA();
        public abstract void AddPartB();
        public abstract void AddPartC();
        #endregion
    }
}
