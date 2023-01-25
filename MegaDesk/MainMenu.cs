using System;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        private void AddNewQuoteNav_Click(object sender, EventArgs e)
        {
            AddQuote formAddQuote = new AddQuote();
            formAddQuote.Tag = this;
            formAddQuote.Show(this);
            Hide();
        }

        private void ViewNewQuoteNav_Click(object sender, EventArgs e)
        {
            ViewAllQuotes formViewAllQuotes = new ViewAllQuotes();
            formViewAllQuotes.Tag = this;
            formViewAllQuotes.Show(this);
            Hide();
        }

        private void SearchQuotesNav_Click(object sender, EventArgs e)
        {
            SearchQuotes formSearchQuotes = new SearchQuotes();
            formSearchQuotes.Tag = this;
            formSearchQuotes.Show(this);
            Hide();
        }

        private void ExitNav_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
