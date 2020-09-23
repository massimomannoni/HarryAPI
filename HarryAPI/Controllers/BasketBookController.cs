using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarryAPI.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace HarryAPI.Controllers
{
    public class BasketBookController : Controller
    {
      
        [HttpGet]


        [HttpPost]
        public double PostBasket([FromBody] ShoppingBasketRequest request)
        {
            return 2;
        }
    }
}
