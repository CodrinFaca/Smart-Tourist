using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTourist.Domain
{
    public class JourneyStatus
    {
        public int JourneyStatusId { get; set; }
        public PointOfInterest PointToVisit { get; set; }
        public PointOfInterestStatus Status { get; set; }
        public string Comment { get; set; } //un comentariu in caz ca se razgandeste sau ceva de genu
    }
}
