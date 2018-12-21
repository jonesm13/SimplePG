namespace SimplePG.Infrastructure
{
    using System.Collections.Generic;
    using Domain;

    public class Callback : ICallback<ProductInformation>
    {
        readonly IEnumerable<IAutomationRule> rules;
        readonly IStoreProposals store;

        public Callback(
            IEnumerable<IAutomationRule> rules,
            IStoreProposals store)
        {
            this.rules = rules;
            this.store = store;
        }

        public void OnReceived(ProductInformation received)
        {
            received
                .CreateProposal(rules)
                .WriteTo(store);
        }
    }
}