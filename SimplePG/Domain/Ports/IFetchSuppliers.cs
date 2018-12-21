namespace SimplePG.Domain.Ports
{
    using System.Collections.Generic;
    using Entities;

    public interface IFetchSuppliers
    {
        IEnumerable<Supplier> GetSuppliers(ProductInformation product);
    }
}