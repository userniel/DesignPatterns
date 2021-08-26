namespace DesignPatterns.Builder
{
    public class Director
    {
        #region Constructor
        public Director() { }
        #endregion

        #region Public Methods
        public void Construct<T>(Builder<T> builder)
        {
            builder.AddPartA();
            builder.AddPartB();
            builder.AddPartC();
        }
        #endregion
    }
}
