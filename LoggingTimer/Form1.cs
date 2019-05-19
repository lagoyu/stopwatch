using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoggingTimer
{
    public partial class Form1 : Form
    {
        //private static FileStream fs = new FileStream(@"c:\temp\mcb.txt", FileMode.OpenOrCreate, FileAccess.Write);
        //private static StreamWriter m_streamWriter = new StreamWriter(fs);

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //m_streamWriter.WriteLine("{0} {1}",
            //DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            //m_streamWriter.Flush();
            UpdateTime();
 
        }

        private void UpdateTime()
        {
            if (numericUpDown1.Value + numericUpDown1.Increment < numericUpDown1.Maximum)
            {
                numericUpDown1.Value += (decimal) numericUpDown1.Increment;
            }
            else
            {
                timer1.Stop();
                ResetButton.Focus();
            }

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // Write to the file using StreamWriter class    
            //m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            //m_streamWriter.Write(" File Write Operation Starts : ");
            //m_streamWriter.WriteLine("{0} {1}",
            //DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
            //m_streamWriter.WriteLine("===================================== \n");
            //m_streamWriter.Flush();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            StopButton.Focus();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            StartButton.Focus();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            numericUpDown1.Value = 0;
        }
    }
}
