using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiEcommercer.Models
{
    public class Product
    {

        public Guid id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Value { get; set; }


    }
}
