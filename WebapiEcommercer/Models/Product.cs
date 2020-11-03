using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiEcommercer.Models
{
    public class Product : BaseEntity.BaseEntity
    {
        [Display(Name="Nome do Produto")]
        [Required(ErrorMessage = "O nome do produto é obrigatório", AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Display(Name = "Categoria")]
        public string Category { get; set; }
        [Display(Name = "Valor do Produto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Value { get; set; }

        

    }
}
