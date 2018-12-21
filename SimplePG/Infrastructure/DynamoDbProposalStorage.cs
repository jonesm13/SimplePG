namespace SimplePG.Infrastructure
{
    using Domain;
    using Domain.Ports;

    public class DynamoDbProposalStorage : IStoreProposals
    {
        public void Store(Proposal toStore)
        {
            if(toStore is NoProposal)
            {
                return;
            }

            // do something else
        }
    }
}