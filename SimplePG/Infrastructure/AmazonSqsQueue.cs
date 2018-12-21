namespace SimplePG.Infrastructure
{
    using Domain.Entities;

    public class AmazonSqsQueue : IQueue<ProductInformation>
    {
        public void Subscribe(ICallback<ProductInformation> callback)
        {
            while(true) // or maybe, while(!cancelled)
            {
                // TODO
            }
        }
    }
}