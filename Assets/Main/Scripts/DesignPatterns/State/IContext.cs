namespace DesignPatterns.State
{
    public interface IContext<T>
    {
        public State<T> State { get; set; }
    }
}
