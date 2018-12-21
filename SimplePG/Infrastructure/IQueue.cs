namespace SimplePG.Infrastructure
{
    public interface IQueue<out T>
    {
        void Subscribe(ICallback<T> callback);
    }
}