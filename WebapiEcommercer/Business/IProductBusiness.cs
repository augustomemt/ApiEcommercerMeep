using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.VO;

namespace WebapiEcommercer.Business
{
    public interface IProductBusiness
    {
        ProductVO Create(ProductVO contratos);
        ProductVO FindById(int id);
        List<ProductVO> FindAll();
        List<ProductVO> FindByName(string name);
        ProductVO Update(ProductVO item);
        void Delete(Guid id);
        bool Exists(string Name);



    }
}
