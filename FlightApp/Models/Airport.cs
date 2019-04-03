using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightApp.Models
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public string AirportCity { get; set; }
        public int StateId { get; set; }
    }
}