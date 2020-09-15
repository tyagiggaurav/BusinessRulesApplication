using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules
{
    public interface IRule
    {
        IReadOnlyCollection<ICommand> Handle(IProduct product);
    }
}
