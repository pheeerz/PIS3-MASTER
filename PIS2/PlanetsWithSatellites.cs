using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    public class PlanetsWithSatellites: Planets
    {
        public int counterOfSatellites {  get; set; }
        public PlanetsWithSatellites(string Name, DateTime OpeningDate, double Radius, int CounterOfSatellites) : base(Name, OpeningDate, Radius)
        {
            counterOfSatellites = CounterOfSatellites;
        }
        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is PlanetsWithSatellites))
                return false;

            PlanetsWithSatellites PWS = (PlanetsWithSatellites)obj;

            if (this.counterOfSatellites == PWS.counterOfSatellites)
                return base.Equals(obj);
            
            return false;
        }
    }
}
