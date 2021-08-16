using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCatalog
{

    public class Book
    {
        public int Id { get; set; }

        public String Title { get; set; }

        public int Author_Id { get; set; }

        [ForeignKey("Author_Id")]
        public Author Author { get; set; }

        public String Release_Date { get; set; }

        public String price { get; set; }

        public int Quantity { get; set; }
    }
}
