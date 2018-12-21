namespace SimplePG.Infrastructure
{
    using Domain;

    public class ProposalGenerator
    {
        readonly IQueue<ProductInformation> queue;
        readonly ICallback<ProductInformation> callback;

        public ProposalGenerator(
            IQueue<ProductInformation> queue,
            ICallback<ProductInformation> callback)
        {
            this.queue = queue;
            this.callback = callback;
        }

        public void Go() // or maybe GoAsync and pass cancellation token?
        {
            queue.Subscribe(callback);
        }
    }
}