using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HarryAPI.Controllers
{
    public class BasketBookController : Controller
    {
      

        [HttpPost]
        public Task<double> PostBasket([FromBody] basketRequest request)
        {
            
        }
    }
}
