using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.Converter;
using WebapiEcommercer.Data.VO;
using WebapiEcommercer.Models;

namespace WebapiEcommercer.Data.Converters
{
    public class ProductConverter : IParse<ProductVO, Product>, IParse<Product, ProductVO>
    {
        public Product Parse(ProductVO origin)
        {
            if (origin == null) return new Product();
            return new Product
            {
                Id = origin.Id,
                Name = origin.Name,
                Category = origin.Category,
                Value = origin.Value
            };
        }
        public ProductVO Parse(Product origin)
        {
            if (origin == null) return new ProductVO();
            return new ProductVO
            {
                Id = origin.Id,
                Name = origin.Name,
                Category = origin.Category,
                Value = origin.Value
            };
        }
        public List<Product> ParseList(List<ProductVO> origin)
        {
            if (origin == null) return new List<Product>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<ProductVO> ParseList(List<Product> origin)
        {
            if (origin == null) return new List<ProductVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
