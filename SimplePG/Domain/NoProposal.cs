namespace SimplePG.Domain
{
    using System.Collections.Generic;
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

        public override Proposal WithAutomationRules(
            IEnumerable<IAutomationRule> rules)
        {
            return this;
        }
    }
}