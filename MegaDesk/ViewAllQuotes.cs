using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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
                dataGridView1.DataSource = lstQuote.Select(quote => new
                {
                    Name = quote.CustomerName,
                    Date = quote.dateTime.ToString("yyyy-MM-dd"),
                    Width = quote.desk.Width,
                    Depth = quote.desk.Depth,
                    Drawers = quote.desk.NumberOfDrawers,
                    Material = quote.desk.SurfaceMaterial,
                    RushDays = DeskQuote.GetEnumDescription(quote.RushDays),
                    Price = quote.GetTotalPrice().ToString("c")
                })
                    .ToList();
                dataGridView1.Columns["RushDays"].HeaderText = "Rush Days";

            }
            catch (Exception ex)
            {
                //Ignored
            }
        }
    }
}
