namespace SimplePG.Domain
{
    using System.Collections.Generic;
    using System.Linq;
    using ValueTypes;

    public class ProductInformation
    {
        public StockUnits CurrentStock { get; }

        public ProductInformation(StockUnits currentStock)
        {
            CurrentStock = currentStock;
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
