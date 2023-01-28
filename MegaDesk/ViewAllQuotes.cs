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
                string fileJson = File.ReadAllText(@"C:\Users\Arturo\Documents\GitHub\CIT365-W2023-TEAM-CUMORAH\MegaDesk\bin\Debug\files\quotes.json");
                List<Datamodel> lst = JsonConvert.DeserializeObject<List<Datamodel>>(fileJson);
                List<DatamodelDesk> lst2 = JsonConvert.DeserializeObject<List<DatamodelDesk>>(fileJson);

                dataGridView1.DataSource = lst;
                dataGridView2.DataSource = lst2;

            }
            catch (Exception ex)
            {
                //Ignored
            }
        }
    }
}
