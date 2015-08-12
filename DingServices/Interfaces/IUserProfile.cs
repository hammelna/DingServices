using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DingServices.Interfaces
{
    public interface IUserProfile
    {
        string UserName { get; set; }

        ILocation Location { get; set; }

        List<IPreference> Preferences {get; set;}

        List<IUserProfile> DingConnections { get; set; }
    }
}
