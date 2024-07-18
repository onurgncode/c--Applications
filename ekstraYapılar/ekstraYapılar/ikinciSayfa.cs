using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Point = System.Drawing.Point;

namespace ekstraYapılar
{
    public partial class ikinciSayfa : Form
    {
        public ikinciSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Point loca = new Point();
            loca.X = 10;
            loca.Y = 10;
            pictureBox1.Location = loca;
            
        }
    }
}
