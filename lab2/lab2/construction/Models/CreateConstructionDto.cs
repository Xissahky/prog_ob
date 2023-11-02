using System;
using System.Collections.Generic;
using System.Text;


namespace lab2.construction.Models
{
    class CreateConstructionDto
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public int Entranses { get; set; }
        public int Humancapasity { get; set; }
        public BuildmaterialType BuildMaterial
        {
            get; set;
        }
    }
}