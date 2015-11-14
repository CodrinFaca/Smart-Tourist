using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTourist.Domain
{
    public class Location
    {
        public int LocationId { get; set; }
        public double XCoord { get; set; }
        public double YCoord { get; set; }
        public DateTime TakenAt { get; set; }
        public PointOfInterest ClosestTo { get; set; }

    }
}
