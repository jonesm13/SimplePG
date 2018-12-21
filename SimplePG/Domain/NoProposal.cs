namespace SimplePG.Domain
{
    using Ports;

    public sealed class NoProposal : Proposal
    {
        public NoProposal(ProductInformation product) : base(product)
        {
        }

        public override Proposal WithSuppliers(IFetchSuppliers supplierSource)
        {
            return this;
        }
    }
}