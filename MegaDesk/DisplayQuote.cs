using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            labelCustomerNameValue.Text = deskQuote.CustomerName;
            labelQuotationDateValue.Text = deskQuote.dateTime.ToString("dd/MM/yyyy");
            labelRushDaysValue.Text = "" + DeskQuote.GetEnumDescription(deskQuote.RushDays);
            labelWidthValue.Text = deskQuote.desk.Width + " in";
            labelDepthValue.Text = deskQuote.desk.Depth + " in";
            labelDrawersValue.Text = "" + deskQuote.desk.NumberOfDrawers;
            labelSurfaceMaterialValue.Text = "" + deskQuote.desk.SurfaceMaterial;
            labelBasePriceValue.Text = "$" + deskQuote.GetBasePrice();
            labelSurfacePriceValue.Text = "$" + deskQuote.GetMaterialPrice();
            labelDrawersPriceValue.Text = "$" + deskQuote.GetDrawerPrice();
            labelRushPriceValue.Text = "$" + deskQuote.GetRushPrice();
            labelTotalPriceValue.Text = "$" + deskQuote.GetTotalPrice();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu formMainMenu = (MainMenu)Tag;
            formMainMenu.Show();
        }
    }
}
