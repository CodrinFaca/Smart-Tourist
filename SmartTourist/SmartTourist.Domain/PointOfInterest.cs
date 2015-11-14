using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTourist.Domain
{
    public class PointOfInterest
    {
        public int PointOfInterestId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string TelephoneNumber { get; set; }
        public string Details { get; set; } //detalii despre locatie
        public string DetailsSource { get; set; } //sursa detaliilor
        public List<SocialPage> SocialPages { get; set; }

    }
}
