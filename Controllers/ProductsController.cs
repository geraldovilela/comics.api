using comics.api.Data.Entities;
using comics.api.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace comics.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProductService _iproduct;
        public ProductsController(IProductService iproduct)
        {
            _iproduct = iproduct;
        }

        [HttpPost]
        public ActionResult<Product> Create(object data)
        {
            Product newProduct = _iproduct.Create(data);
            return Ok(newProduct);
        }

        [HttpPut("id")]
        public Product Update(Product productChanges)
        {
            //_iproduct.Update();
            return null;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            //_iproduct.GetAll();
            return null;
        }

        [HttpGet("{id}")]
        public Product Get()
        {
            //_iproduct.Get();
            return null;
        }

        [HttpDelete("{id}")]
        public void Delete()
        {
            //_iproduct.Delete();
        }
    }
}
