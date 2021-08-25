namespace DesignPatterns.Adapter
{
    public abstract class Adapter<T>
    {
        protected T _adaptee;

        #region Constructor
        public Adapter(T adaptee)
        {
            _adaptee = adaptee;
        }
        #endregion
    }
}
