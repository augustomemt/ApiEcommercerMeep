using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.VO;

namespace WebapiEcommercer.Models
{
    public class Order : BaseEntity.BaseEntity
    {
        
        [Required(ErrorMessage = "CPF obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido")]
        public string Cpf { get; set; }

        public decimal TotalValue { get; set; }

        public List<OrderItem> itens { get; set; }
    }
}
