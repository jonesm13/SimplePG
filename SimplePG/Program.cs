﻿namespace SimplePG
{
    using System;
    using Domain;
    using Infrastructure;
    using SimpleInjector;

    public class Program
    {
        public static void Main(string[] args)
        {
            InMemoryQueue queue = new InMemoryQueue(new[]
            {
                new ProductInformation(123),
                new ProductInformation(9) 
            });

            Container container = new Container();
            container.RegisterInstance(typeof(IQueue<ProductInformation>), queue);
            container.Register(typeof(ICallback<ProductInformation>), typeof(Callback));
            container.Register<ProposalGenerator>();
            container.Register<IStoreProposals, ConsoleProposalWriter>();

            container.Collection.Append<IAutomationRule, SimpleStockQuantityRule>();
            container.Verify();

            ProposalGenerator generator = container
                .GetInstance<ProposalGenerator>();

            generator.Go();

            Console.WriteLine("Done. Hit [enter] to end...");
            Console.ReadLine();
        }
    }
}