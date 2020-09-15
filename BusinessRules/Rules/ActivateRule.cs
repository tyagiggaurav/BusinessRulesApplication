using System;
using System.Collections.Generic;
using System.Text;
using BusinessRules.Products;
using BusinessRules.Commands;

namespace BusinessRules.Rules
{
   public class ActivateRule:IRule
    {
        public IReadOnlyCollection<ICommand> Handle(IProduct product)
        {
            var membership = product as Membership;
            if (membership != null)
                return new[] { new ActivateCommand(membership) };
            return new ICommand[0];
        }
    }
}
