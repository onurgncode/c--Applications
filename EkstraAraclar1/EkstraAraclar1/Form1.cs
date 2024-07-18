using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EkstraAraclar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void griToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor= Color.Green;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void çıkılToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yıldızlarArasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=vVJeYMRam0o");
        }
    }
}
