using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.Commands
{
    class PaymentCommissionCommand:ICommand
    {
        public PaymentCommissionCommand(IProduct product)
        {
            GenerateCommission(product);
        }
        public static void GenerateCommission(IProduct product)
        {
            product.isCommissionGenerated = true;
        }
    }
}
