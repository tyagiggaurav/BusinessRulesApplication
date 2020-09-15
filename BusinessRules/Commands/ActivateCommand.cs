using System;
using System.Collections.Generic;
using System.Text;
using BusinessRules.Products;

namespace BusinessRules.Commands
{
    class ActivateCommand:ICommand
    {
        public ActivateCommand(Membership membership)
        {
            membership.ActicateMemberShip(membership);
        }
    }
}
