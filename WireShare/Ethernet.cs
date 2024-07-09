using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WireShare
{
    public partial class Ethernet : UserControl
    {
        UdpClient udpClient;
        public Ethernet()
        {
            InitializeComponent();
        }

        private void StartServer()
        {
            try
            {
                udpClient = new UdpClient(8000);

                while (true)
                {
                    IPEndPoint remoteEndPoint = new IPEndPoint(IPAddress.Any, 8000);
                    byte[] receivedData = udpClient.Receive(ref remoteEndPoint);

               
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Server error: {ex.Message}");
            }
        }
    }
}
