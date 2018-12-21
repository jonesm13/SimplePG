namespace SimplePG.Domain.Ports
{
    using Entities;

    public interface IStoreProposals
    {
        void Store(Proposal toStore);
    }
}