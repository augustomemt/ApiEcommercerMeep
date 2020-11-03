using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.VO;
using WebapiEcommercer.Models;
using WebapiEcommercer.Models.BaseEntity;

namespace WebapiEcommercer.Repository.Generic
{
    public interface IRepository<T> where T : BaseEntity
    {


        T Create(T item);
        List<T> FindByName(string name);

        List<T> FindAll();

        T Update(T item);

        void Delete(Guid id);

        bool Exist(string name);

     
    }
}
