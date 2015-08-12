using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DingServices.Models
{
    public class UserProfile : Interfaces.IUserProfile
    {
        public string UserName { get; set; }

        public Interfaces.ILocation Location { get; set; }

        public List<Interfaces.IPreference> Preferences { get; set; }

        public List<Interfaces.IUserProfile> DingConnections { get; set; }        
    }
}