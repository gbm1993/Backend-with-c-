using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplicationMysql.DbContext;
using WebApplicationMysql.Models;

namespace WebApplicationMysql.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class BookController : ApiController
    {
        // GET: api/Book
        public IEnumerable<Book> Get()
        {
            Library library = new Library();
            var list = library.libraryContext.Books.ToList();
            return list;
            
        }

        // GET: api/Book/5
        public Book Get(int id)
        {
            Library library = new Library();
            var book = library.libraryContext.Books.SingleOrDefault(a=>a.BookId == id);
            return book;
            
        }
        // GET: api/Book/5
        public Book Get(String bkname)
        {
            Library library = new Library();
            var book = library.libraryContext.Books.SingleOrDefault(a => a.Name ==bkname);
            return book;

        }

        // POST: api/Book
        public bool Post(Book value)
        {
            try
            {
                Library library = new Library();
                library.libraryContext.Books.Add(value);
                library.libraryContext.SaveChanges();
                return true;
            }
            catch(Exception )
            {
                return false;
            }
        }

        // PUT: api/Book/5
        public bool Put(int id ,Book value)
        {
            
            try
            {
                Library library = new Library();
                Book book = library.libraryContext.Books.Add(value);
                library.libraryContext.Entry(value).State = System.Data.Entity.EntityState.Modified;
                //book.Name = value.Name;
                //book.Author = value.Author;
                //book.Publication = value.Publication;
                //book.Price = value.Price;
                library.libraryContext.SaveChanges();

                //ctx.Books.Add(myBook);
                //ctx.Entry(myBook).State = EntityState.Modified;
                //ctx.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }

        // DELETE: api/Book/5
        public bool Delete(int id)
        {
            try
            {
                Library library = new Library();
                Book book = library.libraryContext.Books.Where(c => c.BookId == id).FirstOrDefault();
                library.libraryContext.Books.Remove(book);
                library.libraryContext.SaveChanges();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
        }
    }
}
