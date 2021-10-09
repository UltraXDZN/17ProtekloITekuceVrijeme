using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProtekloITekuceVrijeme
{
    public partial class Form1 : Form
    {
        DateTime m_start;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_start = DateTime.Now;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trenutnoVrijeme.Text = $"Trenutno: {DateTime.Now.ToLongTimeString()}";

            TimeSpan proteklo = DateTime.Now - m_start;

            protekloVrijeme.Text = $"Proteklo: {proteklo.Hours}:{proteklo.Minutes}:{proteklo.Seconds}";
        }
    }
}
