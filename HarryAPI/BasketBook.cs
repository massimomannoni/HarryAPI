using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarryAPI
{
    public class BasketBook
    {
        private List<Book> _books;
        private int[] _discounts;
        public BasketBook(List<Book> selectedBook, int[] discounts)
        {
            _books = selectedBook;
            _discounts = discounts;
        }

        public double CalculateBasketCost()
        {
            int basketCost = 0;


            // select distinct books 
            // calculate the relative discount getting the relative index from the array
            // ex 3 books = (3 -2 ) = index array => 1 = >10%
            // get the total amount of books on the list and - the disctinct values 
            // moltiply the diffence for the base price 

            // if value == 1 there's no discount
            int numberOfBooksInBasket = _books.Count;
            if (numberOfBooksInBasket == 1)
            {
                basketCost = _books.First().price;
            }
            else
            {
                // enter here only when > 1
                var numberOfDistinctBooks = _selectedBook.Distinct().ToList();
                var costDiscoutedBooks = (numberOfDistinctBooks.Count * price);

                var numberOfBookNotSubjectToDiscount = numberOfBasketBooks - numberOfDistinctBooks.Count();
                var costNotDiscoutedBooks = numberOfBookNotSubjectToDiscount * price;

                basketCost = costDiscoutedBooks + costNotDiscoutedBooks;

            }

            return basketCost;

        }
    }
}
