using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.Constructions.Models
{
    class CreateConstructionDto
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public BuildMaterialType BuildMaterial { get; set; }
    }
}
