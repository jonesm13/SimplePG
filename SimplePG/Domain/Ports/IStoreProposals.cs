namespace SimplePG.Domain.Ports
{
    public interface IStoreProposals
    {
        void Store(Proposal toStore);
    }
}