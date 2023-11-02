using System;
using System.Collections.Generic;
using System.Text;
using lab2.construction.Models;

namespace lab2.construction
{
    class Construction
    {
        public Construction(double height, double width, int entranses, int humancapasity, BuildmaterialType buildMaterial)
        {
            Height = height;
            Width = width;
            Entranses = entranses;
            Humancapasity = humancapasity;
            BuildMaterial = buildMaterial;

        }

        public Construction()
        {
            Height = height;
            Width = width;
            Entranses = entranses;
            Humancapasity = humancapasity;
            BuildMaterial = buildMaterial;

        }

        public Construction(CreateConstructionDto input)
        {
            Height = input.height;
            Width = input.width;
            Entranses = input.entranses;
            Humancapasity = input.humancapasity;
            BuildMaterial = input.buildMaterial;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public int Entranses { get; set; }
        public int Humancapasity { get; set; }

        public BuildmaterialType BuildMaterial {
            get
            {
                return _buildMaterial;
            } 
            set
            {
                if (value == string.Empty)
                {
                    throw new ArgumentNullException();
                }
                _buildMaterial = value;
            }
        }
        private string _buildMaterial { get; set;}

        public double GetSquareCost()
        {
            if (_buildMaterial == BuildmaterialType.Consrete)
            {
                x=0.87;
            }
            if (_buildMaterial == BuildmaterialType.Wood)
            {
                x=0.8
            }
            if (_buildMaterial == BuildmaterialType.Brik)
            {
                x=0.78
            }
            return Width*Height*0.9*x;
        }
    }
}