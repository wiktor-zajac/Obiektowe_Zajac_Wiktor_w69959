using OOP.Constructions;

abstract class AbstractMaterial : Construction
{
    protected double MaterialCost;
    public abstract double CalculateMaterialCost();
}