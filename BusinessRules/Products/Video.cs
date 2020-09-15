using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRules.Products
{
    public class Video:IProduct
    {
        public Video(string id, string name)
        {
            Id = id;
            Name = name;
        }
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
