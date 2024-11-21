using OOP.Constructions.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Constructions
{
    internal abstract class AbstractCommercialBuilding : Construction
    {
        protected AbstractCommercialBuilding(CreateConstructionDto construction, string businessType) : base(construction)
        {
            BusinessType = businessType;
        }

        public string BusinessType { get; set; }
        public abstract void OpenBusiness();
    }
}
