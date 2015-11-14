using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTourist.Domain.Localization
{
    public class LocalizationStrings
    {
        public int LocalizationStringsId { get; set; }
        public string LanguageCode { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
