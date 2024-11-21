using OOP.Constructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.IndustrialHalls
{
    internal class IndustrialHall : Construction
    {
        public IndustrialHall(): base(33.0f, 65.0f, 2, 2, BuildMaterialEnum.Wood)
        {
            Console.WriteLine("initialize industrial hall");
        }
    }
}
