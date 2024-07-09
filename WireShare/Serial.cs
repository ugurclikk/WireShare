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
using System.Xml.Serialization;

namespace WireShare
{
    public partial class Serial : UserControl
    {
        System.Windows.Forms.Timer Sendtimer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer Receivetimer = new System.Windows.Forms.Timer();

        private SerialPort serialPort;
        private Thread readThread;
        private bool keepReading;
        public Serial()
        {
            InitializeComponent();
            serialPort = new SerialPort();
        }

        private void Serial_Load(object sender, EventArgs e)
        {
            comboboxparity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboboxparity.SelectedIndex = 0; // Default selection

            // Populate StopBits ComboBox
            comboboxstopbits.Items.AddRange(Enum.GetNames(typeof(StopBits)));
            comboboxstopbits.SelectedIndex = 1; // Default selection

            // Populate DataBits ComboBox
            comboboxdatabits.Items.AddRange(new object[] { 5, 6, 7, 8 });
            comboboxdatabits.SelectedIndex = 3; // Default selection

            comboboxbaud.Items.AddRange(new object[] { 9600, 14400, 19200, 38400, 57600, 115200 });
            comboboxbaud.SelectedIndex = 0; // Default selection

            var ports = SerialPort.GetPortNames();
            comboboxPorts.Items.AddRange(ports);
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var msg = serialPort.ReadExisting();
            textBoxReceive.Text += msg;
        }

        void connect()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                }

                serialPort.PortName = comboboxPorts.SelectedItem.ToString();
                serialPort.BaudRate = int.Parse(comboboxbaud.SelectedItem.ToString());
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), comboboxparity.SelectedItem.ToString());
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboboxstopbits.SelectedItem.ToString());
                serialPort.DataBits = int.Parse(comboboxdatabits.SelectedItem.ToString());
                serialPort.Open();

              /*  keepReading = true;
                readThread = new Thread(ReadFromPort);
                readThread.Start();*/

                Receivetimer.Enabled = Enabled;
                Receivetimer.Interval = 1000;
                Receivetimer.Tick += Timer_Tick;
                Receivetimer.Start();

                Sendtimer.Enabled = Enabled;
                Sendtimer.Interval = 1000;
                Sendtimer.Tick += Timer_Tick_Send;
              

                MessageBox.Show("Connected to " + serialPort.PortName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void disconnect()
        {
            try
            {
                if (serialPort.IsOpen)
                {
                    serialPort.Close();
                    MessageBox.Show("Disconnected from " + serialPort.PortName);
                }
                else
                {
                    MessageBox.Show("No active connection to disconnect.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        void writeScreen()
        {
           

        }
        private void Timer_Tick(object sender, EventArgs e)
        {
           
            {
                try
                {
                    string message = serialPort.ReadExisting();
                    // UI thread'e veriyi yazdırmak için Invoke kullanın
                    this.Invoke(new MethodInvoker(delegate
                    {
                        // Örneğin, bir TextBox veya ListBox'a yazdırabilirsiniz
                        if (message != "")
                        { textBoxReceive.AppendText(message + Environment.NewLine); }
                    }));
                }
                catch (TimeoutException) { }
                catch (Exception ex)
                {
                    // Hata durumunda UI thread'e hata mesajını yazdırmak için Invoke kullanın
                    this.Invoke(new MethodInvoker(delegate
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }));
                }
            }
        }
    

    private void buttonConnect_Click(object sender, EventArgs e)
        {
            connect();
        }

        private void ButtonDisconnect_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void textBoxReceive_TextChanged(object sender, EventArgs e)
        {

        }
        private void Timer_Tick_Send(object sender, EventArgs e)
        {
           
            
                serialPort.Write(textBoxSend.Text);
                

            
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            Sendtimer.Start();
        }
    }
}
