using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;

namespace MegaDeskASP
{
    public class DeskQuote
    {
        public const double PRICE_PER_IN2 = 1;
        public const int BASE_PRICE = 200;
        public const int PRICE_PER_DRAWER = 50;
        public const double SURFACE_MINIMUM = 1000;
        public enum SurfaceMaterial
        {
            Laminate = 100,
            Oak = 200,
            Pine = 50,
            Rosewood = 300,
            Veneer = 125
        }

        public static readonly List<int> RushDayOptions = new List<int>() { 3, 5, 7, 14 };

        public static decimal CalculateTotalPrice(int width, int depth, int drawers, int RushDays, string SurfaceMaterial)
        {
            double surfaceArea = GetSurfaceArea(width, depth);
            
            return (decimal)(GetBasePrice() + GetAreaPrice(surfaceArea) + GetDrawerPrice(drawers) + GetMaterialPrice(SurfaceMaterial) + GetRushPrice(surfaceArea, RushDays));
        }

        public static double GetSurfaceArea(int width, int depth)
        {
            return width * depth;
        }

        public static double GetBasePrice()
        {
            return BASE_PRICE;
        }

        public static double GetAreaPrice(double surfaceArea)
        {
            double price = 0;
            if (surfaceArea > SURFACE_MINIMUM)
            {
                price = (surfaceArea - SURFACE_MINIMUM) * PRICE_PER_IN2;
            }
            return price;
        }

        public static double GetMaterialPrice(string SurfaceMaterial)
        {
            return (int) Enum.Parse(typeof(SurfaceMaterial), SurfaceMaterial);
        }

        public static double GetDrawerPrice(int drawers)
        {
            return PRICE_PER_DRAWER * drawers;
        }

        public static double GetRushPrice(double surfaceArea, int RushDays)
        {
            if (RushDays == 14)
            {
                return 0;
            }
            if (RushDays == 3)
            {
                if(surfaceArea < 1000)
                {
                    return 60;
                } else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    return 70;
                } else
                {
                    return 80;
                }
            }
            else if (RushDays == 5)
            {
                if (surfaceArea < 1000)
                {
                    return 40;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    return 50;
                }
                else
                {
                    return 60;
                }
            }
            else if (RushDays == 7)
            {
                if (surfaceArea < 1000)
                {
                    return 30;
                }
                else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                {
                    return 35;
                }
                else
                {
                    return 40;
                }
            }
            return 0;
        }

    }
}
