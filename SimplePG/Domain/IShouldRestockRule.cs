namespace SimplePG.Domain
{
    public interface IShouldRestockRule
    {
        bool ShouldRestock(ProductInformation product);
    }
}