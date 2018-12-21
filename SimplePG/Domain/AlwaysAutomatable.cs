namespace SimplePG.Domain
{
    public class AlwaysAutomatable : IAutomationRule
    {
        public bool CanBeAutomated(Proposal proposal)
        {
            return true;
        }
    }
}