using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progressBar
{
    public partial class yemekPisir : Form
    {
        public yemekPisir()
        {
            InitializeComponent();
        }

        private void yemekPisir_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if(progressBar1.Value == 1000)
            {
                timer1.Stop();
                timer2.Start();
            }
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.White;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.SeaGreen;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
            if (progressBar2.Value % 20 == 10)
            {
                label2.BackColor = Color.White;
            }
            if (progressBar2.Value % 20 == 0)
            {
                label2.BackColor = Color.SeaGreen;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if (progressBar3.Value == 1000)
            {
                timer3.Stop();
                
            }
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.White;
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.SeaGreen;
            }
        }
    }
}
