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
    public partial class AddJournals : Form
    {
        Stock storageJournals = new Stock();

        public AddJournals()
        {
            InitializeComponent();
        }

        private void btnReturnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login LoginBooksScreen = new Login();
            LoginBooksScreen.ShowDialog();
        }

        private void btnAddJournal_Click(object sender, EventArgs e)
        {
            try
            {
                Journal journal0 = new Journal(txtTitle.Text, int.Parse(txtYearPrinted.Text), txtAuthor.Text, txtPublisher.Text,
                    double.Parse(txtPrice.Text), int.Parse(txtID.Text));

                storageJournals.AddJournal(journal0, int.Parse(txtQuanityChange.Text));

                //add so can search in books
                SearchBooks storageBooks = new SearchBooks(storageJournals);
            }
            catch (Exception en)
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

        private void btnTest1_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "before medicine";
            txtYearPrinted.Text = "2000";
            txtAuthor.Text = "joe";
            txtPublisher.Text = "medical";
            txtPrice.Text = "10.32";
            txtID.Text = " 1";
            txtQuanityChange.Text = "4";
        }

        private void btnTest2_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "after medicine";
            txtYearPrinted.Text = "2001";
            txtAuthor.Text = "sam";
            txtPublisher.Text = "medical";
            txtPrice.Text = "7.6";
            txtID.Text = " 2";
            txtQuanityChange.Text = "2";
        }

        private void btnSearchJournals_Click(object sender, EventArgs e)
        {
            SearchJournals SearchJournalsScreen = new SearchJournals(storageJournals);
            SearchJournalsScreen.Show();
        }
    }
}
