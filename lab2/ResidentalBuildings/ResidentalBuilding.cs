using LAB2.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.ResidentalBuildings
{
    class ResidentalBuilding: Construction
    {
        public ResidentalBuilding(int floors)
        {
            NumberOfFloors = floors;
        }

        public int NumberOfFloors { get; set; }
    }
}
