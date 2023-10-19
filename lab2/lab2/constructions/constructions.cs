using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab2.constructions
{
    class Construction
    {
        public Construction(double height, double width, int entranses, int humancapasity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entranses = entranses;
            Humancapasity = humancapasity;
            BuildMaterial = buildMaterial;

        }
        public double Height { get; set; }
        public double Width { get; set; }
        public int Entranses { get; set; }
        public int Humancapasity { get; set; }
        public string BuildMaterial { get; set; }
    }
}