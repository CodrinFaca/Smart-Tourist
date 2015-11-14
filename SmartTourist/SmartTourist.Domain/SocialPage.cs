using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTourist.Domain
{
    public class SocialPage
    {
        public int SocialPageId { get; set; }
        public PointOfInterest PointOfInterest { get; set; }
        public SocialApp App { get; set; }
        public string URL { get; set; }
    }
}
