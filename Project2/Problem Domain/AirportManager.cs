using Project2.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Problem_Domain
{
    internal class AirportManager
    {
        List<AirportInfo> airports = new List<AirportInfo>();

        public AirportManager()
        {
            airportData();
        }

        public void airportData()
        {
            string[] data = Resources.airports.Split('\n');

            foreach (string s in data) 
            {
                string[] airportData = s.Split(',');
                airports.Add(new AirportInfo(
                    airportData[0],
                    airportData[1]));

            }

        }
    }

   
}
