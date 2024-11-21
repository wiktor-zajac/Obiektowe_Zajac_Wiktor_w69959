using OOP.Constructions;
using OOP.Interfaces;
namespace OOP.BuildingWrappers
{
    internal class BuildingWrapper : ISquareCost
    {
        public BuildingWrapper(Construction construction) {
            _construction = construction;
        }

        private Construction _construction { get; set; }

        public double CalculateSquareCost()
        {
            return GetWrappedSquareCost();
        }

        public void DisplayCostDetails()
        {
            _construction.DisplayCostDetails();
        }

        public double GetWrappedSquareCost()
        {
            return _construction.GetSquareCost();
        }

    }
}
