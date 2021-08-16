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
    public partial class AuthorsInfo : Form
    {
        public AuthorsInfo()
        {
            InitializeComponent();
        }

        AuthorRepository authorrepository = new AuthorRepository();

        private void AuthorsInfo_Load(object sender, EventArgs e)
        {
            var data = authorrepository.GetAuthors().ToList();
            AuthorsInfoGridView.DataSource = data;
        }

        private void AuthorDeleteButton_Click(object sender, EventArgs e)
        {
            var Selected_Author_Id = AuthorsInfoGridView.CurrentRow.Cells[0].Value.ToString();
            authorrepository.DeleteAuthor(int.Parse(Selected_Author_Id));
            MessageBox.Show("Author deleted Successfully");

            AuthorsInfoGridView.DataSource = authorrepository.GetAuthors().ToList();

        }
    }
}
