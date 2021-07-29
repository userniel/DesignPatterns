namespace DesignPatterns.State
{
    public class Context
    {
        private State _state = null;

        #region Constructor
        public Context() { }
        #endregion

        #region Public Methods
        public virtual void Request()
        {
            _state.Handle();
        }
        public virtual void SetState(State state)
        {
            _state = state;
        }
        #endregion
    }
}
