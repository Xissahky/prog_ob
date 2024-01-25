using LAB2.Constructions;
using LAB2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.IndustrialHalls
{
    class IndustrialHall : Construction
    {
        public IndustrialHall(): base(23, 12, 12, 1, BuildMaterialType.Concrete)
        {
            Console.WriteLine("Constructor of industrial hall");
        }
    }
}
