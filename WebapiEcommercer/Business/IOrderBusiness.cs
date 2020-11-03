using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.VO;

namespace WebapiEcommercer.Business
{
    public interface IOrderBusiness
    {
        OrderVO Create(OrderVO item);
        OrderVO FindByCpf(string cpf);
        List<OrderVO> FindAll();
    }
}
