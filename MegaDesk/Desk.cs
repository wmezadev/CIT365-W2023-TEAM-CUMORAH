using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Desk
    {
        // Constraints
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_DEPTH = 12;
        public const int MAX_DEPTH = 48;
        public const int MIN_DRAWER_NUMBER = 0;
        public const int MAX_DRAWER_NUMBER = 7;
        public enum DesktopMaterial
        {
            Laminate = 100,
            Oak = 200,
            Rosewood = 300,
            Veneer = 125,
            Pine = 50
        }
        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public DesktopMaterial SurfaceMaterial { get; set; }

        public Desk(int Width, int Depth, int NumberOfDrawers, DesktopMaterial? SurfaceMaterial)
        {
            this.Width = Width;
            this.Depth = Depth;
            this.NumberOfDrawers = NumberOfDrawers;
            this.SurfaceMaterial = (DesktopMaterial) SurfaceMaterial;
        }

        public double GetArea()
        {
            return Width * Depth;
        }

    }
}
