namespace SimplePG.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using Ports;

    public class Proposal
    {
        readonly IEnumerable<Supplier> suppliers;
        readonly ProductInformation product;

        Proposal(ProductInformation product, IEnumerable<Supplier> suppliers)
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

        public void WriteTo(IStoreProposals store)
        {
            store.Store(this);
        }
    }
}
