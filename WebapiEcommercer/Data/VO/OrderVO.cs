using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Models;

namespace WebapiEcommercer.Data.VO
{
    public class OrderVO
    {
        [JsonIgnore]
        public Guid? Id { get; set; }
        [Required(ErrorMessage = "CPF obrigatório")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "CPF inválido")]
        public string Cpf { get; set; }
        public decimal TotalValue { get; set; }
        [JsonIgnore]
        public List<OrderItem> itens { get; set; }
    }
}
