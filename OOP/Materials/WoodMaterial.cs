namespace OOP.Materials
{
    internal class WoodMaterial : AbstractMaterial
    {
        public WoodMaterial()
        {
            MaterialCost = 300;
        }
        public override double CalculateMaterialCost()
        {
            return MaterialCost;
        }
    }
}
