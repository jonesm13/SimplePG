namespace SimplePG.Domain
{
    public interface IAutomationRule
    {
        bool CanBeAutomated(Proposal proposal);
    }
}