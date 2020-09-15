using System;
using System.Collections.Generic;
using System.Text;
using BusinessRules.Products;

namespace BusinessRules.Commands
{
    class UpgradeCommand:ICommand
    {
        public UpgradeCommand(Membership membership)
        {
            membership.UpgradeMembership(membership);
        }
    }
}
