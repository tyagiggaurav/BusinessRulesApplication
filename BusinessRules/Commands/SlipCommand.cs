using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.Commands
{
   public class SlipCommand : ICommand
    {
        readonly string operation;
        readonly IProduct product;
    }
}
