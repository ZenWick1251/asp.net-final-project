using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using final_project_asp.net.Models;
using Microsoft.AspNetCore.Mvc;

namespace final_project_asp.net.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class ProductController :ControllerBase
    {
        

        [HttpGet("{id}")]
        public Products GetProduct(int id) {
            return new Products{
                Id = id,
                Name = "Coca cola",
                Price = 111,

            };
        }
    }


}