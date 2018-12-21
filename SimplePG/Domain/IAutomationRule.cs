namespace SimplePG.Domain
{
    public interface IAutomationRule
    {
        bool ShouldAutomate(ProductInformation product);
    }
}