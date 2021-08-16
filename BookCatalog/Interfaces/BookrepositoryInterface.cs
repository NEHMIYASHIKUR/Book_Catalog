using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog
{
    public interface BookrepositoryInterface
    {
        Book AddBook(Book book);

        IEnumerable<Book> GetBooks();

        Book DeleteBook(int id);

        List<Book> SearchBook(String SearchInput);

        IEnumerable GetAllBooks();

        bool commit();
      
    }
}
