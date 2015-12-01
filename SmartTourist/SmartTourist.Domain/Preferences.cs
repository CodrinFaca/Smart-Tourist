using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTourist.Domain
{
    public class Preferences
    {
        public UserType UserType { get; set; }
        public List<TourismType> TourismType { get; set; }
    }
}
