﻿using OOP.Constructions.DTO;
using OOP.Interfaces;
using OOP.Materials;
using System.Security.Cryptography;

namespace OOP.Constructions
{
    internal class Construction : ISquareCost, IConstructionInfo
    {
        private BuildMaterialEnum _buildMaterial;

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public BuildMaterialEnum BuildMaterial
        {
            get => _buildMaterial;
            set
            {
                ArgumentNullException.ThrowIfNull(value);
                _buildMaterial = value;
            }
        }

        public Construction()
        {
            Height = 3;
            Width = 2;
            Entrances = 1;
            HumanCapacity = 0;
            BuildMaterial = BuildMaterialEnum.Concrete;
        }

        public Construction(CreateConstructionDto createConstructionDto)
        {
            Height = createConstructionDto.Height;
            Width = createConstructionDto.Width;
            Entrances = createConstructionDto.Entrances;
            BuildMaterial = createConstructionDto.BuildMaterial;
        }

        public Construction(float height, float width, int entrances, int humanCapacity, BuildMaterialEnum buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public double GetSquareCost()
        {
            double materialModificator = 0;
            switch (BuildMaterial)
            {
                case BuildMaterialEnum.Wood:
                    materialModificator = 0.78;
                    break;
                case BuildMaterialEnum.Brick:
                    materialModificator = 0.8;
                    break;
                case BuildMaterialEnum.Concrete:
                    materialModificator = 0.87;
                    break;
            }
            return Height * Width * materialModificator;
        }

        public double CalculateSquareCost()
        {
            return GetSquareCost();
        }

        public void DisplayCostDetails()
        {
            Console.WriteLine($"Square cost details for the building: ");
            Console.WriteLine($"Height: {Height}, Width: {Width},Entrances: {Entrances}, Human Capacity: {HumanCapacity}, BuildMaterial: {BuildMaterial}");
            Console.WriteLine($"Square Cost: {CalculateSquareCost()}");
        }

        public void DisplayConstructionInfo()
        {
            Console.WriteLine($"Construction information for the building: ");
            Console.WriteLine($"Height: {Height}, Width: {Width}, Entrances: { Entrances}, Human Capacity: { HumanCapacity}, BuildMaterial: { BuildMaterial}");
        }
    }
}
