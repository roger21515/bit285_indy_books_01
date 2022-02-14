using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using IndyBooks.Models;

namespace IndyBooks.Data
{
    public class IndyBooksDataContext:DbContext
    {
        public IndyBooksDataContext(DbContextOptions<IndyBooksDataContext> options) : base(options)
        {
            Database.EnsureCreated();
            
        }

        //Access to Collections representing DB tables
        public DbSet<Book> Books { get; set; }

    }
}
