using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Resources;
using Project2.Properties;

namespace Project2.Problem_Domain
{
    internal class FlightManager 
    {
        List<FlightInfo> flights = new List<FlightInfo>();

        public FlightManager()
        {
            FlightData();
        }


        public void FlightData()
        {
            string[] data = Resources.flights.Split('\n');

            foreach (string s in data)
            {
                string[] flightData = s.Split(',');

                flights.Add(new FlightInfo(
                    flightData[0],
                    flightData[1],
                    flightData[2],
                    flightData[3],
                    flightData[4],
                    flightData[5],
                    int.Parse(flightData[6]),
                    double.Parse(flightData[7])));
            }

        }
    }
              
}
