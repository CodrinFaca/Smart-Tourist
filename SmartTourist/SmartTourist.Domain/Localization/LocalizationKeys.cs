using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTourist.Domain.Localization
{
    //Clasa asta e folosita ca sa nu scrii de mana stringuri -> nu gresesti.
    //Daca vrei sa folosestii ca si key Login, apelezi ca in metoda GetValue
    
    public class LocalizationKeys
    {
        public static string Login = "Login";

        public string GetValue(string test)
        {
            test = LocalizationKeys.Login;
            List<LocalizationStrings> local = new List<LocalizationStrings>();
            string stringLocalizat = local.Where(x => x.Key.Equals(test) && x.LanguageCode.Equals("en")).FirstOrDefault().Value;
            return stringLocalizat;
            
        }
    }
}
