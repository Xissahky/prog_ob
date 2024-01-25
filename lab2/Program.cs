using LAB2.BuildingWrappers;
using LAB2.CommercialBuildings;
using LAB2.Constructions;
using LAB2.Constructions.Models;
using LAB2.IndustrialHalls;
using LAB2.ResidentalBuildings;
using System;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            var construction = new Construction(23, 45, 4, 6, BuildMaterialType.Concrete);
            var construction2 = new Construction();
            var input = new CreateConstructionDto()
            {
                BuildMaterial = BuildMaterialType.Wood,
                Width = 23,
                Height = 12,
                Entrances = 2,
                HumanCapacity = 2
            };
            var construction3 = new Construction(input);
            Console.WriteLine(construction3.BuildMaterial);
            var industrialHall = new IndustrialHall();
            var residentalBuilding = new ResidentalBuilding(2);
            Console.WriteLine(industrialHall.BuildMaterial);
            Console.WriteLine(industrialHall.Height);
            Console.WriteLine(industrialHall.Width);
            Console.WriteLine(residentalBuilding.BuildMaterial);
            Console.WriteLine(residentalBuilding.Height);
            Console.WriteLine(residentalBuilding.GetSquareCost());

            var wrapper1 = new BuildingWrapper(industrialHall);
            var wrapper2 = new BuildingWrapper(residentalBuilding);
            Console.WriteLine(wrapper1.GetWrappedSquareCost());
            Console.WriteLine(wrapper2.GetWrappedSquareCost());

            var commercialBuilding = new CommercialBuilding(23, 45, 4, 6, BuildMaterialType.Concrete, "Ecommerce");
            commercialBuilding.OpenBusiness();
            Console.WriteLine(commercialBuilding.BuildMaterial);
            Console.WriteLine(commercialBuilding.Height);
            Console.WriteLine(commercialBuilding.Width);
        }
    }
}
