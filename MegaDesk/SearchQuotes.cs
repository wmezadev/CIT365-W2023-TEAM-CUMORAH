using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk.DeskQuote;

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

            // List<Desk.DesktopMaterial> surface_materials2 = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();
            //List<Desk.DesktopMaterial> x = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();
            //label1.Text = ;
        }
        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu formMainMenu = (MainMenu)Tag;
            formMainMenu.Show();
        }

        private void comboBoxMaterialSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string materials = comboBoxMaterialSearch.Text; /// NECESITO CONSEGUIR EL VALOR DE LA VARIABLE MATERIALS QUE ES EL NOMBRE DEL MATERIAL
            try
            {
                string fileJson = File.ReadAllText(@"files\quotes.json");
                List<DeskQuote> lstQuote = JsonConvert.DeserializeObject<List<DeskQuote>>(fileJson);
               
               DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[7] 
                    {   new DataColumn("Date and Time", typeof(DateTime)), 
                        new DataColumn("Customer Name", typeof(string)), 
                        new DataColumn("Rush Date", typeof(DeskQuote.RUSH_DAYS)),
                        new DataColumn("Width", typeof(int)),
                        new DataColumn("Depth", typeof(int)),
                        new DataColumn("Number of Drawers", typeof(int)),
                        new DataColumn("Surface Material", typeof(int)),
                    });

                for (int i = 1; i < lstQuote.Count; i++)
                {
                    if (lstQuote[i].SurfaceMaterial == Convert.ToInt32(materials)) // AQUI VA A IR EL STRING materials PARA COMPARAR LA SUPERFICIE DEL MATERIAL
                    {
                       dt.Rows.Add(lstQuote[i].dateTime, lstQuote[i].CustomerName, lstQuote[i].RushDays, lstQuote[i].Width, lstQuote[i].Depth, lstQuote[i].NumberOfDrawers, lstQuote[i].SurfaceMaterial);
                    
                    }
                   
                }

                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                //Ignored
            }
        }
    }
}
