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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value -= 10;
        }
        yemekPisir ek = new yemekPisir();
        private void button3_Click(object sender, EventArgs e)
        {
            ek.Show();
        }
    }
}
