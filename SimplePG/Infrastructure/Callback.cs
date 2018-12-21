namespace SimplePG.Infrastructure
{
    using System.Collections.Generic;
    using Domain;
    using Domain.Ports;

    public class Callback : ICallback<ProductInformation>
    {
        readonly IEnumerable<IShouldRestockRule> rules;
        readonly IStoreProposals store;
        readonly IFetchSuppliers supplierSource;

        public Callback(
            IEnumerable<IShouldRestockRule> rules,
            IStoreProposals store,
            IFetchSuppliers supplierSource)
        {
            this.rules = rules;
            this.store = store;
            this.supplierSource = supplierSource;
        }

        public void OnReceived(ProductInformation received)
        {
            received
                .CreateProposal(rules)
                .WithSuppliers(supplierSource)
                .WriteTo(store);
        }
    }
}