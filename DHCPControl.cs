using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZNIC
{
    public partial class DHCPControl : UserControl
    {
        private Profile[] profileList = new Profile[1];

        public DHCPControl()
        {
            InitializeComponent();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void label1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

        private void write(Profile obj)
#pragma warning restore IDE1006 // Naming Styles
        {
            StreamWriter sw = new StreamWriter("Profiles.txt"); //writing to profiles.txt
            //sw.WriteLine(profileList.Length + 1);               //incrementing length of array
            sw.WriteLine(obj.IpAddress);
            sw.WriteLine(obj.SubnetMask);
            sw.WriteLine(obj.DefaultGateway);

            /*for (int i = 0; i < profileList.Length; i++)
            {
                sw.WriteLine(profileList[i].IpAddress);
                sw.WriteLine(profileList[i].SubnetMask);
                sw.WriteLine(profileList[i].DefaultGateway);
            }*/

            sw.Close();
        }

        private void Read()
        {
            StreamReader sr = new StreamReader("Profiles.txt");
            profileList = new Profile[Convert.ToInt32(sr.ReadLine())];

            for (int i = 0; i < profileList.Length; i++)
            {
#pragma warning disable IDE0017 // Simplify object initialization
                profileList[i] = new Profile();
#pragma warning restore IDE0017 // Simplify object initialization
                profileList[i].IpAddress = sr.ReadLine();
                profileList[i].SubnetMask = sr.ReadLine();
                profileList[i].DefaultGateway = sr.ReadLine();
            }

            sr.Close();
        }

        private void btnApplyDHCP_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateNewProf_Click(object sender, EventArgs e)
        {
            Profile obj = new Profile();
            obj.IpAddress = ipAddressInput.Text;
            obj.SubnetMask = subnetMaskInput.Text;
            obj.DefaultGateway = defaultGatewayInput.Text;

            write(obj);
            Read();
        }

        private void ipAddressInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioStaticIP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioAutoIP_CheckedChanged(object sender, EventArgs e)
        {
            if(radioAutoIP.Checked) {
                ipAddressInput.Enabled = false;
                subnetMaskInput.Enabled = false;
                defaultGatewayInput.Enabled = false;
            }
            else
            {
                ipAddressInput.Enabled = true;
                subnetMaskInput.Enabled = true;
                defaultGatewayInput.Enabled = true;
            }
        }

        private void subnetMaskInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void defaultGatewayInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioAutoDNS_CheckedChanged(object sender, EventArgs e)
        {
            if(radioAutoDNS.Checked)
            {
                dnsAddressInput.Enabled = false;
            }
            else
            {
                dnsAddressInput.Enabled = true;
            }
        }

        private void dnsAddressInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
