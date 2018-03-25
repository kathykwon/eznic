using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using Microsoft.Win32;

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
            string[] networkInterfaces = new string[10];
            string[] networkInterfacesSettingId = new string[10];
            int numberOfNetworkInterfaces = 0;
            ManagementClass objMC = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection objMOC = objMC.GetInstances();
            foreach (ManagementObject objMO in objMOC)
            {
                if (Convert.ToBoolean(objMO["ipEnabled"]) == false)
                    continue;

                string SettingID = "";
                try
                {
                    networkInterfacesSettingId[numberOfNetworkInterfaces] =
                        (string)objMO["SettingID"];
                    ++numberOfNetworkInterfaces;
                }
                catch { }
            }

            System.Console.WriteLine(numberOfNetworkInterfaces);

            if (numberOfNetworkInterfaces == 0)
            {
                MessageBox.Show("No Network Interface were found on this local machine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegistryKey networkRegistry = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkCards");
            int num = networkRegistry.SubKeyCount;
            string[] tmp = networkRegistry.GetSubKeyNames();
            for (int i = 0; i < num; ++i)
            {
                RegistryKey conReg = networkRegistry.OpenSubKey(tmp[i]);
                if (conReg != null)
                {
                    string[] tmp1 = conReg.GetSubKeyNames();
                    if (tmp1.Length > 0)
                    {
                        for(int j=0;j<tmp1.Length; ++j)
                        {
                            RegistryKey reg = conReg.OpenSubKey(tmp1[j]);
                            if(reg != null)
                            {
                                int gg = Array.BinarySearch(networkInterfacesSettingId, 0, numberOfNetworkInterfaces, tmp1[j]);
                                if (gg >= 0)
                                {
                                    RegistryKey r = reg.OpenSubKey("connection");
                                    if(r != null)
                                    {
                                        Object obj = reg.GetValue("Name");
                                        networkInterfaces[gg] = obj.ToString();
                                    }//if r
                                }//if gg
                            }//if reg
                        }//for
                    }//if tmp1.Length
                }//if conReg
            }//for

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }//Main
    }//class Program
}//namespace EZNIC
