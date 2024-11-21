using OOP.Constructions.DTO;
using OOP.Constructions;

internal class CommercialBuilding : AbstractCommercialBuilding
{
    public CommercialBuilding(CreateConstructionDto construction,
    string businessType) : base(construction, businessType)
    {
    }
    public override void OpenBusiness()
    {
        Console.WriteLine($"The {BusinessType} business is now open in the commercial building!");
    }
}
