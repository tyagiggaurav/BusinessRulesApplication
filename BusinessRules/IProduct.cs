using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRules
{
    public interface IProduct
    {
        string Id { get;set; }
        string Name { get;set; }
        bool isCommissionGenerated { get; set; }

    }
}
