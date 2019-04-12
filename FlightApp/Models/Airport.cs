﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI.WebControls.WebParts;

namespace FlightApp.Models
{
    public class Airport
    {
        public int AirportId { get; set; }
        public string AirportName { get; set; }
        public string AirportAbbreviation { get; set; }
        public string AirportCity { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }   
        public int CityId { get; set; }
        public City City { get; set; }
        public int StateId { get; set; }
        public virtual State State { get; set; }
    }
}