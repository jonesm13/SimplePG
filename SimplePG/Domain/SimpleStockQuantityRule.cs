namespace SimplePG.Domain
{
    using Entities;

    public class SimpleStockQuantityRule : IShouldRestockRule
    {
        public bool ShouldRestock(ProductInformation product)
        {
            return product.CurrentStock < 10;
        }
    }
}