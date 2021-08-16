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
    public partial class DisplayBookscs : Form
    {
        public DisplayBookscs()
        {
            InitializeComponent();         
        }

        BookRepository bookrepository = new BookRepository();
        AuthorRepository authorRepository = new AuthorRepository();

        private void DisplayBookscs_Load(object sender, EventArgs e)
        {         
            try
            {
                var Data = bookrepository.GetAllBooks();
                GridView.DataSource = Data;
              
            }
            catch (Exception ex) {
                MessageBox.Show("Something is wrong: " + ex.ToString());
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
          //  bookrepository.SearchInput = SearchInputTextBox.Text;
            String Searchinput = SearchInputTextBox.Text;

            try
            {
                if (SearchInputTextBox.Text == "")
                {
                    GridView.DataSource = bookrepository.GetAllBooks();
                }
                else
                {
                    GridView.DataSource = bookrepository.SearchBook(Searchinput);
                } 
            }
            catch (NpgsqlException Ex) {
                MessageBox.Show("Something is wrong: " + Ex.ToString());
            }
                      
        }

            private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {

           // bookrepository.SelectedRowId = GridView.CurrentRow.Cells[0].Value.ToString();
           var Selected_Book_Id = GridView.CurrentRow.Cells[0].Value.ToString();

            try
            {
                bookrepository.DeleteBook(int.Parse(Selected_Book_Id));
                MessageBox.Show("Book removed successfully");
            }
            catch (NpgsqlException ex) {

                MessageBox.Show("Something is Wrong: " + ex.ToString());
            }
            GridView.DataSource = bookrepository.GetAllBooks();
        }
    }
}
