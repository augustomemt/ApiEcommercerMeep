using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebapiEcommercer.Business;
using WebapiEcommercer.Data.VO;
using WebapiEcommercer.Models;
using WebapiEcommercer.Models.Context;

namespace WebapiEcommercer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private IOrderBusiness _orderBusiness;
        
        public OrderController(IOrderBusiness order  )
        {
            _orderBusiness = order;
            
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_orderBusiness.FindAll());
        }
        // POST: api/Order
        [HttpPost]
        public IActionResult PostOrder(OrderVO order)
        {
            if (order == null) return BadRequest();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            order.TotalValue = order.itens.Sum(s => s.ProductValue);
            return new ObjectResult(_orderBusiness.Create(order));
            
        }

       
    }
}
