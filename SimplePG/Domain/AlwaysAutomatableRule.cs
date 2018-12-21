namespace SimplePG.Domain
{
    using Entities;

    public class AlwaysAutomatableRule : IAutomationRule
    {
        public bool CanBeAutomated(Proposal proposal)
        {
            return true;
        }
    }
}