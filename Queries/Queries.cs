﻿using Cities;
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
                                       select s);

            double[] populations = new double[myList.Count];
            int i = 0;

            foreach (CitiesImportModel city in query)
            {
                populations[i] = city.Population;
                i++;
                    
            }
            
            double result = StatStandardDev.StandDev(populations);

            return result;
        }

        public static double StandDevQuery(IList<CitiesImportModel> myList, string cityType, double score)
        {
            double standDev = StandDevQuery(myList, cityType);
            double zScore = (score - mean) / standDev;
            return zScore;
        }
    }
}
