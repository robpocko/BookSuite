using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Books.Library.DAL;
using Books.Library.Models;

namespace BookService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class BookService : IBookService
    {
        public List<Book> GetBooksList()
        {
            using (BookContext context = new BookContext())
            {
                return context.Books.ToList();
            }
        }

        public Book GetBookById(int id)
        {
            try
            {
                using (BookContext context = new BookContext())
                {
                    return context.Books.SingleOrDefault(book => book.ID == id);
                }
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public void AddBook(string title)
        {
            using (BookContext context = new BookContext())
            {
                Book book = new Book { BookTitle = title };
                context.Books.Add(book);
                context.SaveChanges();
            }
        }

        public void UpdateBook(int id, string title)
        {
            try
            {
                using (BookContext context = new BookContext())
                {
                    Book book = context.Books.SingleOrDefault(b => b.ID == id);
                    book.BookTitle = title;
                    context.SaveChanges();
                }
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public void DeleteBook(int id)
        {
            try
            {
                using (BookContext context = new BookContext())
                {
                    Book book = context.Books.SingleOrDefault(b => b.ID == id);
                    context.Books.Remove(book);
                    context.SaveChanges();
                }
            }
            catch
            {
                throw new FaultException("Something went wrong");
            }
        }

        public string TestMe()
        {
            return string.Format("BookService called at {0}", DateTime.Now.ToString("dd MMM yyyy HH:mm"));
        }
    }
}
