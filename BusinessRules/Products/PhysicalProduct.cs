using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.Products
{
    public class PhysicalProduct : IProduct
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public bool isCommissionGenerated { get; set; }

        public PhysicalProduct(string id, string name)
        {
            Id = id;
            Name = name;
        }

    }


}
