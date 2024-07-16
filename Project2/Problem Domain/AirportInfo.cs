using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class AirportInfo
    {
        private string _airportCode;
        private string _airportName;

        public string AirportCode
        {
            get { return _airportCode; }
            set { _airportCode = value; }
        }

        public string AirportName
        {
            get { return _airportName; }
            set { _airportName = value; }
        }

        public AirportInfo()
        {
        }

        public AirportInfo(string airportCode, string airportName)
        {
            _airportCode = airportCode;
            _airportName = airportName;

        }

        public override string ToString()
        {
            return 
                $"Airport Code: {AirportCode}\n" +
                $"Airport Name: {AirportName}";
        }




    }
}
