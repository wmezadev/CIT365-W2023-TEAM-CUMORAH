
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public class Datamodel
    {

        //public Desk desk { get; set; }
        public DateTime dateTime { get; set; }
        public string CustomerName { get; set; }
        public int RushDays { get; set; }

        public class Desk
        {
            public int Width { get; set; }
            public int Depth { get; set; }
            public int NumberOfDrawers { get; set; }
            public int SurfaceMaterial { get; set; }
        }

    }
}
