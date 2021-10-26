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
    
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            Manager ManagerScreen = new Manager();
            ManagerScreen.ShowDialog();
        }

        private void btnAddJournals_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddJournals AddJournalsScreen = new AddJournals();
            AddJournalsScreen.ShowDialog();
        }

       
    }
}
