﻿namespace SimplePG.Domain
{
    using System.Collections.Generic;

    public class AutomatableProposal : Proposal
    {
        public AutomatableProposal(
            ProductInformation product,
            IEnumerable<Supplier> suppliers)
            : base(product, suppliers)
        {
        }
    }
}