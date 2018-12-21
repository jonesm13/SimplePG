namespace SimplePG.Infrastructure
{
    using System.Collections.Generic;
    using System.Linq;
    using Domain.Entities;
    using Domain.Ports;

    public class EmptySupplierSource : IFetchSuppliers
    {
        public IEnumerable<Supplier> GetSuppliers(ProductInformation product)
        {
            return Enumerable.Empty<Supplier>();
        }
    }
}