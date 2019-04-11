using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlightApp.Models
{
    public class Delays
    {
        public int DelayId { get; set; }
        public int FlightId { get; set; }   
        public int DelayType { get; set; }
        public int DelayInMinutes { get; set; }
    }
}