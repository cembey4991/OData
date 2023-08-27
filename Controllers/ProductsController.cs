using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using OData.Models;

namespace OData.Controllers
{
  [ApiController]
[Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [EnableQuery]
        [HttpGet]
        public ActionResult<List<Product>> Get()
        {
            var product = new List<Product>(){
          new Product(){
            Id = 1,
            Name = "Product 1",
            Price = 100
          },
          new Product(){
            Id = 2,
            Name = "Product 2",
            Price = 200
          },
          new Product(){
            Id = 3,
            Name = "Product 3",
            Price = 300
          },

        };
        return Ok(product);
        }
    }
}