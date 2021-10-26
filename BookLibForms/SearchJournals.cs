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
    public partial class SearchJournals : Form
    {
        Stock storageJournals = new Stock();

        public SearchJournals()
        {
            InitializeComponent();
        }

        public SearchJournals(Stock listJournals)
        {
            InitializeComponent();
            this.storageJournals = listJournals;
        }

        private void btnReturnAddJour_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddJournals AddJourScreen = new AddJournals();
            AddJourScreen.ShowDialog();
        }

        private void btnSearchJournals_Click(object sender, EventArgs e)
        {
            StringBuilder journalsSearchList = new StringBuilder();

            if (txtYearPrinted.Text == "") { txtYearPrinted.Text = "0"; }
            if (txtPrice.Text == "") { txtPrice.Text = "0"; }
            if (txtID.Text == "") { txtID.Text = "0"; }

            //Book.Genre genre = (Book.Genre)Enum.Parse(typeof(Book.Genre), combxGenre.Text);

            foreach (var item in storageJournals.SearchJournals2
                (txtTitle.Text,
                int.Parse(txtYearPrinted.Text),
                txtAuthor.Text,
                txtPublisher.Text,
                double.Parse(txtPrice.Text),
                int.Parse(txtID.Text)
                  ))
            {
                journalsSearchList.AppendLine($"{item} ");
            }

            lblResult.Text = journalsSearchList.ToString();

            if (txtYearPrinted.Text == "0") { txtYearPrinted.Text = ""; }
            if (txtPrice.Text == "0") { txtPrice.Text = ""; }
            if (txtID.Text == "0") { txtID.Text = ""; }
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
