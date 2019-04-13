using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightApp.Models
{
    public class AirlineCarrier
    {
        public int AirlineCarrierId { get; set; }
        public string AirlineCarrierName { get; set; }
        public string AirlineIata { get; set; }
        public string AirlineIcao { get; set; }
        public string AirlineCallsign { get; set; }
    }
}