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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        AddBooks addBooks = new AddBooks();
        DisplayBookscs displaybooks = new DisplayBookscs();
        private void button2_Click(object sender, EventArgs e)
        {
            addBooks.ShowDialog();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            displaybooks.ShowDialog();
        }
    }
    
}
