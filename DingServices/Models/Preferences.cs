using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DingServices.Models
{
    public class Preferences : Interfaces.IPreference
    {
        public string Name { get; set; }
    }
}