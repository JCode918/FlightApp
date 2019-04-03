using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightApp.Models
{
    public class FlightData
    {
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int OriginAirportId { get; set; }
        public int DestinationAirportId { get; set; }
        public int Distance { get; set; }
        public int CarrierDelay { get; set; }
        public int WeatherDelay { get; set; }
        public int NasDelay { get; set; }
        public int SecurityDelay { get; set; }
        public int LateAircraftDelay { get; set; }
    }
}