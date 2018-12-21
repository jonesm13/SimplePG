namespace SimplePG.Domain
{
    public class SimpleStockQuantityRule : IAutomationRule
    {
        public bool ShouldAutomate(ProductInformation product)
        {
            return product.CurrentStockQuantity < 10;
        }
    }
}