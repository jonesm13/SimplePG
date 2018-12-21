namespace SimplePG.Infrastructure
{
    using System.Collections.Generic;
    using Domain;
    using Domain.Ports;

    public class Callback : ICallback<ProductInformation>
    {
        readonly IEnumerable<IShouldRestockRule> restockingRules;
        readonly IStoreProposals store;
        readonly IFetchSuppliers supplierSource;
        readonly IEnumerable<IAutomationRule> automationRules;

        public Callback(
            IEnumerable<IShouldRestockRule> restockingRules,
            IStoreProposals store,
            IFetchSuppliers supplierSource,
            IEnumerable<IAutomationRule> automationRules)
        {
            this.restockingRules = restockingRules;
            this.store = store;
            this.supplierSource = supplierSource;
            this.automationRules = automationRules;
        }

        public void OnReceived(ProductInformation received)
        {
            received
                .CreateProposal(restockingRules)
                .WithSuppliers(supplierSource)
                .WithAutomationRules(automationRules)
                .WriteTo(store);
        }
    }
}