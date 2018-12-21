namespace SimplePG.Infrastructure
{
    using Domain;

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