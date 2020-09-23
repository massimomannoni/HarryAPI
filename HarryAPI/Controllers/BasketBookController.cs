using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarryAPI.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace HarryAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasketBookController : Controller
    {
      
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpPost]
        public double PostBasket([FromBody] ShoppingBasketRequest request)
        {
            BasketBook basketBook = new BasketBook(request.shoppingBasket, request.discountAvailable, request.unitPrice);

            return basketBook.CalculateBasketCost();

        }
    }
}
