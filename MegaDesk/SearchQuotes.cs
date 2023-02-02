using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            List<Desk.DesktopMaterial> surface_materials = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();
            // Populate combo box with Surface list
            comboBoxMaterialSearch.DataSource = surface_materials;
            comboBoxMaterialSearch.SelectedIndex = -1;
        }
        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu formMainMenu = (MainMenu)Tag;
            formMainMenu.Show();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            try
            {
                string fileJson = File.ReadAllText(@"files\quotes.json");
                List<DeskQuote> lstQuote = JsonConvert.DeserializeObject<List<DeskQuote>>(fileJson);
                // populate data grid with JSON data
                dataGridView1.DataSource = lstQuote
                    .Select(quote => new
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
                // No results
            }
        }

        private void comboBoxMaterialSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Desk.DesktopMaterial selectedMaterial = (Desk.DesktopMaterial) Convert.ToInt32(comboBoxMaterialSearch.SelectedItem);
                string fileJson = File.ReadAllText(@"files\quotes.json");
                List<DeskQuote> lstQuote = JsonConvert.DeserializeObject<List<DeskQuote>>(fileJson);
                dataGridView1.DataSource = lstQuote
                    .Select(quote => new
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
                    .Where(quote => quote.Material == selectedMaterial)
                    .ToList();
                dataGridView1.Columns["RushDays"].HeaderText = "Rush Days";
            }
            catch (Exception ex)
            {
                // No results
            }
        }
    }
}
