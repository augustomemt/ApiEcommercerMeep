using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiEcommercer.Data.VO
{
    public class OrderItemVO
    {
        public Guid? Id { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required(ErrorMessage ="Valor do produto é obrigatório")]
        public decimal ProductValue { get; set; }
        [Required(ErrorMessage = "Nome do produto é obrigatório")]
        public string ProductName { get; set; }
        public Guid OrderId { get; set; }

    }
}
