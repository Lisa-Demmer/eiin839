using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestWS
{
    class Contrat
    {
        public string name {get; set;}
        public string commercial_name { get; set; }
        public List<string> cities { get; set; }
        public string country_code { get; set; }

        public override string ToString()
        {
            string str = "Contrat : " + name + "\n" +
                " commercial_name = " + commercial_name + "\n" +
                " country_code = " + country_code + "\n";
            if (cities != null && cities.Count() > 0)
            {
                str += " cities = \n";
                foreach (string city in cities)
                {
                    str += "  " + city + "\n";
                }
            }
            return str;
        }
    }
}
