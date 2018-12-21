namespace SimplePG.Domain
{
    using Entities;

    public interface IAutomationRule
    {
        bool CanBeAutomated(Proposal proposal);
    }
}