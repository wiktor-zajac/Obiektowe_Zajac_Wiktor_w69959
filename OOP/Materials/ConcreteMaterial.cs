namespace OOP.Materials
{
    internal class ConcreteMaterial : AbstractMaterial
    {
        public ConcreteMaterial()
        {
            MaterialCost = 200;
        }
        public override double CalculateMaterialCost()
        {
            return MaterialCost;
        }

    }
}
