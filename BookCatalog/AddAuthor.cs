using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCatalog
{
    public partial class AddAuthor : Form 
    {
        public AddAuthor()
        {
            InitializeComponent();
        }
        
        AuthorRepository authorrepo = new AuthorRepository();

        Author author = new Author();

        private void AddAuthorSubmitButton_Click(object sender, EventArgs e)
        {           
            author.Author_Name = TextBoxName.Text;

            author.Nationality = TextBoxNationality.Text;

            author.Gender = TextBoxGender.Text;

            try
            {
                authorrepo.AddAuthor(author);

                MessageBox.Show("Author Added Successfully and the ID of the Author is ; " + author.Id);
            }
            catch (Exception ex) {

                MessageBox.Show(ex.ToString());
            } 
            Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
