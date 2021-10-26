using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookLib;

namespace BookLibForms
{
    public enum Status { Active = 0, Canceled = 3 };
    public partial class SearchBooks : Form
    {
        Stock storageBooks = new Stock();
        // Book book1 = new Book("before the era", 2020, "me1", "hill", 1.1, 1, Book.Genre.Computers, 1);


        public SearchBooks()
        {
            InitializeComponent();
            //storageBooks.AddBook(book1, 0);
        }

        public SearchBooks(Stock listBooks)
        {
            InitializeComponent();
            this.storageBooks = listBooks;
        }

        private void btnReturnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginBooksScreen = new Login();
            LoginBooksScreen.ShowDialog();
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            StringBuilder booksSearchList = new StringBuilder();

            if (txtYearPrinted.Text=="") { txtYearPrinted.Text = "0"; }
            if (txtPrice.Text == "") { txtPrice.Text = "0"; }
            if (txtEdition.Text == "") { txtEdition.Text = "0"; }
            if (txtISBN.Text == "") { txtISBN.Text = "0"; }

            //Book.Genre genre = (Book.Genre)Enum.Parse(typeof(Book.Genre), combxGenre.Text);

            foreach (var item in storageBooks.SearchBooks2
                (txtTitle.Text,
                int.Parse(txtYearPrinted.Text),
                txtAuthor.Text,
                txtPublisher.Text,
                double.Parse(txtPrice.Text),
                int.Parse(txtEdition.Text),
                combxGenre.Text,
                int.Parse(txtISBN.Text)
                  ))
            {
                booksSearchList.AppendLine($"{item} ");
            }

            lblResult.Text = booksSearchList.ToString();

            if (txtYearPrinted.Text == "0") { txtYearPrinted.Text = ""; }
            if (txtPrice.Text == "0") { txtPrice.Text = ""; }
            if (txtEdition.Text == "0") { txtEdition.Text = ""; }
            if (txtISBN.Text == "0") { txtISBN.Text = ""; }
        }

        private void btnReturnAddBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager ManagerScreen = new Manager();
            ManagerScreen.ShowDialog();
        }

        private void combxGenre_DataSourceChanged(object sender, EventArgs e)
        {
            combxGenre.DataSource= Enum.GetValues(typeof(Status));
            
        }

        private void txtYearPrinted_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
