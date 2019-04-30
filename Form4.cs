using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using Bunifu;

namespace YTM
{
    public partial class Form4 : Form
        
    {
        int T = 180;
        int n = 0;
        
        public Form4()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            
        }

       
        private void FormInsertionB_Load(object sender, EventArgs e)
        {
            C1.Visible = false;
            C2.Visible = false;
            C3.Visible = false;
            P1.Visible = false;
            P2.Visible = false;
            P3.Visible = false;
            WindowState = FormWindowState.Maximized;
            PB.Value = 0;
            Chrono.Text = (TimeSpan.FromMinutes(T)).ToString();
            PB.Value= 0;

        }

        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.BaudRate = 9600;
                serialPort1.PortName = "COM8";
                serialPort1.Open();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            timer1.Start();
            
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
           
            string test = serialPort1.ReadLine();
             
            if (string.Equals(test, "1\r")) 
            {
                C1.Visible = true;
            }
            if (string.Equals(test, "2\r"))
            {
                C2.Visible = true;
            }
            if (string.Equals(test, "3\r"))
            {
                C3.Visible = true;
            }
            if(C3.Visible == true & C2.Visible == true & C1.Visible == true)
            {
                serialPort1.Close();
                timer1.Stop();
                T = 180;
                PB.Value = 0;
                Chrono.Text = (TimeSpan.FromMinutes(T)).ToString();
                Start.Enabled = false;
                Stop.Enabled = false;
            }

            

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            timer1.Stop();
            T = 180;
            PB.Value = 0;
            Chrono.Text = (TimeSpan.FromMinutes(T)).ToString();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            T = T - 1;
            if (T%9==0) {
                PB.Value= PB.Value + 5;
            }
            Chrono.Text = (TimeSpan.FromMinutes(T)).ToString();
            if (T == 0)
            { timer1.Stop();
                if ((C3.Visible == false || C2.Visible == false || C1.Visible == false) )
                {
                    Start.Enabled = false;
                    Stop.Enabled = false;
                    if (C3.Visible == false) { P3.Visible = true; }
                    if (C2.Visible == false) { P2.Visible = true; }
                    if (C1.Visible == false) { P1.Visible = true; }
                }
            }
        }
    }
}
