using System.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Collections;
using System.Runtime.InteropServices;

namespace Laba_1_Arhitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public IPAddress IpStartPoint;
        public IPAddress IpEndPoint;
        IPAddress subnetAddress;
        IPAddress maskAdress;
        IPAddress BroadcastAdress;
        byte[] mask = new byte[4];
        [DllImport("iphlpapi.dll", ExactSpelling = true)]
        public static extern int SendARP(int DestIP, int SrcIP, [Out] byte[] pMacAddr, ref int PhyAddrLen);

        public static string GetMacByIp(IPAddress ip)
        {

            byte[] ab = new byte[6];
            int len = ab.Length;
            int r = SendARP((int)ip.Address, 0, ab, ref len);
            if (r != 0) throw new ApplicationException("SendARP failed with code " + r.ToString());
            return BitConverter.ToString(ab, 0, 6);
        }

        private IPAddress GetBroadcastAddress()
        {
            byte[] networkBytes = subnetAddress.GetAddressBytes();
            byte[] maskBytes = maskAdress.GetAddressBytes();
            byte[] broadcastBytes = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                broadcastBytes[i] = (byte)(networkBytes[i] | ~maskBytes[i]);
            }

            return new IPAddress(broadcastBytes);
        }
            private void FindAdess()
        {
            uint start = BitConverter.ToUInt32(IpStartPoint.GetAddressBytes(), 0);
            uint maskUint = BitConverter.ToUInt32(mask, 0);

            uint subnet = start & maskUint;
            byte[] subnetBytes = BitConverter.GetBytes(subnet);
            subnetAddress = new IPAddress(subnetBytes);
            TB_Adress.Text = subnetAddress.ToString();
        }
        private void Mask_finder()
        {
            byte[] begin = IpStartPoint.GetAddressBytes();
            byte[] end = IpEndPoint.GetAddressBytes();

            bool edge = false;
            for (int i = 0; i < 4; i++)
            { 
                for(byte b = 128; b >= 1; b /= 2)
                {
                    byte A = (byte)(begin[i] & b);
                    byte B = (byte)(end[i]& b);
                    if(!edge && (A == B))
                    {
                        mask[i] |= b;    

                    }
                    else
                    {
                        edge = true;
                        mask[i] = (byte)(mask[i] & ~b);
                    }
                }
            }




    }
    private void Process_Click(object sender, EventArgs e)
        {
            try
            {
                TB_Mask.Text = "";
                IPAddress.TryParse(TB_IpStart.Text, out IpStartPoint);
                IPAddress.TryParse(TB_IpEnd.Text, out IpEndPoint);
                Mask_finder();
                maskAdress = new IPAddress(mask);
                TB_Mask.Text = maskAdress.ToString();
                FindAdess();
                BroadcastAdress = GetBroadcastAddress();
                TB_Broadcast_Adress.Text = BroadcastAdress.ToString();
                TB_Mac_Adress.Text = GetMacByIp(IpStartPoint);
            }
            catch (Exception ex) { }

        }
    }
}
