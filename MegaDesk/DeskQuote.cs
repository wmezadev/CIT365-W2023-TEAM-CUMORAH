using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
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
            if (RushDays.Equals(RUSH_DAYS.Rush14))
            {
                return 0;
            }
            if (desk.GetArea() < 1000)
            {
                if(RushDays.Equals(RUSH_DAYS.Rush3))
                {  
                    return 60;
                } else if(RushDays.Equals(RUSH_DAYS.Rush5))
                {
                    return 40;
                } else
                {
                    return 30;
                }
            }
            else if (desk.GetArea() >= 1000 && desk.GetArea() < 2000)
            {
                if (RushDays.Equals(RUSH_DAYS.Rush3))
                {
                    return 70;
                }
                else if (RushDays.Equals(RUSH_DAYS.Rush5))
                {
                    return 50;
                }
                else
                {
                    return 35;
                }
            }
            else if (desk.GetArea() >= 2000)
            {
                if (RushDays.Equals(RUSH_DAYS.Rush3))
                {
                    return 80;
                }
                else if (RushDays.Equals(RUSH_DAYS.Rush5))
                {
                    return 60;
                }
                else
                {
                    return 40;
                }
            }
            return 0;
        }

        public double GetTotalPrice()
        {
            return GetBasePrice() + GetAreaPrice() + GetMaterialPrice() + GetDrawerPrice() + GetRushPrice();
        }
    }
}
