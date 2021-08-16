using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookCatalog
{
   public class BookRepository : BookrepositoryInterface
    {
        Context context = new Context();

        public Book AddBook(Book book)
        {
            context.Books.Add(book);
            commit();
            return book;
        }

        public IEnumerable<Book> GetBooks()
        {
            var query = context.Books;

            return query;
        }

        public Book DeleteBook(int id)
        {
            var query = context.Books.Find(id);
            if (query != null)
            {
                context.Books.Remove(query);
                commit();
            }

            return query;
        }

        public List<Book> SearchBook(String SearchInput)
        {
            List<Book> data = context.Books.Where(x => x.Title.Contains(SearchInput) || x.Release_Date.Contains(SearchInput) || x.price.Contains(SearchInput)).ToList();
            return data;
        }

        public IEnumerable GetAllBooks()
        {
            var query = context.Books.Select(c => new
            {
                c.Id,
                c.Title,
                c.Author.Author_Name,
                c.Author.Nationality,
                c.Release_Date,
                c.price,
                c.Quantity
            }).ToList();
            return query;
        }

        public bool commit()
        {
            context.SaveChanges();
            return true;
        }
    }
}
