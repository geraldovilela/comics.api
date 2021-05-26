using comics.api.Data.Entities;
using comics.api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace comics.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private IProduct _iproduct;
        public ProductsController(IProduct iproduct)
        {
            _iproduct = iproduct;
        }

        [HttpPost]
        public Product Create()
        {
            return null;
        }
    }
}
