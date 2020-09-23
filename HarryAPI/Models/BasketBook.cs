using System;
using System.Collections.Generic;
using System.Linq;

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

        public double CalculateBasketCost()
        {
            double basketCost = 0;

            // select distinct books 
            // calculate the relative discount getting the relative index from the array
            // ex 3 books = (3 -2 ) = index array => 1 = >10%
            // get the total amount of books on the list and - the disctinct values 
            // moltiply the diffence for the base price 

            // if value == 1 there's no discount
            int numberOfBooksInBasket = _books.Count;
            if (numberOfBooksInBasket == 1)
            {
                basketCost = _unitPrice;
            }
            else
            {
                // enter here only when > 1
                var numberOfDistinctBooks = _books.GroupBy(b => b.title).ToList();


                // check correct index
                int discount = _discounts[numberOfDistinctBooks.Count - 2];
                double costDiscoutedBooks = (((numberOfDistinctBooks.Count * _unitPrice) * (100 - discount)) / 100);

                var numberOfBookNotSubjectToDiscount = numberOfBooksInBasket - numberOfDistinctBooks.Count();
                var costNotDiscoutedBooks = numberOfBookNotSubjectToDiscount * _unitPrice;

                basketCost = costDiscoutedBooks + costNotDiscoutedBooks;

            }

            return basketCost;

        }
    }
}
