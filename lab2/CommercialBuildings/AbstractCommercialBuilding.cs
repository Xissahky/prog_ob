using LAB2.Constructions;
using LAB2.Constructions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2.CommercialBuildings
{
    abstract class AbstractCommercialBuilding: Construction
    {
        protected AbstractCommercialBuilding(float height, float width, int entrances, int humanCapacity, BuildMaterialType buildMaterial, string businessType): base(height, width, entrances, humanCapacity, buildMaterial)
        {
            BusinessType = businessType;
        }


        public string BusinessType { get; set; }
        public abstract void OpenBusiness();
    }
}
