using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Books.Library.Models;

namespace Books.Library.DAL
{
    public class BookInitializer : DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var books = new List<Book>
            {
                new Book { BookTitle = "Heart of Darkness" },
                new Book { BookTitle = "Lord Jim" },
                new Book { BookTitle = "The Secret Agent" },
                new Book { BookTitle = "Nostrommo" }
            };
            books.ForEach(b => context.Books.Add(b));
            context.SaveChanges();
        }
    }
}
