using Microsoft.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace HarryAPI
{
    public class BasketBook
    {
        private List<Book> _books;
        private int[] _discounts;
        private int _unitPrice;
        public BasketBook(List<Book> selectedBook, int[] discounts, int unitPrice)
        {
            _books = selectedBook;
            _discounts = discounts;
            _unitPrice = unitPrice;
        }

        public float CalculateBasketCost()
        {
            float basketCost = 0;

            // select distinct books 
            // calculate the relative discount getting the relative index from the array
            // ex 3 books = (3 -2 ) = index array => 1 = >10%
            // get the total amount of books on the list and - the disctinct values 
            // moltiply the diffence for the base price 

            // if value == 1 there's no discount
            int numberOfBooksInBasket = _books.Count;
            if (numberOfBooksInBasket == 1)
                return _unitPrice;

            // enter here only when > 1
            var numberOfDistinctBooks = _books.GroupBy(b => b.title).Count();
            if (numberOfDistinctBooks == 1)
                return _unitPrice * numberOfBooksInBasket;

            //  var discountSelector = GetDiscountPercentage(numberOfBooksInBasket > _discounts.Count()) ? (_discounts.Count() -1) : (numberOfBooksInBasket - 2) ;
            float discountPerc = GetDiscountPercentage(numberOfBooksInBasket);
            float unitDiscountedPrice = _unitPrice * ((float)(100 - discountPerc) / 100);
            float costDiscoutedBooks = numberOfDistinctBooks * unitDiscountedPrice;

            var numberOfBookNotSubjectToDiscount = numberOfBooksInBasket - numberOfDistinctBooks;
            var costNotDiscoutedBooks = numberOfBookNotSubjectToDiscount * _unitPrice;

            basketCost = (float)(costDiscoutedBooks + costNotDiscoutedBooks);

      
            return basketCost;

        }

        private float GetDiscountPercentage(int numberOfBooksInBasket)
        {
            var discountSelector = (numberOfBooksInBasket > _discounts.Count()) ? (_discounts.Count() - 1) : (numberOfBooksInBasket - 2);
            return _discounts[discountSelector];
        }
    }
}
