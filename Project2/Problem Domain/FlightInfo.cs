using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class FlightInfo
    {
        private string _flightCode;
        private string _airline;
        private string _flightFrom;
        private string _flightTo;
        private string _flightDay;
        private string _flightTime;
        private int _flightSeat;
        private double _flightCost;

        public string FlightCode
        {
            get { return _flightCode; }
            set { _flightCode = value; }
        }

        public string Airline
        {
            get { return _airline; }
            set { _airline = value; }
        }

        public string FlightFrom
        {
            get { return _flightFrom; }
            set { _flightFrom = value; }
        }

        public string FlightTo
        {
            get { return _flightTo; }
            set { _flightTo = value; }
        }

        public string FlightDay
        {
            get { return _flightDay; }
            set { _flightDay = value; }
        }

        public string FlightTime
        {
            get { return _flightTime; }
            set { _flightTime = value; }
        }

        public int FlightSeat
        {
            get { return _flightSeat; }
            set { _flightSeat = value; }
        }

        public double FlightCost
        {
            get { return _flightCost; }
            set { _flightCost = value; }
        }

        public FlightInfo(string flightCode, string airline, string flightFrom, 
            string flightTo, string flightDay, string flightTime, int flightSeat, double flightCost)
        {
            _flightCode = flightCode;
            _airline = airline;
            _flightFrom = flightFrom;
            _flightTo = flightTo;
            _flightDay = flightDay;
            _flightTime = flightTime;
            _flightSeat = flightSeat;
            _flightCost = flightCost;
        }

        public override string ToString() 
        {
            return 
                $"Flight Code: {FlightCode}\n" +
                $"Origin Airport: {FlightFrom}\n" +
                $"Destination Airport: {FlightTo}\n" +
                $"Time of Flight: {FlightTime}\n" +
                $"Seats Available: {FlightSeat}\n" +
                $"Cost: {FlightCost}\n";
        }



    }
}
