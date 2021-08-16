using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog
{
    public interface AuthorRepositoryInterface
    {
        Author AddAuthor(Author author);

        List<int> GetAuthorId();

        IEnumerable<Author> GetAuthors();

        Author DeleteAuthor(int id);

        bool commit();
   
    }
}
