using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace FlightApp.Models
{
    public class Routes
    {
        public int RouteId { get; set; }
        public int RouteAirlineId { get; set; }
        public AirlineCarrier AirlineCarrier { get; set; }
        public int RouteSourceAirportId { get; set; }
        public int RouteDestinationAirportId { get; set; }
        public Airport Airport { get; set; }
        public int RouteStops { get; set; }
        public int RouteAirplaneId { get; set; }
        public Airplane Airplane { get; set; }
    }
}