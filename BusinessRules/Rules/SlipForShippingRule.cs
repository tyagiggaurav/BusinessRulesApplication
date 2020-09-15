using System;
using System.Collections.Generic;
using System.Text;
using BusinessRules.Products;
using BusinessRules.Commands;

namespace BusinessRules.Rules
{
   public class SlipForShippingRule:IRule
    {
        public IReadOnlyCollection<ICommand> Handle(IProduct product)
        {
            if (product is PhysicalProduct ||
                product is Book ||
                product is Video)
                return new[] { new SlipCommand("Shipping", product) };
            return new ICommand[0];
        }
    }
}
