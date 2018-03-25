using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EZNIC
{
    public partial class Form1 : Form
    {
        private Profile[] profileList = new Profile[1];

        public Form1()
        {
            InitializeComponent();
            dhcpControl2.BringToFront();
        }

#pragma warning disable IDE1006 // Naming Styles
        private void write(Profile obj)
#pragma warning restore IDE1006 // Naming Styles
        {
            StreamWriter sw = new StreamWriter("Profiles.txt"); //writing to profiles.txt
            sw.WriteLine(profileList.Length + 1);               //incrementing length of array
            sw.WriteLine(obj.IpAddress);
            sw.WriteLine(obj.SubnetMask);
            sw.WriteLine(obj.DefaultGateway);

            for(int i = 0; i < profileList.Length; i++)
            {
                sw.WriteLine(profileList[i].IpAddress);
                sw.WriteLine(profileList[i].SubnetMask);
                sw.WriteLine(profileList[i].DefaultGateway);
            }

            sw.Close();
        }

        private void Read()
        {
            StreamReader sr = new StreamReader("Profiles.txt");
            profileList = new Profile[Convert.ToInt32(sr.ReadLine())];

            for(int i = 0; i < profileList.Length; i++)
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

            private void Title_Click(object sender, EventArgs e)
        {

        }

#pragma warning disable IDE1006 // Naming Styles
        private void btnProfiles_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
            profilesControl1.BringToFront();
        }

#pragma warning disable IDE1006 // Naming Styles
        

#pragma warning disable IDE1006 // Naming Styles
        private void btnDHPC_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {
           
        }

#pragma warning disable IDE1006 // Naming Styles
        private void btnApplyDHPC_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

#pragma warning disable IDE1006 // Naming Styles
        private void radioAutoIP_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

#pragma warning disable IDE1006 // Naming Styles
        private void radioStaticIP_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

#pragma warning disable IDE1006 // Naming Styles
        private void radioAutoDNS_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

#pragma warning disable IDE1006 // Naming Styles
        private void radioSpecifyDNS_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

#pragma warning disable IDE1006 // Naming Styles
        private void panel3_Paint(object sender, PaintEventArgs e)
#pragma warning restore IDE1006 // Naming Styles
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dhcpControl2_Load(object sender, EventArgs e)
        {

        }

        private void profilesControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnDHCP_Click(object sender, EventArgs e)
        {
            dhcpControl2.BringToFront();
        }

        private void profilesControl2_Load(object sender, EventArgs e)
        {

        }

        private void dhcpControl1_Load(object sender, EventArgs e)
        {

        }

        private void profilesControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
