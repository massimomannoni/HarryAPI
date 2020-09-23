using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryAPI.Models.Request
{
    public class ShoppingBasketRequest
    {
        List<Book> shoppingBasket;

        int[] discountAvailable;
    }
}
