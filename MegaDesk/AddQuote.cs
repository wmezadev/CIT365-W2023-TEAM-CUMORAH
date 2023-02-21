using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            // Set current Date in label
            DateTime dateTime = DateTime.Now;
            labelCurrentDate.Text = dateTime.ToString("dd/MM/yyyy");

            // SET MAX, MINS and Defaults
            numericUpDownWidth.Maximum = Desk.MAX_WIDTH;
            numericUpDownWidth.Minimum = Desk.MIN_WIDTH;
            numericUpDownWidth.Value = Desk.MIN_WIDTH;

            numericUpDownDepth.Maximum = Desk.MAX_DEPTH;
            numericUpDownDepth.Minimum = Desk.MIN_DEPTH;
            numericUpDownDepth.Value = Desk.MIN_DEPTH;

            numericUpDownDrawers.Maximum = Desk.MAX_DRAWER_NUMBER;
            numericUpDownDrawers.Minimum = Desk.MIN_DRAWER_NUMBER;
            numericUpDownDrawers.Value = Desk.MIN_DRAWER_NUMBER;

            List<Desk.DesktopMaterial> surface_materials = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();
            // Populate combo box with Surface list
            comboBoxMaterial.DataSource = surface_materials;
            comboBoxMaterial.SelectedIndex = -1;

            List<DeskQuote.RUSH_DAYS> rush_days_options_list = Enum.GetValues(typeof(DeskQuote.RUSH_DAYS)).Cast<DeskQuote.RUSH_DAYS>().ToList();
            List<string> rushOptions = new List<string>();
            for (int i = 0; i < rush_days_options_list.Count; i++)
            {
                string rushOption = DeskQuote.GetEnumDescription((DeskQuote.RUSH_DAYS) i);
                rushOptions.Add(rushOption);
            }
            // Populate combo box with Rush days list
            comboBoxRush.DataSource = rushOptions;
            comboBoxRush.SelectedIndex = -1;
        }
        private void buttonCancelQuote_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu formMainMenu = (MainMenu)Tag;
            formMainMenu.Show();
        }
        public bool IsValidAddQuoteForm()
        {
            try
            {
                if (string.IsNullOrEmpty(textBoxCustomer.Text))
                {
                    throw new Exception("Customer name should not be empty");
                }
                else if (comboBoxMaterial.SelectedIndex == -1)
                {
                    throw new Exception("You must select a Surface Material");
                }
                else if (comboBoxRush.SelectedIndex == -1)
                {
                    throw new Exception("You must select a Rush Day");
                } else
                {
                    return true;
                }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Error");
                return false;
            }
        }

        private void buttonSaveQuote_Click(object sender, EventArgs e)
        {
            if (!IsValidAddQuoteForm())
            {
                return;
            }
            Desk desk = new Desk((int) numericUpDownWidth.Value, (int) numericUpDownDepth.Value, (int) numericUpDownDrawers.Value, (Desk.DesktopMaterial) comboBoxMaterial.SelectedItem);
            DeskQuote deskQuote = new DeskQuote(desk, textBoxCustomer.Text, (DeskQuote.RUSH_DAYS) comboBoxRush.SelectedIndex);

            DisplayQuote formDisplayQuote = new DisplayQuote(deskQuote);
            try
            {
                if (File.Exists("files/quotes.json"))
                {
                    string oldJson = File.ReadAllText("files/quotes.json");
                    List<DeskQuote> displayQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(oldJson);
                    displayQuotes.Add(deskQuote);

                    string json = JsonConvert.SerializeObject(displayQuotes, Formatting.Indented);

                    File.WriteAllText("files/quotes.json", json);

                }else
                {
                    //when there is not json created we have to use the only quote that we have
                    List<DeskQuote> deskQuotes = new List<DeskQuote> { deskQuote };
                    string json = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);

                    File.WriteAllText("files/quotes.json", json);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
               
            }

            // Pass This Tag
            formDisplayQuote.Tag = this.Tag;
            formDisplayQuote.Show(this);
            Hide();
        }

       
    }
}
