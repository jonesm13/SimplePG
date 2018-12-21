namespace SimplePG.Domain
{
    using Infrastructure;

    public class Proposal
    {
        readonly ProductInformation product;

        public Proposal(ProductInformation product)
        {
            this.product = product;
        }

        public void WriteTo(IStoreProposals store)
        {
            store.Store(this);
        }
    }
}