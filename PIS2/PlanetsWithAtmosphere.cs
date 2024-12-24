using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    public class PlanetsWithAtmosphere: Planets
    {
        public bool atmosphere {  get; set; }
        public PlanetsWithAtmosphere(string Name, DateTime OpeningDate, double Radius, bool Atmosphere): base(Name, OpeningDate, Radius) 
        {
            atmosphere = Atmosphere;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is PlanetsWithAtmosphere))
                return false;

            PlanetsWithAtmosphere PWA = (PlanetsWithAtmosphere)obj;

            if(this.atmosphere == PWA.atmosphere)
                return base.Equals(obj);
            
            return false;
        }
    }
}
