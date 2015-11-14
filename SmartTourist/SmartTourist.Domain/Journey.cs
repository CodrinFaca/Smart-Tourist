using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTourist.Domain
{
    public class Journey
    {
        public int JourneyId { get; set; }
        public PointOfInterest[] PointsToVisit { get; set; }
        public JourneyStatus[] Status { get; set; }
        //fiecare element din PointsToVisit va avea un element in Status
        public DateTime StartDate { get; set; }
        //public DateTime EndDate { get; set; }


    }
}
