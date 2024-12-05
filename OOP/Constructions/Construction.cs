using OOP.Constructions.DTO;
using OOP.Interfaces;
using OOP.Materials;
using System.Security.Cryptography;

namespace OOP.Constructions
{
    internal class Construction : ISquareCost, IConstructionInfo
    {
        private BuildMaterialEnum _buildMaterial;
        private AbstractMaterial _material;

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
        private AbstractMaterial Material
        {
            get => _material;
            set
            {
                _material = _buildMaterial switch
                {
                    BuildMaterialEnum.Brik => new BrikMaterial(),
                    BuildMaterialEnum.Concrete => new ConcreteMaterial(),
                    BuildMaterialEnum.Wood => new WoodMaterial(),
                    _ => throw new ArgumentException("Invalid build material type"),
                };
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
            double materialModificator = this.Material.GetSquareCost();
            materialModificator *= BuildMaterial switch
            {
                BuildMaterialEnum.Wood => 0.78,
                BuildMaterialEnum.Brik => 0.8,
                BuildMaterialEnum.Concrete => 0.87,
                _ => throw new ArgumentException("Invalid build material type"),
            };
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
