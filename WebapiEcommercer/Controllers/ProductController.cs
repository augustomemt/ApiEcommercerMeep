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
using WebapiEcommercer.Repository.Generic;

namespace WebapiEcommercer.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private IProductBusiness _productBusiness;
        private readonly BaseContext _context;


        public ProductController(IProductBusiness product)
        {
            _productBusiness = product;
            _context = new BaseContext();
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string name)
        {
            if (!String.IsNullOrEmpty(name))
            {
                return Ok(_productBusiness.FindByName(name));
            }
            return Ok(_productBusiness.FindAll());
        }

        //[HttpGet("find-by-name")]
        //public IActionResult GetByName([FromQuery] string name)
        //{
        //    //if (product == null) return NotFound();
        //    return Ok(_productBusiness.FindByName(name));
        //}
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]ProductVO product)
        {
            if (product == null) return BadRequest();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (_productBusiness.Exists(product.Name).Equals(true)) return Ok(new { Description = "Este item já esxite" });
            return new ObjectResult(_productBusiness.Create(product));
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromBody]ProductVO product , Guid id)
        {
            if (product == null) return BadRequest();
            product.Id = id;
            return new ObjectResult(_productBusiness.Update(product));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var product =  _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            
            _productBusiness.Delete(id);
            return NoContent();
        }

    }
}
