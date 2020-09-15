using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesApplication
{
   public class Book:IProduct
    {
        
        public Book(string id,string name)
        {
            Id = id;
            Name = name;
        }
        public string Name { get; set; }
        public string Id { get; set; }
    }
}
