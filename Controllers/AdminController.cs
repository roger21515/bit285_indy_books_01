using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using IndyBooks.Data;
using IndyBooks.Models;
using IndyBooks.ViewModels;


namespace IndyBooks.Controllers
{
    public class AdminController : Controller
    {
        private IndyBooksDataContext _dbc;
        private ResultsViewModel results;
        public AdminController(IndyBooksDataContext db) { _dbc = db; }

        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(SearchViewModel searchVM)
        {
            // Add the entire set of books to the Results View Model
            // in case no search value was entered, return the whole list
            results = new ResultsViewModel { BookList = _dbc.Books };

            //Filter the collection using each non-empty Field as noted
            if (searchVM.Title != null)
            {
                //Update the collectio, filter by Title which "contains" the submitted string 
                //(Note: search.Title is the info from the form)
                
                results.BookList = results.BookList
                             .Where(b => b.Title.Contains(searchVM.Title) )
                             ;
                // TODO: order the above results by year, starting with the newest


            }

            //TODO: Filter the collection by last part of the Author's Name, if given
            // (HINT: Use a string method that matches the end of the string,
            //        also you will need to adjust the Search View and ViewModel to collect Author name)



            //TODO: Filter the collection by items with prices above a low and below a high value, if given
            // (Note: you will need to adjust the Search ViewModel and View to add search fields)


            
            // TODO: only include the first 5 books in the SearchResults view


            return View("SearchResults", results);
        }
    }
}
