using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu formMainMenu = (MainMenu)Tag;
            formMainMenu.Show();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            try
            {
                string fileJson = File.ReadAllText(@"files\quotes.json");
                List<DeskQuote> lstQuote = JsonConvert.DeserializeObject<List<DeskQuote>>(fileJson);
                dataGridView1.DataSource = lstQuote;

            }
            catch (Exception ex)
            {
                //Ignored
                Console.WriteLine(ex.Message);
            }
        }
    }
}
