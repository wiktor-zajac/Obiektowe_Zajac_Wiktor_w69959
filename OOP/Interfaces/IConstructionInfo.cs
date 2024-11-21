using OOP.Materials;

namespace OOP.Interfaces
{
    internal interface IConstructionInfo
    {
        float Height { get; }
        float Width { get; }
        int Entrances { get; }
        int HumanCapacity { get; }
        BuildMaterialEnum BuildMaterial { get; }
        void DisplayConstructionInfo();
    }
}
