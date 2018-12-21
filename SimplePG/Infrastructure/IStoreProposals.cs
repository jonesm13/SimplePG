namespace SimplePG.Infrastructure
{
    using Domain;

    public interface IStoreProposals
    {
        void Store(Proposal toStore);
    }
}