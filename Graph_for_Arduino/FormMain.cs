using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graph_for_Arduino
{
    public partial class FormBarometr : Form
    {
        //SerialPort ComPort = new SerialPort();
        public FormBarometr()
        {
            InitializeComponent();
        }

        // btnREadData
        private void button2_Click(object sender, EventArgs e)
        {
            this.GraphTH.Series["Temperature"].Points.AddXY(15, 10);
            this.GraphTH.Series["Temperature"].Points.AddXY(25, 20);
            this.GraphTH.Series["Temperature"].Points.AddXY(35, 30);
            this.GraphTH.Series["Temperature"].Points.AddXY(40, 40);
            this.GraphTH.Series["Temperature"].Points.AddXY(35, 50);
            this.GraphTH.Series["Temperature"].Points.AddXY(15, 60);
        }

        // btnConfigureUART
        private void button1_Click(object sender, EventArgs e)
        {
            FormUART uartform = new FormUART();
            uartform.Show();

        }
    }
}
