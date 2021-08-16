using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCatalog
{
   public class AuthorRepository : AuthorRepositoryInterface
    {
        Context context = new Context();

        public String SelectedRowAuthorId;

        public Author AddAuthor(Author author)
        {
            context.Authors.Add(author);
            commit();
            return author;
        }

        public List<int> GetAuthorId()
        {
            var query = context.Authors.Select(x => x.Id).ToList();
            return query;
        }

        public IEnumerable<Author> GetAuthors()
        {
            var test = context.Authors;
            return test;
        }

        public Author DeleteAuthor(int id)
        {
            var query = context.Authors.Find(id);
            if (query != null)
            {
                context.Authors.Remove(query);
                commit();                
            }
            return query;
        }

        public bool commit()
        {
            context.SaveChanges();
            return true;
        }



    }
}
