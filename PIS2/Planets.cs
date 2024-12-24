using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIS2
{
    public class Planets
    {
        public string name { get; set; }
        public DateTime openingDate { get; set; }
        public double radius { get; set; }

        public Planets(string Name, DateTime OpeningDate, double Radius)
        {
            name = Name;
            openingDate = OpeningDate;
            radius = Radius;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null || !(obj is Planets))
                return false;

            return this.name == ((Planets) obj).name && this.openingDate == ((Planets) obj).openingDate && this.radius == ((Planets) obj).radius;
        }
    }
}
