using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data;

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
            comboBoxDrawers.SelectedIndex = 0;

            List<Desk.DesktopMaterial> surface_materials = Enum.GetValues(typeof(Desk.DesktopMaterial)).Cast<Desk.DesktopMaterial>().ToList();
            // Populate combo box with Surface list
            comboBoxMaterial.DataSource = surface_materials;
            comboBoxMaterial.SelectedIndex = -1;

            List<DeskQuote.RUSH_DAYS> rush_days_options_list = Enum.GetValues(typeof(DeskQuote.RUSH_DAYS)).Cast<DeskQuote.RUSH_DAYS>().ToList();
            List<string> rushOptions = new List<string>();
            for (int i = 0; i < rush_days_options_list.Count; i++)
            {
                string rushOption = DeskQuote.GetEnumDescription((DeskQuote.RUSH_DAYS)i);
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
                else if (string.IsNullOrEmpty(textBoxWidth.Text) || !(Convert.ToInt32(textBoxWidth.Text) >= Desk.MIN_WIDTH && Convert.ToInt32(textBoxWidth.Text) <= Desk.MAX_WIDTH))
                {
                    throw new Exception("You must give a width between " + Desk.MIN_WIDTH + " and " + Desk.MAX_WIDTH);
                }
                else if (string.IsNullOrEmpty(textBoxDepth.Text) || !(Convert.ToInt32(textBoxDepth.Text) >= Desk.MIN_DEPTH && Convert.ToInt32(textBoxDepth.Text) <= Desk.MAX_DEPTH))
                {
                    throw new Exception("You must give a depth between " + Desk.MIN_DEPTH + " and " + Desk.MAX_DEPTH);
                }
                else if (comboBoxMaterial.SelectedIndex == -1)
                {
                    throw new Exception("You must select a Surface Material");
                }
                else if (comboBoxRush.SelectedIndex == -1)
                {
                    throw new Exception("You must select a Rush Day");
                }
                else
                {
                    return true;
                }
            }
            catch (Exception exception)
            {
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
            Desk desk = new Desk(Convert.ToInt32(textBoxWidth.Text), Convert.ToInt32(textBoxDepth.Text), Convert.ToInt32(comboBoxDrawers.SelectedItem.ToString()), (Desk.DesktopMaterial)comboBoxMaterial.SelectedItem);
            DeskQuote deskQuote = new DeskQuote(desk, textBoxCustomer.Text, (DeskQuote.RUSH_DAYS)comboBoxRush.SelectedIndex);

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

                }
                else
                {
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

        private void textBoxWidth_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool isNumber = int.TryParse(textBoxWidth.Text, out int width);
            if (isNumber)
            {
                if (width.ToString().Length > 0)
                {
                    if (width < 24)
                    {
                        e.Cancel = true;
                        setErrorToField(textBoxWidth, Color.Red, "Minimum value is " + Desk.MIN_WIDTH + " inches");

                        return;
                    }
                    else if (width > 94)
                    {
                        e.Cancel = true;
                        setErrorToField(textBoxWidth, Color.Red, "Maximum value is " + Desk.MAX_WIDTH + " inches");

                        return;
                    }
                    removeErrorField(textBoxWidth);
                }
            }
            else
            {
                e.Cancel = true;
                setErrorToField(textBoxWidth, Color.Red, "Please enter a number minor than " + Desk.MAX_WIDTH + " and major than " + Desk.MIN_WIDTH);
            }
        }

        private void setErrorToField(TextBox inputField, Color errorColor, string errorMessge)
        {
            inputField.BackColor = errorColor;
            //Set focus to recived input
            inputField.Select(0, inputField.Text.Length);
            // Set the ErrorProvider error with the text to display. 
            this.errorProvider1.SetError(inputField, errorMessge);
        }

        private void removeErrorField(TextBox inputField)
        {
            this.errorProvider1.SetError(inputField, "");
            inputField.BackColor = Color.White;
        }

        private void textBoxDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}