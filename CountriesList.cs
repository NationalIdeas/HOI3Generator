using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeadersGenerator
{
    class CountryName 
    {
        public String Country = null;
       // Country = "SOV";




    }
    class CountriesList
    {
        public String Country = null;
        public int Init() 
        {
            Country = "SOV";
            List<CountryName> LCN = new List<CountryName>();
            CountryName k = new CountryName();
            LCN.Add(k);




            return 0;
        }
    }

}
