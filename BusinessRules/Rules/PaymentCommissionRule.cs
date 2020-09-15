using System;
using System.Collections.Generic;
using System.Text;
using BusinessRules.Products;
using BusinessRules.Commands;

namespace BusinessRules.Rules
{
   public class PaymentCommissionRule : IRule
    {
        public IReadOnlyCollection<ICommand> Handle(IProduct product)
        {
            if (product is PhysicalProduct || product is Book)
                return new[] { new PaymentCommissionCommand(product) };
            return new ICommand[0];

        }
    }
}
