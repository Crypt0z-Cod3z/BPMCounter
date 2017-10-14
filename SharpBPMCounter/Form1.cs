using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SharpBPMCounter
{
    public partial class Form1 : Form
    {
        /*Globals*/

        public bool DoingBPM = false;
        public Stopwatch timer = new Stopwatch();
        public long beats = 0;

        /*********/
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beats += 1;
            if (!DoingBPM)
            {
                DoingBPM = true;
                timer.Start();
            }
            if (timer.ElapsedMilliseconds != 0)
            {
                float bpm_fl = (beats / ((float)timer.ElapsedMilliseconds / 1000)) * 60;
                button1.Text = Math.Round(bpm_fl).ToString() + " BPM";
            }
            else
                button1.Text = "0 BPM";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Click";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BPM Pad |2017|\nCoded by Crypt0z on 10/14/17\nSource on my Github", "About BPM Pad");
        }
    }
}
