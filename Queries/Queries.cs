using Cities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Queries
{
    public class Queries
    {
        public static double StandDevQuery(IList<CitiesImportModel> myList, string cityType)
        {
            var query = (from s in myList
                                       where s.Capital.Equals(cityType)
                                       orderby s.Country ascending
                                       select s.Population);

            double[] populations = new double[myList.Count];

            foreach (CitiesImportModel city in query)
            {
                 populations = city.Population;
                    
            }
            
            double result = StatStandardDev.StandDev(populations);

            return result;
        }
    }
}
