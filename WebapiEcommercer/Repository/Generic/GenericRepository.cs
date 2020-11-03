using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.VO;
using WebapiEcommercer.Models;
using WebapiEcommercer.Models.BaseEntity;
using WebapiEcommercer.Models.Context;

namespace WebapiEcommercer.Repository.Generic
{
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        //Injection of Depenciciens Context 

        protected readonly BaseContext _context;

        private DbSet<T> dataset;


        public GenericRepository(BaseContext context)
        {
            _context = context;

            dataset = _context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                
                dataset.Add(item);
                _context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return item;
        }

        public  void Delete(Guid id)
        {
            T element = dataset.Find(id);
            if(!_context.Orders.Any(e => e.Id == element.Id).Equals(true))
            {
                dataset.Remove(element);
            }           
           _context.SaveChanges();
        }

        public bool Exist(string Name)
        {
            return _context.Products.Any(p => p.Name == Name);
        }

        public List<T> FindAll()
        {
            return dataset.ToList();
        }        

        public List<T> FindByName(string name)
        {
            var product = _context.Products.Where(p => p.Name == name).FirstOrDefault();
            return dataset.Where(p => p.Id == product.Id).ToList();
        }
        

        public T Update(T item)
        {
            dataset.Update(item);

            _context.SaveChanges();

            return item;
        }

       
    }
}
