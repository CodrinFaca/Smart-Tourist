using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTourist.Domain
{
    public class User
    {
        //Detalii precum username, email, password, logare externa vor fi generate
        //public Preferences UserPreferences { get; set; }
        public Journey CurrentJourney { get; set; }
        public List<Journey> PastJourneys { get; set; }
        public Location LastKnownLocation { get; set; }
        public string LanguageCode { get; set; }

    }
}
