using System;
using System.Collections.Generic;
using System.Text;


namespace lab2.construction
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