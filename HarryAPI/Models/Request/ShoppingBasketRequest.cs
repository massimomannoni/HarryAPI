using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HarryAPI.Models.Request
{
    public class ShoppingBasketRequest
    {
        [Required]
        public List<Book> shoppingBasket { get; set; }

        [Required]
        public  int[] discountAvailable { get; set; }

        [Required]
        public int unitPrice { get; set; }
    }
}
