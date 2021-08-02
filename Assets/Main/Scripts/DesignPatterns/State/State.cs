namespace DesignPatterns.State
{
    public abstract class State<T>
    {
        protected T _context;

        #region Constructor
        protected State(T context)
        {
            _context = context;
        }
        #endregion

        #region Public Methods
        public abstract void Handle();
        #endregion
    }
}
