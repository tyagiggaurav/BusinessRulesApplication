using System;
using System.Collections.Generic;
using System.Text;
using BusinessRules.Products;
using BusinessRules.Commands;

namespace BusinessRules.Rules
{
    public class UpgradeRule : IRule
    {
        public IReadOnlyCollection<ICommand> Handle(IProduct product)
        {
            var membership = product as Membership;
            if (product is Membership)
                return new[] { new UpgradeCommand(membership) };
            return new ICommand[0];

        }
    }
}
