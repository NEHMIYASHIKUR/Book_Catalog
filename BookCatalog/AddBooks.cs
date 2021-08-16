using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace BookCatalog
{
    public partial class AddBooks : Form
    { 
        public AddBooks()
        {
            InitializeComponent();
            foreach (var Id in authorrepository.GetAuthorId())
            {
                ComboBox.Items.Add(Id);
            }
        }

        AuthorsInfo authorsinfo = new AuthorsInfo();
        AddAuthor addauthor = new AddAuthor();
        BookRepository bookrepository = new BookRepository();
        AuthorRepository authorrepository = new AuthorRepository();

        Book book = new Book();
        Author author = new Author();

        

        private void button1_Click(object sender, EventArgs e)
        {
               book.Title = TextBoxTitle.Text;
              
               book.Release_Date =TextBoxReleaseDate.Text;

               book.price =TextBoxPrice.Text;  

               book.Quantity =int.Parse(TextBoxQuantity.Text);

               book.Author_Id = int.Parse(ComboBox.Text);

            //  book.Author = authorrepository.AssignAuthorId();

            if (TextBoxTitle.Text=="" || TextBoxReleaseDate.Text == ""|| TextBoxPrice.Text == ""|| TextBoxQuantity.Text == "")
            {
                MessageBox.Show("Plase fill all the fields");
            }
            else
            { 
                bookrepository.AddBook(book);
                
                MessageBox.Show("Book Added Successfully");
            }

            cleartextbox();
        }

        private void cleartextbox()
        {
            TextBoxTitle.Clear();
            TextBoxReleaseDate.Clear();
            TextBoxPrice.Clear();
            TextBoxQuantity.Clear();
        }

        private void GoToAddAuthorButton_Click(object sender, EventArgs e)
        {
            addauthor.ShowDialog();
        }

        private void GoToAuthors_Click(object sender, EventArgs e)
        {
            authorsinfo.ShowDialog();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
