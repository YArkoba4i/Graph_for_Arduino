using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Windows.Forms;

namespace Graph_for_Arduino
{
    public partial class FormUART : Form
    {
     
        SerialPort ComPort = new SerialPort();
        public FormUART()
        {
            InitializeComponent();
        }

        private void btnReadUARTPorts_Click(object sender, EventArgs e)
        {
            cboPorts.Items.Clear();
            try
            {
                
                string[] ArrayComPortsNames = null;
                int index = -1;
                string ComPortName = null;

                ArrayComPortsNames = SerialPort.GetPortNames();
                do
                {
                    index += 1;
                    cboPorts.Items.Add(ArrayComPortsNames[index]);
                }

                while (!((ArrayComPortsNames[index] == ComPortName)
                              || (index == ArrayComPortsNames.GetUpperBound(0))));
                Array.Sort(ArrayComPortsNames);

                //want to get first out
                if (index == ArrayComPortsNames.GetUpperBound(0))
                {
                    ComPortName = ArrayComPortsNames[0];
                }
                cboPorts.Text = ArrayComPortsNames[0];

                initializeBoudRate();
            }
            catch { }
        }
        private void initializeBoudRate()
        {
            cboBaudRate.Items.Clear();
            cboBaudRate.Items.Add(300);
            cboBaudRate.Items.Add(600);
            cboBaudRate.Items.Add(1200);
            cboBaudRate.Items.Add(2400);
            cboBaudRate.Items.Add(9600);
            cboBaudRate.Items.Add(14400);
            cboBaudRate.Items.Add(19200);
            cboBaudRate.Items.Add(38400);
            cboBaudRate.Items.Add(57600);
            cboBaudRate.Items.Add(115200);
            cboBaudRate.Items.ToString();
            //get first item print in text
            cboBaudRate.Text = cboBaudRate.Items[4].ToString();
        }

        private void btnTestConection_Click(object sender, EventArgs e)
        {
            int _dataBits = 8;
            Handshake _handshake = Handshake.None;
            Parity _parity = Parity.None;
            StopBits _stopBits = StopBits.One;


            
            ComPort.PortName = Convert.ToString(cboPorts.Text);
            ComPort.BaudRate = Convert.ToInt32(cboBaudRate.Text);
            ComPort.DataBits = _dataBits;
            ComPort.Handshake = _handshake;
            ComPort.Parity = _parity;
            ComPort.StopBits = _stopBits;
         //   ComPort.DataReceived += new SerialDataReceivedEventHandler(_serialPort_DataReceived);

            try
            {
                ComPort.Open();
                if (ComPort.IsOpen)
                {
                    lblConnectionStatus.Text = "Port is opened";
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
        private void btnCloseConnection_Click(object sender, EventArgs e)
        {
            if (ComPort.IsOpen)
            {
                ComPort.Close();
                lblConnectionStatus.Text = "Port is Closed";
            }
            
        }

        private void btnReadUART_Click(object sender, EventArgs e)
        {
            textBox1.Text = ComPort.ReadLine();
        }

        public string getCoordinatesLine()
        {
            return ComPort.ReadLine();
        }
    }
}
