using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiEcommercer.Models
{
    public class OrderItem 
    {
       public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public decimal ProductValue { get; set; }
        public string ProductName { get; set; }
        public Guid OrderId { get; set; }

    }
}
