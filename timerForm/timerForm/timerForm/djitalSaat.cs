using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timerForm
{
    public partial class djitalSaat : Form
    {
        public djitalSaat()
        {
            InitializeComponent();
        }
        int saniye = 0, dakika = 59, saat = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            
            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }
            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }
            Lblsaat.Text = saat.ToString();
            Lblsaniye.Text = saniye.ToString();
            Lbldk.Text = dakika.ToString();
        }
        private void djitalSaat_Load(object sender, EventArgs e)
        {
            
        }
    }
}
