namespace DesignPatterns.Builder
{
    public class Director
    {
        #region Constructor
        public Director() { }
        #endregion

        #region Public Methods
        public void Construct(Builder builder)
        {
            builder.AddPartA();
            builder.AddPartB();
            builder.AddPartC();
        }
        #endregion
    }
}
