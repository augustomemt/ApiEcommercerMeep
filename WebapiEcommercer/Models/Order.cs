using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiEcommercer.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public string Cpf { get; set; }

        public decimal TotalValue { get; set; }

        public List<OrderItem> itens { get; set; }
    }
}
