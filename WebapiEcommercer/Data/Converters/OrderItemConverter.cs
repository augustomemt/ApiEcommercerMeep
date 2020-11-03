using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.Converter;
using WebapiEcommercer.Data.VO;
using WebapiEcommercer.Models;

namespace WebapiEcommercer.Data.Converters
{
    public class OrderItemConverter : IParse<OrderItemVO, OrderItem>, IParse<OrderItem, OrderItemVO>
    {
        public OrderItem Parse(OrderItemVO origin)
        {
            if (origin == null) return new OrderItem();
            return new OrderItem
            {
                Id = origin.Id,
                OrderId = origin.OrderId,
                ProductId = origin.ProductId,
                ProductName = origin.ProductName,
                ProductValue = origin.ProductValue
            };
        }

        public OrderItemVO Parse(OrderItem origin)
        {
            if (origin == null) return new OrderItemVO();
            return new OrderItemVO
            {
                Id = origin.Id,
                OrderId = origin.OrderId,
                ProductId = origin.ProductId,
                ProductName = origin.ProductName,
                ProductValue = origin.ProductValue
            };
        }

        public List<OrderItem> ParseList(List<OrderItemVO> origin)
        {
            if (origin == null) return new List<OrderItem>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<OrderItemVO> ParseList(List<OrderItem> origin)
        {
            if (origin == null) return new List<OrderItemVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
