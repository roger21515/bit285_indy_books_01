using System;
namespace IndyBooks.ViewModels
{
    public class SearchViewModel
    {
        public String Title { get; set; }

        //TODO:? Add properties needed for searching, Author's LastName, PriceLow, PriceHigh
        public string AuthorLastName { get; set; }
        public decimal MinimumPrice { get; set; }
        public decimal MaximumPrice { get; set; }


    }
}
