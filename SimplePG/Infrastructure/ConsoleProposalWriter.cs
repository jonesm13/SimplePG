namespace SimplePG.Infrastructure
{
    using System;
    using Domain;
    using Domain.Ports;

    public class ConsoleProposalWriter : IStoreProposals
    {
        public void Store(Proposal toStore)
        {
            Console.WriteLine($"Writing proposal of type {toStore.GetType().Name}...");
        }
    }
}