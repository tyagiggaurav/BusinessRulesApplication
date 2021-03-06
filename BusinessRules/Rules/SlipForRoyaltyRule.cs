﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessRules.Products;
using BusinessRules.Commands;

namespace BusinessRules.Rules
{
   public class SlipForRoyaltyRule:IRule
    {
        public IReadOnlyCollection<ICommand> Handle(IProduct product)
        {
            if (product is Book)
                return new[] { new SlipCommand("royalty program", product) };
            return new ICommand[0];

        }
    }
}
