using OOP.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.BuildingWrappers
{
    internal class BuildingWrapper
    {
        public BuildingWrapper(Construction construction) {
            _construction = construction;
        }

        private Construction _construction { get; set; }

        public double GetWrappedSquareCost()
        {
            return _construction.GetSquareCost();
        }
    }
}
