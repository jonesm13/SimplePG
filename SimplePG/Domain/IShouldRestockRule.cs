namespace SimplePG.Domain
{
    using Entities;

    public interface IShouldRestockRule
    {
        bool ShouldRestock(ProductInformation product);
    }
}