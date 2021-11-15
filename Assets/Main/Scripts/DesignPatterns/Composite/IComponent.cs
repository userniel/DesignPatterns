namespace DesignPatterns.Composite
{
    public interface IComponent
    {
        public void Add();
        public void Remove();
        public IComponent GetComponent();
    }
}
