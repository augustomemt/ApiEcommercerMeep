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
    public class OrderItemBusiness : IOrderItemBusiness
    {
        private IRepository<OrderItem> _repository;

        private readonly OrderItemConverter _converter;

        public OrderItemBusiness(IRepository<OrderItem> repository)
        {
            _repository = repository;
            _converter = new OrderItemConverter();
        }

        public OrderItemVO Create(OrderItemVO item)
        {

            var orderItemEntity = _converter.Parse(item);
            orderItemEntity = _repository.Create(_converter.Parse(item));
            return _converter.Parse(orderItemEntity);


        }
    }
}
