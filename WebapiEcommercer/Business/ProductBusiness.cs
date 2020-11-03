using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.Converters;
using WebapiEcommercer.Data.VO;
using WebapiEcommercer.Models;
using WebapiEcommercer.Models.Context;
using WebapiEcommercer.Repository.Generic;

namespace WebapiEcommercer.Business
{
    public class ProductBusiness : IProductBusiness
    {
        private IRepository<Product> _repository;
       
        private readonly ProductConverter _converter;
        private readonly BaseContext _context;


        public ProductBusiness(IRepository<Product> repository )
        {
            _repository = repository;
            _converter = new ProductConverter();
            _context = new BaseContext(); 
        }

        public ProductVO Create(ProductVO product)
        {

            Product productEntity = _converter.Parse(product);
            productEntity = _repository.Create(_converter.Parse(product));
            return _converter.Parse(productEntity);
        }
        public void Delete(Guid id)
        {
            try
            {
               _repository.Delete(id);                
                
            }
            catch (Exception ex)
            {
                throw ex;
            };
        }
        public bool Exists(string name)
        {

            return _repository.Exist(name);
                


        }
        public List<ProductVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        public List<ProductVO> FindByName(string name)
        {
            return _converter.ParseList(_repository.FindByName(name));
        }

        public ProductVO Update(ProductVO item)
        {
            var productEntntiry = _converter.Parse(item);
            productEntntiry = _repository.Update(_converter.Parse(item));

            return _converter.Parse(productEntntiry);
        }

        public ProductVO FindById(int id)
        {
            throw new NotImplementedException();
        }

       
    }

}
