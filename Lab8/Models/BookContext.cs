using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; } //Представляет таблицу книг в базе данных

        public DbSet<Purchase> Purchases { get; set; } //Представляет таблицу покупок в базе данных
    }
}