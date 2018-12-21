namespace SimplePG.Infrastructure
{
    using System.Collections.Generic;
    using Domain;

    public class InMemoryQueue : IQueue<ProductInformation>
    {
        readonly IEnumerable<ProductInformation> items;

        public InMemoryQueue(IEnumerable<ProductInformation> items)
        {
            this.items = items;
        }

        public void Subscribe(ICallback<ProductInformation> callback)
        {
            foreach(ProductInformation item in items)
            {
                callback.OnReceived(item);
            }
        }
    }
}
