using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public void Delete(Guid id)
        {
            T element = dataset.Find(id);
            dataset.Remove(element);
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

        public T FindById(int id)
        {
            return dataset.SingleOrDefault(p => p.Id.Equals(id));
        }

        public T Update(T item)
        {
            dataset.Update(item);

            _context.SaveChanges();

            return item;
        }
    }
}
