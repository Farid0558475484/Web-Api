using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private List<Product> products = new()
        {
            new(){Id=1,Name="Product1",SalePrice=111},
            new(){Id=2,Name="Product2",SalePrice=222},
            new(){Id=3,Name="Product3",SalePrice=333},
            new(){Id=4,Name="Product4",SalePrice=444},
            new(){Id=5,Name="Product5",SalePrice=555}
        };
        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(products);
        }
    }
}
