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
    
    public class ProductController : Controller
    {
        private IProductBusiness _productBusiness;

        public ProductController(IProductBusiness product)
        {
            _productBusiness = product;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productBusiness.FindAll());
        }

        [HttpGet("{Name}")]
        public IActionResult Get(string name)
        {

            var product = _productBusiness.FindByName(name);
            if (product == null) return NotFound();
            return Ok(product);
        }
        [HttpPost]
        public IActionResult Post([FromBody]ProductVO product)
        {
            if (_productBusiness.Exists(product.Name).Equals(true)) return Ok(new { Description = "Este item já esxite" });       
            if (product == null) return BadRequest();
            return new ObjectResult(_productBusiness.Create(product));
        }
        [HttpPut("{id}")]
        public IActionResult Put([FromBody]ProductVO product)
        {
            if (product == null) return BadRequest();
            return new ObjectResult(_productBusiness.Update(product));
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productBusiness.Delete(id);
            return NoContent();
        }

    }
}
