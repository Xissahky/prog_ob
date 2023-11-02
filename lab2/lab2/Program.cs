using System;
using lab2.construction;
using lab2.construction.Models;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(23, 45,4,6,"brik")
            var construction2 = new Construction();
            var input = new CreateConstructionDto()
            {
                BuildMaterial = BuildmaterialType.wood,
                Height = 12,
                Width = 23,
                Entranses = 2,
                Humancapasity = 2,
                
            }
            var construction3 = new Construction(input);
            Console.WriteLine(construction.BuildMaterial);
            Console.WriteLine(construction2.BuildMaterial);

        }
    }
}