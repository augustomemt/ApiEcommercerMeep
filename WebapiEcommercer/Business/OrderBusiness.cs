using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.Converters;
using WebapiEcommercer.Data.VO;
using WebapiEcommercer.Models;
using WebapiEcommercer.Repository.Generic;

namespace WebapiEcommercer.Business
{
    public class OrderBusiness : IOrderBusiness
    {
        private IRepository<Order> _repository;

        private readonly OrderConverter _converter;

        public OrderBusiness(IRepository<Order> repository)
        {
            _repository = repository;
            _converter = new OrderConverter();
        }
        public OrderVO Create(OrderVO item)
        {
            var orderEntity = _converter.Parse(item);
            orderEntity = _repository.Create(_converter.Parse(item));
            return _converter.Parse(orderEntity);

        }
        public List<OrderVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }
        public OrderVO FindByCpf(string cpf)
        {
            throw new NotImplementedException();
        }
    }
}
