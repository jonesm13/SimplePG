namespace SimplePG.Domain
{
    using System.Collections.Generic;
    using System.Linq;

    public class ProductInformation
    {
        public int CurrentStockQuantity { get; }

        public ProductInformation(int currentStockQuantity)
        {
            CurrentStockQuantity = currentStockQuantity;
        }

        public Proposal CreateProposal(IEnumerable<IAutomationRule> rules)
        {
            if(rules.Any(x => x.ShouldAutomate(this) == false))
            {
                return new NoProposal(this);
            }

            return new Proposal(this);
        }
    }
}