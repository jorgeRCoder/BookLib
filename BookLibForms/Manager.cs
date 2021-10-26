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
    public partial class Manager : Form
    {
        Stock storageManager = new Stock();

        public Manager()
        {
            InitializeComponent();   
        }
       
        private void btnReturnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginBooksScreen = new Login();
            LoginBooksScreen.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs a)
        {
            try
            {
                //Book.Genre genre = (Book.Genre)Enum.Parse(typeof(Book.Genre), combxGenre.Text);
                Book book0 = new Book(txtTitle.Text, int.Parse(txtYearPrinted.Text), txtAuthor.Text, txtPublisher.Text,
                    double.Parse(txtPrice.Text), int.Parse(txtEdition.Text), combxGenre.Text, int.Parse(txtISBN.Text));

                storageManager.AddBook(book0, int.Parse(txtQuanityChange.Text));

                //add so can search in books
                 SearchBooks storageBooks = new SearchBooks(storageManager);
            }
            catch (Exception e)
            {
                //if (
                //   string.IsNullOrWhiteSpace(txtTitle.Text)
                //|| int.Parse(txtYearPrinted.Text) < 500
                //|| string.IsNullOrWhiteSpace(txtAuthor.Text)
                //|| string.IsNullOrWhiteSpace(txtPublisher.Text)
                //)
                    MessageBox.Show("Fill all files Properly");
            }
        }
       
        private void txtYearPrinted_KeyPress(object sender, KeyPressEventArgs e)
        {         
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPriceMin_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtQuanityChange_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))
        && (e.KeyChar != '.') && (e.KeyChar != '-'))
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;

            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            StringBuilder booksList = new StringBuilder();
            foreach (var item in storageManager.BooksList)
            {
                booksList.AppendLine($"{item} ");               
            }
          
            Inventory inv = new Inventory(booksList.ToString());
            inv.Show();           
        }

        private void btnTest1_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "before the era";
            txtYearPrinted.Text = "2020";
            txtAuthor.Text = "me1";
            txtPublisher.Text = "hill";
            txtPrice.Text = "1.1";
            txtEdition.Text = "1";
            combxGenre.Text = "Computers";
            txtISBN.Text = " 1";
            txtQuanityChange.Text = "1";
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "after";
            txtYearPrinted.Text = "2020";
            txtAuthor.Text = "dfgdfg";
            txtPublisher.Text = "hill";
            txtPrice.Text = "1.1";
            txtEdition.Text = "1";
            combxGenre.Text = "Computers";
            txtISBN.Text = " 2";
            txtQuanityChange.Text = "2";
        }

        private void btnScreenSearchBooks_Click(object sender, EventArgs e)
        {

            SearchBooks SearchBooksScreen = new SearchBooks(storageManager);
            SearchBooksScreen.Show();
        }
    }
}
