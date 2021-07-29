namespace DesignPatterns.State
{
    public abstract class State
    {
        protected Context _context = null;

        #region Constructor
        protected State(Context context)
        {
            _context = context;
        }
        #endregion
        
        #region Public Methods
        public abstract void Handle();
        #endregion
    }
}
