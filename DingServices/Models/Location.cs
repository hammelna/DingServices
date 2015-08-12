using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DingServices.Models
{
    public class Location : Interfaces.ILocation
    {
        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}