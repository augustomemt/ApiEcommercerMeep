﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebapiEcommercer.Data.VO
{
    public class ProductVO : IValidatableObject
    {
        [JsonIgnore]
        public Guid? Id { get; set; }
        [Display(Name = "Nome do Produto")]
        [Required(ErrorMessage = "O nome do produto é obrigatório", AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Display(Name = "Categoria")]
        public string Category { get; set; }
        [Display(Name = "Valor do Produto")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Value { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (String.IsNullOrEmpty(Name))
            {
                yield return new ValidationResult("É necessário definir ou CPF ou CNPJ.", new[] { "CPF", "CNPJ" });
            }

            
        }
    }
}
