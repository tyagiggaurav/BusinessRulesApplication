using System;
using System.Collections.Generic;
using System.Text;
using BusinessRules.Products;
using BusinessRules.Commands;

namespace BusinessRules.Rules
{
   public class SlipForRoyaltyRule:IRule
    {
        public IReadOnlyCollection<ICommand> Handle(IProduct good)
        {
            if (good is Book)
                return new[] { new SlipCommand("royalty program", good) };
            return new ICommand[0];

        }
    }
}
