namespace DesignPatterns.State
{
    public class Context
    {
        protected IState _state;

        #region Constructor
        public Context() { }
        #endregion

        #region Public Methods
        public virtual void Request()
        {
            _state.Handle();
        }
        public void SetState(IState state)
        {
            _state = state;
        }
        public IState GetState()
        {
            return _state;
        }
        #endregion
    }
}
