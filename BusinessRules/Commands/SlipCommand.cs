using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.Commands
{
    class SlipCommand : ICommand
    {
        readonly string operation;
        readonly IProduct product;
    }
}
