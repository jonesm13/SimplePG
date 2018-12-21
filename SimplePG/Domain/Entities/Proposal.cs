namespace SimplePG.Domain.Entities
{
    using System.Collections.Generic;
    using System.Linq;
    using Ports;
    using Utilities;

    public class Proposal
    {
        readonly IEnumerable<Supplier> suppliers;
        readonly ProductInformation product;

        protected Proposal(
            ProductInformation product,
            IEnumerable<Supplier> suppliers)
        {
            Ensure.IsNotNull(product, nameof(product));
            Ensure.IsNotNull(suppliers, nameof(suppliers));

            this.product = product;
            this.suppliers = suppliers;
        }

        public Proposal(ProductInformation product)
            : this(product, Enumerable.Empty<Supplier>())
        {
        }

        public virtual Proposal WithSuppliers(IFetchSuppliers supplierSource)
        {
            IEnumerable<Supplier> theSuppliers = supplierSource.GetSuppliers(product);

            return new Proposal(product, theSuppliers);
        }

        public virtual Proposal WithAutomationRules(
            IEnumerable<IAutomationRule> rules)
        {
            if(rules.All(x => x.CanBeAutomated(this)))
            {
                return new AutomatableProposal(product, suppliers);
            }

            return this;
        }

        public void WriteTo(IStoreProposals store)
        {
            store.Store(this);
        }
    }
}
