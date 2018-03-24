using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZNIC
{
    class Profile
    {
        private string ipAddress;
        private string subnetMask;
        private string defaultGateway;

        public string IpAddress
        {            //getter and setter
            get { return ipAddress; }
            set { ipAddress = value; }
        }
        public string SubnetMask
        {            //getter and setter
            get { return subnetMask; }
            set { subnetMask = value; }
        }
        public string DefaultGateway
        {       //getter and setter
            get { return defaultGateway; }
            set { defaultGateway = value; }
        }
        public Profile()
        {               //default constructor
            ipAddress = "";
            subnetMask = "";
            defaultGateway = "";
        }
        public Profile(string newIpAddress, string newSubnetMask, string newDefaultGateway)
        {       //usual constructor
            ipAddress = newIpAddress;
            subnetMask = newSubnetMask;
            defaultGateway = newDefaultGateway;
        }
    }//END OF CLASS

}//end Namespace
