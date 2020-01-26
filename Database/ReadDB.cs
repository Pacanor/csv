using Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database
{
    public class ReadDB
    {
        public static IOrderedQueryable<CityEntity> ReadCitiesDB(string typeOfCity)
        {
            CityContext db = new CityContext();
            var city = (from s in db.Cities
                              where s.Capital.Equals(typeOfCity)
                              orderby s.Country ascending
                              select s);
            return city;

        }
    }
}
