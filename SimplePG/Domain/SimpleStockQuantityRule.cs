namespace SimplePG.Domain
{
    public class SimpleStockQuantityRule : IShouldRestockRule
    {
        public bool ShouldRestock(ProductInformation product)
        {
            return product.CurrentStock < 10;
        }
    }
}