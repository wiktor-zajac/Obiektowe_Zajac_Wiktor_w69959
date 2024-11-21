using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
