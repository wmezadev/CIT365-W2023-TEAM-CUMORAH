using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk.Desk;

namespace MegaDesk
{
    public class DeskQuote
    {
        public const double BASE_PRICE = 200;
        public const double PRICE_PER_IN2 = 1;
        public const double PRICE_PER_DRAWER = 50;
        public const double SURFACE_MINIMUM = 1000;
        public enum RUSH_DAYS
        {
            [Description("3 days")]
            Rush3,
            [Description("5 days")]
            Rush5,
            [Description("7 days")]
            Rush7,
            [Description("14 days, no Rush")]
            Rush14
        }

        public Desk desk;

        public DateTime dateTime { get; set; }
        public string CustomerName { get; set; }
        public RUSH_DAYS RushDays { get; set; }

        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public int SurfaceMaterial { get; set; }



        //public DateTime dateTime = DateTime.Now;
        public DeskQuote (Desk desk, string customerName, RUSH_DAYS rushDays)
        {
            this.desk = desk;
            Width = desk.Width;
            Depth = desk.Depth;
            NumberOfDrawers = desk.NumberOfDrawers;
            SurfaceMaterial = (int)desk.SurfaceMaterial;
            dateTime = DateTime.Now;
            CustomerName = customerName;
            RushDays = rushDays;
        }

        // Code from https://stackoverflow.com/questions/2650080/how-to-get-c-sharp-enum-description-from-value
        public static string GetEnumDescription(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());
            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }
            return value.ToString();
        }

        public double GetBasePrice()
        {
            return BASE_PRICE;
        }
        
        public double GetAreaPrice()
        {
            double price = 0;
            if (desk.GetArea() > SURFACE_MINIMUM)
            {
                price = desk.GetArea() - SURFACE_MINIMUM;
            }
            return price;
        }

        public double GetMaterialPrice()
        {
            return (double) desk.SurfaceMaterial;
        }

        public double GetDrawerPrice()
        {
            return PRICE_PER_DRAWER * desk.NumberOfDrawers;
        }

        public double GetRushPrice()
        {
            string[] pricesFromFile = GetRushOrder();
            int[,] rushOrderPrices = PreparePricesFromFile(pricesFromFile);
            var dephwith = desk.GetArea();
            if (RushDays.Equals(RUSH_DAYS.Rush14))
            {
                return 0;
            }
            if (desk.GetArea() < 1000)
            {
                int FIRST_COLUMN = 0;
                return rushOrderPrices[(int)RushDays, FIRST_COLUMN];
                /*if(RushDays.Equals(RUSH_DAYS.Rush3))
                {  
                    return rushOrderPrices[(int)RUSH_DAYS.Rush3, FIRST_COLUMN];
                } else if(RushDays.Equals(RUSH_DAYS.Rush5))
                {
                    return rushOrderPrices[(int)RUSH_DAYS.Rush5, FIRST_COLUMN];
                } else
                {
                    return rushOrderPrices[(int)RUSH_DAYS.Rush7, FIRST_COLUMN];
                }*/
            }
            else if (desk.GetArea() >= 1000 && desk.GetArea() <= 2000)
            {
                int SECOND_COLUMN = 1;
                return rushOrderPrices[(int)RushDays, SECOND_COLUMN];
                /*if (RushDays.Equals(RUSH_DAYS.Rush3))
                {
                    return rushOrderPrices[(int)RUSH_DAYS.Rush3, SECOND_COLUMN];
                }
                else if (RushDays.Equals(RUSH_DAYS.Rush5))
                {
                    return rushOrderPrices[(int)RUSH_DAYS.Rush5, SECOND_COLUMN];
                }
                else
                {
                    return rushOrderPrices[(int)RUSH_DAYS.Rush7, SECOND_COLUMN];
                }*/
            }
            else if (desk.GetArea() > 2000)
            {
                int THRID_COLUMN = 2;
                return rushOrderPrices[(int)RushDays, THRID_COLUMN];
/*                if (RushDays.Equals(RUSH_DAYS.Rush3))
                {
                    return rushOrderPrices[(int)RUSH_DAYS.Rush3, THRID_COLUMN];
                }
                else if (RushDays.Equals(RUSH_DAYS.Rush5))
                {
                    return rushOrderPrices[(int)RUSH_DAYS.Rush5, THRID_COLUMN];
                }
                else
                {
                    return rushOrderPrices[(int)RUSH_DAYS.Rush7, THRID_COLUMN];
                }*/
            }
            return 0;
        }


        private string[] GetRushOrder()
        {
            string path = @"files\TextFile1.txt";
            List<string> prices = new List<string>();
            try 
            { 
                if(File.Exists(path))
                {
                    string[] readText = File.ReadAllLines(path);
                    prices = new List<string>(readText.Length);
                    foreach (string price in readText)
                    {                 
                        prices.Add(price);  
                    }
                    return prices.ToArray();

                }
                else
                {
                    throw new Exception("File doesnt exist");
                }

            } catch (FileNotFoundException e)
                {
                    MessageBox.Show(e.Message);
                }
            return prices.ToArray(); //Default value is empy
        }

        private int[,] PreparePricesFromFile(string[] pricesFromFile)
        {
            int[,] prices = new int[3,3] ;
            double row = 0;
            int counter = 0;
            for ( int i = 0; i< pricesFromFile.Length; i++ ) {
                int price = int.Parse(pricesFromFile[i]);
                prices[(int)row, counter] = price;

                counter++;
                if ( (i + 1) % 3 == 0)
                {
                    row++;
                    counter = 0;  // every 3 items I want to restart this counter in order to fill the array
                }
            }
            return prices;  
        }
        public double GetTotalPrice()
        {
            return GetBasePrice() + GetAreaPrice() + GetMaterialPrice() + GetDrawerPrice() + GetRushPrice();
        }
    }
}
