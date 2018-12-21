namespace SimplePG.Infrastructure
{
    public interface ICallback<in T>
    {
        void OnReceived(T received);
    }
}