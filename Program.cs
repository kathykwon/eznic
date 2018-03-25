using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace EZNIC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }//Main

        public static void setDynamic(string myDesc)
        {
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();

            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description,
                    myDesc, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        var enableDhcp = adapter.InvokeMethod("EnableDHCP", null);
                        Console.WriteLine(enableDhcp.ToString());

                        Console.WriteLine("Updated Dynamic address!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unable to Set IP : " + ex.Message);
                    }
                }
            }
        }

        public static void setStatic(string myDesc, string address, string subnet, string gateway)
        {
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();
            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description,
                    myDesc, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        // Set DefaultGateway
                        var newGateway = adapter.GetMethodParameters("SetGateways");
                        newGateway["DefaultIPGateway"] = new string[] { gateway };
                        newGateway["GatewayCostMetric"] = new int[] { 1 };

                        // Set IPAddress and Subnet Mask
                        var newAddress = adapter.GetMethodParameters("EnableStatic");
                        newAddress["IPAddress"] = new string[] { address };
                        newAddress["SubnetMask"] = new string[] { subnet };

                        adapter.InvokeMethod("EnableStatic", newAddress, null);
                        adapter.InvokeMethod("SetGateways", newGateway, null);
                        Console.WriteLine("Updated to static IP address!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unable to Set IP : " + ex.Message);
                    }
                }
            }
        }

        public static void setStaticDns(string myDesc, string dns)
        {
            var adapterConfig = new ManagementClass("Win32_NetworkAdapterConfiguration");
            var networkCollection = adapterConfig.GetInstances();
            foreach (ManagementObject adapter in networkCollection)
            {
                string description = adapter["Description"] as string;
                if (string.Compare(description,
                    myDesc, StringComparison.InvariantCultureIgnoreCase) == 0)
                {
                    try
                    {
                        var newDNS = adapter.GetMethodParameters("SetDNSServerSearchOrder");
                        newDNS["DNSServerSearchOrder"] = dns.Split(',');
                        ManagementBaseObject setDNS = adapter.InvokeMethod("SetDNSServerSearchOrder", newDNS, null);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Unable to Set DNS : " + ex.Message);
                    }
                }
            }
        }
    }//class Program
}//namespace EZNIC
