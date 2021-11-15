namespace DesignPatterns.Composite
{
    public class Leaf : IComponent
    {
        #region Constructor
        public Leaf() { }
        #endregion

        #region Public Methods
        public void Add()
        {
            throw new System.NotImplementedException();
        }
        public IComponent GetComponent()
        {
            throw new System.NotImplementedException();
        }

        public void Remove()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
