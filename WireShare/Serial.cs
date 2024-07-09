using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace WireShare
{
    public partial class Serial : UserControl
    {
        public Serial()
        {
            InitializeComponent();
        }

        private void Serial_Load(object sender, EventArgs e)
        {
            comboboxparity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboboxparity.SelectedIndex = 0; // Default selection

            // Populate StopBits ComboBox
            comboboxstopbits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            comboboxstopbits.SelectedIndex = 0; // Default selection

            // Populate DataBits ComboBox
            comboboxdatabits.Items.AddRange(new object[] { 5, 6, 7, 8 });
            comboboxdatabits.SelectedIndex = 3; // Default selection

            comboboxbaud.Items.AddRange(new object[] { 9600, 14400, 19200, 38400, 57600, 115200 });
            comboboxbaud.SelectedIndex = 0; // Default selection

            var ports = SerialPort.GetPortNames();
            comboboxPorts.Items.AddRange(ports);
         
        }

        void connect()
        {

        }
    }
}
