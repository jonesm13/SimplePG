namespace SimplePG.Domain.Ports
{
    using System.Collections.Generic;

    public interface IFetchSuppliers
    {
        IEnumerable<Supplier> GetSuppliers(ProductInformation product);
    }
}