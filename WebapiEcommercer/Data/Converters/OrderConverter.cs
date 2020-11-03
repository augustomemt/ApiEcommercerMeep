using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebapiEcommercer.Data.Converter;
using WebapiEcommercer.Data.VO;
using WebapiEcommercer.Models;

namespace WebapiEcommercer.Data.Converters
{
    public class OrderConverter : IParse<OrderVO, Order>, IParse<Order, OrderVO>
    {
        public Order Parse(OrderVO origin)
        {
            if (origin == null) return new Order();
            return new Order
            {
                Id = origin.Id,
                Cpf = origin.Cpf,
                itens = origin.itens,
                TotalValue = origin.TotalValue
            };
        }

        public OrderVO Parse(Order origin)
        {
            if (origin == null) return new OrderVO();
            return new OrderVO
            {
                Id = origin.Id,
                Cpf = origin.Cpf,
                itens = origin.itens,
                TotalValue = origin.TotalValue
            };
        }

        public List<Order> ParseList(List<OrderVO> origin)
        {
            if (origin == null) return new List<Order>();
            return origin.Select(item => Parse(item)).ToList();
        }

        public List<OrderVO> ParseList(List<Order> origin)
        {
            if (origin == null) return new List<OrderVO>();
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
