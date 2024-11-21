namespace OOP.Materials
{
    internal class BrikMaterial : AbstractMaterial
    {
        public BrikMaterial()
        {
            MaterialCost = 100;
        }
        public override double CalculateMaterialCost()
        {
            return MaterialCost;
        }

    }
}
